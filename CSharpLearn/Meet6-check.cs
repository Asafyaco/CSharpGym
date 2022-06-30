using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGym
{
    internal class Meet6_check
    {
        public void Run()
        {
            int c = 0;

            try
                // עטיפה כדי שלא תהיה הודעת שגיאה על תעופה ויגיע ל- 0
                // OverflowException
            {
                checked
                    //  יצירת בלוק שבו תעשה בדיקה -> תייצר את הודעת שגיאת תעופה במידה ותהיה חריגה
                    // עולה קצת משאבים - עוזר כשיש הרבה נתונים
                    // OverflowException
                {
                    byte a = 1;
                    a = byte.MaxValue - 2;
                    a++;
                    a++;

                    unchecked
                        //  להחריג קטע קוד שלא יבדוק אותו מתוך chekced 
                        // מחריג את זריקת השגיאה
                        {
                            a++;
                        }

                    a = byte.MaxValue;
                    a++;
                }
            }
            catch (OverflowException ex)
            {

            }


            int b = 2;
            b = int.MaxValue - 1;
            b++;
            b++;
            b++;
            b++;
            b++;


            for (long i = 0; i < long.MaxValue; i++)
            {
                c++;
                b++;
            }
        }
    }
}
