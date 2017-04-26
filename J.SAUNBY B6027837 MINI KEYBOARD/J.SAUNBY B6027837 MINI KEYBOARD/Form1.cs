using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs;

namespace J.SAUNBY_B6027837_MINI_KEYBOARD
{
    public partial class user_interface : Form
    {
        public user_interface()
        {
            InitializeComponent();
        }

        private void button_mode_Click(object sender, EventArgs e)
        {
            if (text_status.Text == "Multi-press")
            {
                text_status.Text = "predictive";
            }
            else
            {
                text_status.Text = "Multi-press";
            }
        }
        
    }
}
