using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcFarstService.Enum
{
    public enum EnumStatus
    {
        Success = 200,
        Forbiden = 400,
        NotFound = 404,
        InternalServerError = 500 
    }
}
