using System.ComponentModel.DataAnnotations;

namespace StudentAccount.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}
