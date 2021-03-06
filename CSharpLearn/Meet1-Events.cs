using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGym
{
    internal class Meet1_Events
    {
        public delegate void Timeout_func(int time, int id);
        public event Timeout_func TimeOut_handler;
        public void Run()
        {
            // broadcast events to all listeners 
            if(TimeOut_handler!=null)
                TimeOut_handler(1200,9876);    // Time 1.2sec
        }
    }

    public class Operate
    {
        Meet1_Events meet1_Events = new Meet1_Events();
        DB db = new DB();
        UI ui = new UI();
        public void Init()
        {
            // register to broadcast list 
            meet1_Events.TimeOut_handler += db.UpdateDBAfterTimeout;
            meet1_Events.TimeOut_handler += ui.UpdateUIAfterTimeout;

            meet1_Events.Run();

            // unregister to broadcast list 
            meet1_Events.TimeOut_handler -= ui.UpdateUIAfterTimeout;
            meet1_Events.Run();
        }
    }

    public class DB
    {
        public void UpdateDBAfterTimeout(int time, int id)
        {

        }
    }

    public class UI
    {
        public void UpdateUIAfterTimeout(int time, int id)
        {

        }
    }
}
