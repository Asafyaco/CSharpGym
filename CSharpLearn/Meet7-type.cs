using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGym
{
    class a { }
    class b : a { 
        public int MyProperty { get; set; }
        public string MyProperty2 { get; set; }
    }

    internal class Meet7_type
    {
        // reflection
        // לחקור את המשתנים ולקבל עליה מידע בזמן אמתם
        // היכולת לעבוד בזמן דינאמי עם משתנים, לחקור את הטיפוס שלהם ואפילו להפעיל פונקציות מבלי להעביר קומפליצה
        
        public void Run1()
        {
            a a = new a();
            b b = new b();
            b.MyProperty = 1;
            b.MyProperty2 = "2";
            object o = b;

            GetObject(b);
            GetObject(o);
            GetObject(1);
            GetObject("2");
        }

        public void GetObject(object o)
        {
            Type t = o.GetType();
        }


        FileStream fs;
        public void Run()
        {
            try
            {
                fs = System.IO.File.OpenRead("");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                fs.Close();
            }


            // iDispose

            //using (FileStream fs = System.IO.File.OpenRead(""))
            //{

            //}

        }

        public Meet7_type()
        {
            // constuctor
        }  
        
        ~Meet7_type()
        {
            // descructor
            // finalizer

            fs.Close();
        }
    }
}
