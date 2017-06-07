using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daria.Study.Basic.Start
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFirstVar = new string[5];
            myFirstVar[0] = "3";
            Array.Sort(myFirstVar);
            var name = "Dasha";
            var age = 23;
            string.Format("I am {0} and my age is {1}.", name, age);
            var myString = $"I am {name} and my age is {age}.";
            if (myFirstVar[0] == "3")
            {
                myFirstVar[1] = myFirstVar[0] + 1;
            }
            else myFirstVar[3] = myFirstVar[0].Length.ToString();

            var b = myFirstVar[0] == "3" ? 1 : 2;

            switch (b)
            {
                case 0:
                    {
                        myFirstVar[2] = "test";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            var i = 0;

            var myList = new List<int>(10);
            myList.Add("test");
            myList.Count();
            myList.Sort();

            var dict = new Dictionary<string, string>();
            var value = dict[""];
        }
    }
}
