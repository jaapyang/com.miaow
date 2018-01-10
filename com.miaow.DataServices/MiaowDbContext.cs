using System.Data.Entity;
using com.miaow.Model;

namespace com.miaow.DataServices
{
    public partial class MiaowDbContext : DbContext
    {
        public MiaowDbContext() : base("com.miaow.coreDb") { }
    }
}