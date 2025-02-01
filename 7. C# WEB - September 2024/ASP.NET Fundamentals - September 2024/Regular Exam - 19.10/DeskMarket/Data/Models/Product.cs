using DeskMarket.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DeskMarket.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(Validations.ProductNameMaxLength)]
        [Comment ("Name of the product")]
        public string ProductName { get; set; } = null!;

        [Required]
        [StringLength(Validations.ProductDescriptionMaxLength)]
        [Comment ("Description")]
        public string Description { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), Validations.ProductPriceMinValue, Validations.ProductPriceMaxValue)]
        [Comment ("The price of the product")]
        public decimal Price { get; set; }

        [Comment ("The URL of the Image")]
        public string? ImageUrl { get; set; }

        [Required]
        public string SellerId { get; set; } = null!;

        [Required]
        public IdentityUser Seller { get; set; } = null!;

        [Required]
        public DateTime AddedOn { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public Category Category { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        public virtual ICollection<ProductClient> ProductsClients { get; set; } = new HashSet<ProductClient>();
    }
}
