using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummerBreeze
{
	public class SomeObject
	{
        private int number;
        private string string1 = "I am";
        public int method1()
        {
            Random random = new Random();
            number = random.Next(1, 10);
            return number;
        }
        public string method2()
        {
            return string1;
        }
	}
}