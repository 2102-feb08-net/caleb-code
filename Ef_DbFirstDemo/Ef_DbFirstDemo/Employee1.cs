using System;
using System.Collections.Generic;

#nullable disable

namespace Ef_DbFirstDemo
{
    public partial class Employee1
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }
        public int DeptId { get; set; }
    }
}
