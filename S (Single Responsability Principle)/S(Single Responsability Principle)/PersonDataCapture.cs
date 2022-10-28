using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Single_Responsability_Principle_
{
    internal class PersonDataCapture
    {
        public static Person Capture()
        {
            Person user = new Person();

            Console.Write("What's your first name ?");
            user.FirstName = Console.ReadLine();

            Console.Write("What's your last name ?");
            user.LastName = Console.ReadLine();

            return user;
        }
    }
}
