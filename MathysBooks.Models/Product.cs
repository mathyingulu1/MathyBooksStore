using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathysBooks.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set;}
        public string Description { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        [Required]
        [Range(1,1000)]
        public double ListPrice { get; set; }
        public string ImageUrl { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category category { get; set; }

        [Required]
        public int CovertypeId { get; set; }
        [Foreignkey("CategoryId")]
        public CoverType coverType { get; set; }

    }
}
