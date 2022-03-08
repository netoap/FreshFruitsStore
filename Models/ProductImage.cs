using System.ComponentModel.DataAnnotations;

namespace FreshFruitsStore.Models
{
    public class ProductImage
    {
        public int ID { get; set; }
        [Display(Name ="File")]
        public string FileName { get; set; }
    }
}