using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Interfaces
{
    public interface IBorrowable
    {
        int CheckOutDurationInDays { get; set; }
        string? Borrower { get; set; }
        DateTime BorrowDate { get; set; }

        void CheckIn();
        void CheckOut(string borrower);
        DateTime GetDueDate();
    }
}
