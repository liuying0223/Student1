using System.ComponentModel.DataAnnotations;

namespace Student1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Nameuse { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Brith { get; set; }
        public string? phon { get; set; }
        public float? Tem { get; set; }
        public DateTime? Datetime { get; set; }
    }
}
