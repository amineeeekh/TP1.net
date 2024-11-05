using System.ComponentModel.DataAnnotations;

namespace tp1.Models
{
    public class Employee : IEquatable<Employee>
    {
        public int Id { get; set; }
        [Required, StringLength(20, ErrorMessage = "taille max 20 caracteres ")]
        public string Name { get; set; }

        [Required]
        public string Departement { get; set; }

        [Range(200, 5000)]
        public int Salary { get; set; }

        public bool Equals(Employee other)
        {
            return this.Id == other.Id;
        }
    }
}
