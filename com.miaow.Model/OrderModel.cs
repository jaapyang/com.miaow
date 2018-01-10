using System;
using System.Collections.Generic;
using com.miaow.Core.Domain.Entities;

namespace com.miaow.Model
{
    public class OrderModel : Entity
    {
        public string CustomerId { get; set; }

        public virtual CustomerModel CustomerModel { get; set; }

        public virtual List<OrderDetailModel> OrderDetailList { get; set; }
        public DateTime OrderTime { get; set; }
    }
}