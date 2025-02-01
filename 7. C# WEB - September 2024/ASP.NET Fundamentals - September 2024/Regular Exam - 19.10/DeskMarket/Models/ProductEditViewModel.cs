using DeskMarket.Constants;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace DeskMarket.Models
{
    public class ProductEditViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(Validations.ProductNameMaxLength, MinimumLength = Validations.ProductNameMinLength)]
        public string ProductName { get; set; } = null!;

        [Required]
        [StringLength(Validations.ProductDescriptionMaxLength, MinimumLength = Validations.ProductDescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), Validations.ProductPriceMinValue, Validations.ProductPriceMaxValue)]
        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }

        [Required]
        [RegexStringValidator(@"^\d{4}-\d{2}-\d{2}$")]
        public string AddedOn { get; set; } = null!;

        [Range(1, int.MaxValue)]
        public int CategoryId { get; set; }

        [Required]
        public string SellerId { get; set; } = null!;

        public virtual IEnumerable<CategoryViewModel>? Categories { get; set; }
    }
}
