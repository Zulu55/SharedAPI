using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Shared.Common.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; } = null!;

        [MaxLength(255)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(1, 1000, MinimumIsExclusive = true, MaximumIsExclusive = false)]
        public double Price { get; set; }

        [Range(1, 100)]
        public double Discount { get; set; }

    }
}
