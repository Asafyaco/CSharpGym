using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGym
{
    internal class Meet8_Generics
    {
        public void Run()
        {
            List<string> list = new List<string>();
            list.Add("123456");

            List<int> list1 = new List<int>();
            list1.Add(1);
            var p = new Point(100, 300);
            string s = func<Point, string>(p, "This is my point");


            // שימוש בלקאס נפרד וקביעת נקודה חדשה
            // Point = struct --> managed 
            //Sample<Point> sample = new Sample<Point>();
            //sample.SetItem(new Point(100, 100));

            //--------------------------------------------------------------
            // Point on struct :
            // כל זמן שהוא על סטראקט הוא לא מנוהל
            myStruct myStruct;
            myStruct.a = 1;
            Point p2 = new Point(); p2.Y = 12;

            // Example of struct : ( unmanaged code )
            //Sample<myStruct> sample = new Sample<myStruct>();

            // public class Sample <T> where T : unmanaged
            //Sample<int> sample = new Sample<int>();
            //Sample<bool> sample = new Sample<bool>();

            //--------------------------------------------------------------

            // managed code
            //Sample<PrintManager> sample = new Sample<PrintManager>();

            //--------------------------------------------------------------

            // public class Sample <T> where T : a
            //Sample<b> sample = new Sample<b>();
            //Sample<c> sample = new Sample<c>();
            //Sample<a> sample = new Sample<a>();

            b sampleB = b.Create();

            //--------------------------------------------------------------

            //public class Sample<T> where T : a, new()
            //Sample<a> sample = new Sample<a>();

            //--------------------------------------------------------------

            // public class Sample<T> where T : IEnumerable<Z>
            // Sample<List<string>, string> sample = new Sample<List<string>, string>();
        }

        public string func <T, Z>(T o, Z y)
            // T -> Template
        {
            string s = o.ToString() + " " + y.ToString();
            return s;
        }

        //--------------------------------------------------------------

        // Examples :
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters

        // שימוש בקלאס אחר
        // public class Sample <T> where T : struct
        //{
        //    public void SetItem(T item)
        //    {

        //    }
        //}        

        //--------------------------------------------------------------

        // managed vv unmanaged
        // Example - JS managed || C++ unmanaged 
        // מנוהל או לא מנוהל

        public class Sample<T> where T : unmanaged
        {
            public void SetItem(T item)
            {

            }
        }

        //--------------------------------------------------------------

        //public class Sample<T> where T : a
        //{
        //    public void SetItem(T item)
        //    {

        //    }
        //}

        //--------------------------------------------------------------

        struct myStruct
        {
            public int a;
            public int b;
            private int myVar;

            public int MyProperty
            {
                get { return myVar; }
                set { myVar = value; }
            }

            void Print()
            {
                Console.WriteLine("1111");
            }
        }

        public class PrintManager<T>
        {

        }

        class a { }
        class b : a { 
            private b()
            {

            }

            public static b Create()
            {
                // Class factory
                return new b();
            }
        }
        class c : a { }
    }
}
