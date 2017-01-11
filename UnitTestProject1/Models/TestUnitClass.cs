using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitTestProject1.Models
{
    public class TestUnitClass
    {
        public static int Add_Numbers(int Number1, int Number2)
        {
            return (Number1 + Number2);
        }

        public static int Subtract_Numbers(int Number1, int Number2)
        {
            return (Number1 - Number2 - 1);
        }
    }
}