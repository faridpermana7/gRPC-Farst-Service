using GrpcFarstService.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcFarstService.Models
{
    public class EmployeeDTO
    {
        public long EmployeeID { get; set; }
        public string NIK { get; set; }
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Address { get; set; }
    }

    public class EmployeeRequest : ProtoRequest
    { 
        public long? EmployeeID { get; set; }
    }

    public class EmployeeResponse : ProtoResponse
    { 
        public EmployeeDTO Data { get; set; }
    }
}
