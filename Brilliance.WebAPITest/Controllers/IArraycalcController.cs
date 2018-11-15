using System;
using System.Web.Http;

namespace Brilliance.WebAPITest.Controllers
{
    public interface IArraycalcController: IDisposable
    {

        IHttpActionResult Reverse([FromUri] int[] productIds);

        IHttpActionResult Deletepart(int position, [FromUri] int[] productIds);
    }
}
