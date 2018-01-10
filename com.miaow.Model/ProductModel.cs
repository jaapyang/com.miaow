using com.miaow.Core.Domain.Entities;

namespace com.miaow.Model
{
    public class ProductModel : Entity
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}