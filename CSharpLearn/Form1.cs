using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpGym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void delegate_button_Click(object sender, EventArgs e)
        {
            Meet1_delegate meet1_Delegate = new Meet1_delegate();
            meet1_Delegate.Run();
        }

        private void events_Click(object sender, EventArgs e)
        {
            Meet1_Events meet1_Events = new Meet1_Events();

            Operate operate = new Operate();
            operate.Init();
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            Meet6_check meet6_Check = new Meet6_check();
            meet6_Check.Run();
        }

        private void is_as_button_Click(object sender, EventArgs e)
        {
            Meet6_is_as meet6_Is_As = new Meet6_is_as();
            meet6_Is_As.Run();
        }

        private void idispose_button_Click(object sender, EventArgs e)
        {
            Meet6_idispose meet6_Idispose = new Meet6_idispose();
            meet6_Idispose.Run();
        }

        private void GetType_button_Click(object sender, EventArgs e)
        {
            Meet7_type meet7_Type = new Meet7_type();
            meet7_Type.Run1();
        }
    }
}
