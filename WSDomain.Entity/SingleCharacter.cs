using System.ComponentModel.DataAnnotations;

namespace WSDomain.Entity
{
    public class SingleCharacter
    {
        // sigle character entity for rick and morty api
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public CharacterOrigin Origin { get; set; }
        public CharacterLocation Location { get; set; }
        public string Image { get; set; }
        public string[] Episode { get; set; }
        public string Url { get; set; }
        public string Created { get; set; }


    }
}