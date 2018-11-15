using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brilliance.WebAPITest.Repository
{
    interface IProductsRepository:IDisposable
    {
        IEnumerable<int> Reverse(int[] productIds);

        IEnumerable<int> Deletepart(int position, int[] productIds);
    }
}
