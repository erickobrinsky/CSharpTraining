using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdministrationAPI
{
    public class EmployeeBase : IEmployee
    {
        public int Id { get; set ; }
        public string FirstName { get ; set ; }
        public string LasttName { get ; set ; }
        public virtual decimal Salary { get ; set ; } //. When you declare a member (such as a property, method, or event) as virtual, you are indicating that this member's behavior can be overridden in derived classes.
    }
}
