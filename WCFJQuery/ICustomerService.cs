using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using WCFJQuery.Model;

namespace WCFJQuery
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        [WebInvoke(Method = "GET")]
        IQueryable<Customer> GetCustomers();
    }
}
