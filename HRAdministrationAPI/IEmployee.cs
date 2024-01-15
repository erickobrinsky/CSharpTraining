using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdministrationAPI
{
    public interface IEmployee //All members of an interface are implicitly public, so don't need to declare public or private
                        // the purpose of an interface is to provide a public contract that other types can implement
    {
         int Id { get; set; }

         string FirstName { get; set; }

         string LasttName { get; set; }

         decimal Salary { get; set; }
    }
}
