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
        bool clicked = true;
        int button_clicked = -1;

        public user_interface()
        {
            InitializeComponent();
        }

        private void button_mode_Click(object sender, EventArgs e)
        {
            // if statement to change the status between 'multi-press' and 'predictive'
            if (text_status.Text == "Multi-press")
            {
                text_status.Text = "Predictive";
            }
            else
            {
                text_status.Text = "Multi-press";
            }

            
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (clicked == true)
            {
                global_listbox.Items.AddRange(lb_7.Items); //copying the items in the button 7 listbox into the global listbox.
            }

            letterTimer.Enabled = false;
            button_clicked++;
            letterTimer.Enabled = true;
        }

        private void lb_7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void global_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void letterTimer_Tick(object sender, EventArgs e)
        {
            int clicked = -1;
            letterTimer.Enabled = false;

            wordBuilder.AppendText(global_listbox.Items[clicked].ToString());

            

        }
        
    }
}
