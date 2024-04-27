
using System.ComponentModel.DataAnnotations;


namespace Shared.Common.Entities
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string DocumentType { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        public string Document { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public string Gender { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        [MinLength(20)]
        public string Phone { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        [MinLength(20)]
        public string Addres { get; set; } = null!;

    }
}
