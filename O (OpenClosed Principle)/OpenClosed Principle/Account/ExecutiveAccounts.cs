using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed_Principle
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IPersonModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{ person.LastName }@acmecorp.com";

            output.isExecutive = true;
            output.isManager = true;

            return output;
        }
    }
}
