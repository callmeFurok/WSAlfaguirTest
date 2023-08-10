
using Microsoft.EntityFrameworkCore;
using WSApplication.Interface;
using WSApplication.Main;
using WSDomain.Core;
using WSDomain.Interface;
using WSInfraestructure.Data;
using WSInfraestructure.Interface;
using WSInfraestructure.Repository;

namespace WSServices.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // add inmemory db using ef
            builder.Services.AddDbContext<InMemoryDbContext>(options =>
            {
                options.UseInMemoryDatabase("InMemoryDb");
            });

            // add character services
            builder.Services.AddScoped<ICharacterRepository, CharactersRepository>();
            builder.Services.AddScoped<ICharactersDomain, CharactersDomain>();
            builder.Services.AddScoped<ICharacterApplication, CharactersApplication>();



            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options => options.AddPolicy("AllowAll", p => p.AllowAnyOrigin()
                                                   .AllowAnyMethod()
                                                   .AllowAnyHeader()));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}