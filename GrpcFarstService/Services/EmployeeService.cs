using Grpc.Core;
using GrpcEmployee;
using GrpcFarstService.Enum;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
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
                var result = Task.FromResult(new EmployeeResponse()
                {

                    StatusCode = EmployeeResponse.Types.Status.Success,
                    Message = "Data found",
                }).Result;

                result.Data.AddRange(new List<EmployeeDTO>()
                {   new EmployeeDTO() {

                        EmployeeID = 1,
                        NIK = "10000000",
                        Name = "Farid Permana",
                        Occupation = "Sofware Enginer",
                        Address = "South Jakarta City, Indonesia"
                    },
                     new EmployeeDTO() {

                        EmployeeID = 2,
                        NIK = "10000001",
                        Name = "Julian Noor",
                        Occupation = "Mobile Enginer",
                        Address = "East Jakarta City, Indonesia"
                    },
                     new EmployeeDTO() {

                        EmployeeID = 3,
                        NIK = "10000003",
                        Name = "Yagami Light",
                        Occupation = "IOS Mobile Developer",
                        Address = "Tokyo, Japan"
                    },
                     new EmployeeDTO() {

                        EmployeeID = 4,
                        NIK = "10000004",
                        Name = "Abu Sofyan",
                        Occupation = "IOS Mobile Developer",
                        Address = "South Borneo, Indonesia"
                    },
                     new EmployeeDTO() {

                        EmployeeID = 5,
                        NIK = "10000005",
                        Name = "Andi Rachman",
                        Occupation = "Android Mobile Developer",
                        Address = "West Borneo, Indonesia"
                    },
                     new EmployeeDTO() {

                        EmployeeID = 6,
                        NIK = "10000006",
                        Name = "Zico Abraham",
                        Occupation = "Mobile Developer",
                        Address = "East Java, Indonesia"
                    }
                });

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
