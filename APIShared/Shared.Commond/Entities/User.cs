using System.ComponentModel.DataAnnotations;

namespace Shared.Common.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        [MinLength(20)]
        public string Phone { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        [MinLength(4)]
        public string Password { get; set; } = null!;
    }
    public class Employee
    {
        public int IdEmployee { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        [MinLength(20)]
        public string Phone { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        [MinLength(4)]
        public string Password { get; set; } = null!;

        [Required]      
        public decimal Salario { get; set; } 
         
      
    }
}
