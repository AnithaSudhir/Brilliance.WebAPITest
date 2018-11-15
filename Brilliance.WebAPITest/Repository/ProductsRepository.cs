using System;
using System.Collections.Generic;


namespace Brilliance.WebAPITest.Repository
{
    public class ProductsRepository: IProductsRepository
    {
        public ProductsRepository()
        {

        }
        public IEnumerable<int> Reverse(int[] productIds)
        {
            try
            {
                for (int i = 0; i < productIds.Length / 2; i++)
                {
                    int result = productIds[i];

                    productIds[i] = productIds[productIds.Length - i - 1];

                    productIds[productIds.Length - i - 1] = result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productIds;
        }

        public IEnumerable<int> Deletepart(int position, int[] productIds)
        {
            List<int> result = new List<int>();
            try
            {
                int index = position - 1;

                for (int i = 0; i < productIds.Length; i++)
                {
                    if (index != i)
                    {
                        result.Add(productIds[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ProductsRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}
    }
}