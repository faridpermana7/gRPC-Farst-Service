using GrpcFarstCommon;
using GrpcFarstRepo;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcFarstService.Manager.Master
{
    public class EmployeeReader : ManagerAssistant<EmployeeManager, Employee>
    {
        public EmployeeReader(EmployeeManager manager) : base(manager)
        { 
        } 

        public IQueryable<Employee> GetEmployees(int? memberID = null)
        {
            // get query from dbSet
            var query = Manager.Db.Employee.AsQueryable();

            if (memberID.HasValue)
            {
                //query = query.Where(item => item.UnitPackageId == unitPackageId); 
            }

            return query;
        }

        public async Task<Employee> GetEmployeeByIDAsync(Employee entity)
            => await Manager.Db.Employee.FirstOrDefaultAsync(s => s.EmployeeId == entity.EmployeeId);
         
    }
}
