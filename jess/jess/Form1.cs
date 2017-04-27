using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J.SAUNBY_B6027837_MINI_KEYBOARD
{
    public partial class user_interface : Form
    {
        int button_clicked = -1;
        ListBox global_Listbox = new ListBox();
        bool clicked = true;

        public user_interface()
        {
            InitializeComponent();
        }

        private void button_mode_Click(object sender, EventArgs e)
        {
            // if statement to change the status between 'multi-press' and 'predictive'
            if (text_status.Text == "Multi-Press")
            {
                text_status.Text = "Predictive";
            }
            else
            {
                text_status.Text = "Multi-Press";
            }


        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (clicked == true)
            {
                global_Listbox.Items.Clear();
                global_Listbox.Items.AddRange(lb_7.Items); //copying the items in the button 7 listbox into the global listbox.

                text_sequence.AppendText("7".ToString());

            }

            letterTimer.Enabled = false;
            button_clicked++;
           
            letterTimer.Enabled = true;
        }

        private void lb_7_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

      

        private void letterTimer_Tick(object sender, EventArgs e)
        {

            letterTimer.Enabled = false;

            wordBuilder.AppendText(global_Listbox.Items[button_clicked].ToString());
            button_clicked = -1;

        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (clicked == true)
            {
                global_Listbox.Items.Clear();
                global_Listbox.Items.AddRange(lb_8.Items); //copying the items in the button 7 listbox into the global listbox.

                text_sequence.AppendText("8".ToString());


            }

            letterTimer.Enabled = false;
            button_clicked++;

            letterTimer.Enabled = true;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (clicked == true)
            {
                global_Listbox.Items.Clear();
                global_Listbox.Items.AddRange(lb_9.Items); //copying the items in the button 7 listbox into the global listbox.

                text_sequence.AppendText("9".ToString());


            }

            letterTimer.Enabled = false;
            button_clicked++;

            letterTimer.Enabled = true;
        }

        private void user_interface_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            notepad_textbox.Text = notepad_textbox.Text + " " + wordBuilder.Text;
            text_sequence.Text = string.Empty; 
            wordBuilder.Text = string.Empty;
          
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            notepad_textbox.AppendText(Environment.NewLine);
        }

    }
}