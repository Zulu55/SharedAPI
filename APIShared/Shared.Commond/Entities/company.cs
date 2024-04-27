using System.ComponentModel.DataAnnotations;

namespace Shared.Common.Entities
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Address { get; set; } = null!;

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
        public string Manager { get; set; } = null!;
    }
}