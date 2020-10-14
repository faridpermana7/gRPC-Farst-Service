using GrpcFarstCommon;
using GrpcFarstRepo;
using System;

namespace GrpcFarstService.Manager.Master
{
    public class EmployeeManager : ManagerBase<GrpcFarstContext>
    {
        public EmployeeManager() : base()
        {
            PrepareAssistant(base.Db);
        }

        public EmployeeManager(GrpcFarstContext dbContext) : base(dbContext)
        {
            PrepareAssistant(Db);
        }

        public Lazy<EmployeeReader> Reader { get; internal set; }
        protected sealed override void PrepareAssistant(GrpcFarstContext dbContext)
        {
            Reader = new Lazy<EmployeeReader>(
                () => new EmployeeReader(this), true);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Reader = null;
            }
            // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
            // TODO: set large fields to null.

            base.Dispose(disposing);
        }
    }
}
