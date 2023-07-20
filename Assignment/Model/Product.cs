using System.ComponentModel.DataAnnotations;

namespace Assignment.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? UnitName { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public int? ParentCode { get; set; }
        public string? ProductBarcode { get; set; }
        public string? Description { get; set; }
        public string? BrandName { get; set; }
        public string? SizeName { get; set; }
        public string? ColorName { get; set; }
        public string? ModelName { get; set; }
        public string? VariantName { get; set; }
        public int? OldPrice { get; set; }
        public int? Price { get; set; }
        public int? CostPrice { get; set; }
        public int? stock { get; set; }
        public int? TotalPurchase { get; set; }
        public DateTime? LastPurchaseDate { get; set; }
        public string? LastPurchaseSupplier { get; set; }
        public int? TotalSales { get; set; }
        public DateTime? LastSalesDate { get; set; }
        public string? LastSalesCustomer { get; set; }
        public string? ImagePath { get; set; }
        public string? Type { get; set; }
        public string? Status { get; set; }
    }
}
