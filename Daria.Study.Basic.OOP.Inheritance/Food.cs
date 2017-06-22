using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daria.Study.Basic.OOP.Inheritance
{
    public class Food
    {
        public string Name { get; set; }
        public FoodSize Size { get; set; }
    }
    public enum FoodSize
    {
        Tiny,
        Medium,
        Large
    }
}
