using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_Segregation_Principle.Interfaces;

namespace Interface_Segregation_Principle.Dvd
{
    internal interface IBorrowableDvd : IDvd, IBorrowable
    {
    }
}
