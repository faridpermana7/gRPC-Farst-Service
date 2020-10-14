using System;

namespace GrpcFarstCommon
{
    public abstract class ManagerBase<TContext> : IDisposable, IContextBase<TContext>, IManager
    {
        private TContext dbContext;

        protected ManagerBase()
        {
            dbContext = Activator.CreateInstance<TContext>();
        }

        protected ManagerBase(TContext dbContext)
        {
            this.dbContext = dbContext;
        }


        protected virtual void PrepareAssistant(TContext dbContext)
        {
            throw new NotImplementedException();
        }


        public TContext Db
        {
            get
            {
                return dbContext;
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {


                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ManagerBase() {
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
    }
}
