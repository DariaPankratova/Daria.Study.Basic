using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daria.Study.Basic.OOP
{
    //public internal(по умолчанию) private
    class Program
    {
        /*
         * private (внутри класса) 
         * protected (внутри класса и его потомков) 
         * internal (внутри проекта (в сборке)) 
         * public (за пределами проекта)
         */
        private static int _intField = 5;
        protected float FloatField;
        private string _stringField;

        public Program(float f)
        {
            FloatField = f;    
        } 

        public Program(float f, string s)
            : this(f)
        {
            _stringField = s;
        }

        static Program()
        {

        }

        ~Program()
        {
            TrimmedString = "";
        }

        /*public string get_TrimmedString()
        {
            return _stringField.Trim();
        }*/

        /*public void set_TrimmedString(string value)
        {
            _stringField = value; 
        }*/

        public string TrimmedString
        {
            get
            {
                return _stringField.Trim();
            }
            private set
            {
                _stringField = value;
            }
        }

        public string AnotherString { get; private set; } = "abc";

        /*
         * private string _anotherString = "abc";
         * 
         * public string get_AnotherString()
         * {
         *    return _anotherString;
         * }
         * 
         * public void set_AnotherString(string value)
         * {
         *    _anotherString = value; 
         * }
         * */

        static void Main(string[] args)
        {
        }

        public float Operation()
        {
            int x = 2;
            var a = 2;
            return AddOperation(a, ref x, out int y, c: 4);
        }
        //ref - передача значения по ссылке
        public float AddOperation(int a, ref int x, out int y, int b = 5, int c = 6)
        {
            a = 7;
            x = 3;
            y = 5;
            return FloatField + a + b + c;
        }

        public float AddOperation(int a)
        {
            return 0;
        }

        public float AddOperation(string a)
        {
            var floatValue = float.Parse(a);
            return FloatField + floatValue;
        }

        public static float StaticOperation(Program p)  //сигнатура метода
        {
            return p.FloatField;
        }
    }
}
