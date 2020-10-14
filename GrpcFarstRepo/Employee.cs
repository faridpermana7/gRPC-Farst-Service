using System;
using System.Collections.Generic;

namespace GrpcFarstRepo
{
    public partial class Employee
    {
        public long EmployeeId { get; set; }
        public string Nik { get; set; }
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Address { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
