using Grpc.Core;
using GrpcEmployee;
using GrpcFarstService.Enum;
using Microsoft.Extensions.Logging;
using System;
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

        public override Task<EmployeeResponse> GetEmployeeByEmpID(EmployeeRequest request, ServerCallContext context)
        {
            var response = new EmployeeResponse { StatusCode = EmployeeResponse.Types.Status.Notfound, Message = EnumStatus.NotFound.ToString() };

            if (request.EmployeeID > 0)
            {
                return Task.FromResult(new EmployeeResponse()
                {

                    StatusCode = EmployeeResponse.Types.Status.Success,
                    Message = "Data found",
                    Data = new EmployeeDTO
                    { 
                        EmployeeID = 1,
                        NIK = "10000000",
                        Name = "Farid Permana",
                        Occupation = "Sofware Enginer",
                        Address = "South Jakarta City, Indonesia"
                    }
                });

            }

            return Task.FromResult(response);
        }

    }
}
