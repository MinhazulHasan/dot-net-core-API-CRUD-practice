using Assignment.Model;
using Assignment.Repository.Interface;

namespace Assignment.Repository.Service
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
        }

        public override Task<List<Product>> GetAllEntity()
        {
            return base.GetAllEntity();
        }

        public override async Task<Product> GetEntity(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public override async Task<bool> AddEntity(Product entity)
        {
            try
            {
                await dbSet.AddAsync(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override async Task<bool> UpdateEntity(Product product)
        {
            try
            {
                var existProduct = await dbSet.FindAsync(product.Id);
                if (existProduct != null)
                {
                    existProduct.CategoryId = product.CategoryId;
                    existProduct.CategoryName = product.CategoryName;
                    existProduct.UnitName = product.UnitName;
                    existProduct.Name = product.Name;
                    existProduct.Code = product.Code;
                    existProduct.ParentCode = product.ParentCode;
                    existProduct.ProductBarcode = product.ProductBarcode;
                    existProduct.Description = product.Description;
                    existProduct.BrandName = product.BrandName;
                    existProduct.SizeName = product.SizeName;
                    existProduct.ModelName = product.ModelName;
                    existProduct.VariantName = product.VariantName;
                    existProduct.OldPrice = product.OldPrice;
                    existProduct.Price = product.Price;
                    existProduct.CostPrice = product.CostPrice;
                    existProduct.stock = product.stock;
                    existProduct.TotalPurchase = product.TotalPurchase;
                    existProduct.LastPurchaseDate = product.LastPurchaseDate;
                    existProduct.LastPurchaseSupplier = product.LastPurchaseSupplier;
                    existProduct.TotalSales = product.TotalSales;
                    existProduct.LastSalesDate = product.LastSalesDate;
                    existProduct.LastSalesCustomer = product.LastSalesCustomer;
                    existProduct.ImagePath = product.ImagePath;
                    existProduct.Type = product.Type;
                    existProduct.Status = product.Status;

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public override async Task<bool> DeleteEntity(int id) {
            try
            {
                var existProduct = await dbSet.FindAsync(id);
                if (existProduct != null)
                {
                    dbSet.Remove(existProduct);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }




    }
}
