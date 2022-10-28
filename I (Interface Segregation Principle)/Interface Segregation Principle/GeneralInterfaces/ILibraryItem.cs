using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Interfaces
{
    public interface ILibraryItem
    {
        public string? LibraryId { get; set; }
        public string? Title { get; set; }
    }
}
