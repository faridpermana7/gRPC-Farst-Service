using GrpcFarstService.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcFarstService.Models
{
    public class ProtoResponse
    {
        public EnumStatus StatusCode { get; set; }
        public string Message { get; set; } 
    }
}
