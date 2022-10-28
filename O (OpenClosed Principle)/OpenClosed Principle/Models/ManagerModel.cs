using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed_Principle.models
{
    public class ManagerModel : IPersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountsProcessor { get; set; } = new ManagerAccounts();
    }
}