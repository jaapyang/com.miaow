using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.miaow.Core.Domain.Entities;

namespace com.miaow.Model
{
    public class CustomerModel : Entity<string>
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }
    }
}
