using Grpc.Core;
using GrpcEmployee;
using GrpcFarstCommon;
using GrpcFarstService.Enum;
using GrpcFarstService.Manager.Master;
using GrpcFarstService.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcFarstService.Services
{
    public class EmployeeService : EmployeeProvider.EmployeeProviderBase
    {

        private readonly ILogger<EmployeeService> _logger;
        public EmployeeService(ILogger<EmployeeService> logger)
        {
            _logger = logger;
        }

        public override Task<EmployeeResponse> GetEmployee(EmployeeRequest request, ServerCallContext context)
        {
            var response = new EmployeeResponse { StatusCode = EmployeeResponse.Types.Status.Notfound, Message = EnumStatus.NotFound.ToString() };

            if (request.MemberID > 0)
            {
                var result = new EmployeeResponse()
                { 
                    StatusCode = EmployeeResponse.Types.Status.Success,
                    Message = "Data found",
                };

                var manager = new EmployeeManager();

                var query = (from emp in manager.Reader.Value.GetEmployees()
                             select new EmployeeDTO 
                             { 
                                 EmployeeID = emp.EmployeeId,
                                 NIK = emp.Nik,
                                 Name = emp.Name,
                                 Address = emp.Address,
                                 Occupation = emp.Occupation
                             }).AsQueryable();

                result.Data.AddRange(query.ToArray());  
                return Task.FromResult(result);

            }

            return Task.FromResult(response);
        }

        public override Task<EmployeeResponse> GetEmployeeByEmpID(EmployeeRequest request, ServerCallContext context)
        {
            var response = new EmployeeResponse { StatusCode = EmployeeResponse.Types.Status.Notfound, Message = EnumStatus.NotFound.ToString() };

            if (request.EmployeeID > 0)
            {
                var result = Task.FromResult(new EmployeeResponse()
                {

                    StatusCode = EmployeeResponse.Types.Status.Success,
                    Message = "Data found",
                }).Result;

                result.Data.Add(new EmployeeDTO
                {
                    EmployeeID = 1,
                    NIK = "10000000",
                    Name = "Farid Permana",
                    Occupation = "Sofware Enginer",
                    Address = "South Jakarta City, Indonesia"
                });
            }

            return Task.FromResult(response);
        }

    }
}
