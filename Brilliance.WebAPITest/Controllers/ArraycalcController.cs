using System;
using System.Collections.Generic;
using System.Web.Http;
using Brilliance.WebAPITest.Helper;
using Brilliance.WebAPITest.Repository;
namespace Brilliance.WebAPITest.Controllers
{
    public class ArraycalcController : ApiController, IArraycalcController
    {
       
        [HttpGet]
        [Route("api/Arraycalc/Reverse")]
        public IHttpActionResult Reverse([FromUri] int[] productIds)
        {
            List<int> result = new List<int>();
            try
            {
                var repository = new ProductsRepository();

                // get the reverse of the product ids in the repository                 
                result.AddRange(repository.Reverse(productIds));

            }
            catch (NotFoundAPIException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
            return Ok(result);
        }

      
        [HttpGet]
        [Route("api/Arraycalc/Deletepart")]
        public IHttpActionResult Deletepart(int position, [FromUri] int[] productIds)
        {
            List<int> result = new List<int>();
            try
            {
                var repository = new ProductsRepository();

                // get the result array after deleting the provided postion of the array   
                result.AddRange(repository.Deletepart(position,productIds));
                
            }
            catch (NotFoundAPIException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
            return Ok(result);
        }
    }
}
