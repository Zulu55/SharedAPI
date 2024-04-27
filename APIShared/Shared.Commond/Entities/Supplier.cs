using System.ComponentModel.DataAnnotations;

namespace Shared.Common.Entities
{
    public class Supplier
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        public int Type { get; set; }

        [MaxLength(100)]
        public string? Address { get; set; }

        [MaxLength(100)]
        public string? Phone { get; set; }

        [MaxLength(100)]
        public string? WebUrl { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }
    }
}