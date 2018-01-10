using System;
using com.miaow.Core.Domain.Entities;

namespace com.miaow.Model
{
    public class ShoppingCartModel : Entity<int>
    {
        public int UserId { get; set; }
        public virtual UserModel UserModel { get; set; }
        public DateTime CreateTime { get; set; }
    }
}