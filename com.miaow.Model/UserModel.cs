using com.miaow.Core.Domain.Entities;

namespace com.miaow.Model
{
    public class UserModel : Entity<int>
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}