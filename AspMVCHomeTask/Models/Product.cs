using System.ComponentModel.DataAnnotations;

namespace AspMVCHomeTask.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImagePath { get; set; }
    }
}
