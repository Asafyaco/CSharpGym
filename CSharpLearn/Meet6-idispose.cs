using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGym
{ 
    class MakeBigRequest : IDisposable
    {
        public void Dispose()
        {
            Release();
            // IDISPOSBLE -כשאני כותב קלאס שצריך לשחרר משאבים אני משתמש ב
            // וזה כבר ישתחרר מעצמו using כשמישהו אחר משתמש בקלאס הוא יצטרך להשתמש ב
        }


        public void Operate()
        {
            // takes huge memory

            // create temp DB
        }

        public void Release()
        {
            // drop temp DB
        }
    }


    internal class Meet6_idispose
    {
        public void Run()
        {
            MakeBigRequest makeBigRequest = new MakeBigRequest();
            makeBigRequest.Operate();

            // release resources

            //makeBigRequest.Release();


            // another option - call to dispose function
            
            //makeBigRequest.Dispose();


            // option - using disposable & Operate function into
            using(MakeBigRequest makeBigRequest1 = new MakeBigRequest())
            {
                makeBigRequest1.Operate();
            }

            //using (var f = System.IO.File.Open)
            //{

            //}
        }
    }
}
