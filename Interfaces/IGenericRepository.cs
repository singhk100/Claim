using Claim.Models;
using Claim.ViewModel;
using Newtonsoft.Json.Linq;

namespace Claim.Interfaces
{
    public interface IGenericRepository
    {
        public List<GenericVM> GetGeneric(List<GenericVM> genericQuery);

    }
}
