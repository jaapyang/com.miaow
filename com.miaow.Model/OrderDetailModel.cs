using com.miaow.Core.Domain.Entities;

namespace com.miaow.Model
{
    public class OrderDetailModel : Entity
    {
        public int OrderId { get; set; }

        public virtual OrderModel OrderModel { get; set; }
        public virtual ProductModel ProductModel { get; set; }
        public int Quantity { get; set; }
    }
}