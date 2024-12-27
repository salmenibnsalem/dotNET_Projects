using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Dtos
{
    public class GenreDto
    {
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
