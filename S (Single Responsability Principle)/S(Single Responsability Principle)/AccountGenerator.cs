﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Single_Responsability_Principle_
{
    public class AccountGenerator
    {
        public static void CreateAccount (Person user)
        {
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
        }
    }
}
