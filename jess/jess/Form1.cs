﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//removed MyDialogs.cs
namespace J.SAUNBY_B6027837_MINI_KEYBOARD
{
    public partial class user_interface : Form
    {
        //setting the global variables for the user interface to work
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
            //if statement to copy the corresponding buttons into the word builder box
            if (clicked == true)
            {
                //clears the global listbox before proceeding
                global_Listbox.Items.Clear();
                //adds what has been added into the box for the corresponding button number
                global_Listbox.Items.AddRange(lb_7.Items); 

                
                text_sequence.AppendText("7".ToString());

            }

            //disables the timer
            letterTimer.Enabled = false;
            button_clicked++;
           
            //enables the timer when button is clicked
            letterTimer.Enabled = true;
        }

        private void lb_7_SelectedIndexChanged(object sender, EventArgs e)
        {
        }     

        private void letterTimer_Tick(object sender, EventArgs e)
        {

            //disables the timer
            letterTimer.Enabled = false;

            //adds the text in the word builder when clicked and disappears from the rich text box
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
            //if statement to make letters appear from the button to the word builder, when particular button is clicked 
            if (clicked == true)
            {
                global_Listbox.Items.Clear();
                global_Listbox.Items.AddRange(lb_9.Items); 

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
            //shows what has been 'typed' in the first box and deletes from word builder box
            notepad_textbox.Text = notepad_textbox.Text + " " + wordBuilder.Text;
            text_sequence.Text = string.Empty; 
            wordBuilder.Text = string.Empty;
          
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            notepad_textbox.AppendText(Environment.NewLine);
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            //if statement to copy the corresponding buttons into the word builder box
            if (clicked == true)
            {
                //clears the global listbox before proceeding
                global_Listbox.Items.Clear();
                //adds what has been added into the box for the corresponding button number
                global_Listbox.Items.AddRange(lb_4.Items);

                //
                text_sequence.AppendText("4".ToString());

            }

            //disables the timer
            letterTimer.Enabled = false;
            button_clicked++;

            //enables the timer when button is clicked
            letterTimer.Enabled = true;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            //if statement to copy the corresponding buttons into the word builder box
            if (clicked == true)
            {
                //clears the global listbox before proceeding
                global_Listbox.Items.Clear();
                //adds what has been added into the box for the corresponding button number
                global_Listbox.Items.AddRange(lb_5.Items);

                //
                text_sequence.AppendText("5".ToString());

            }

            //disables the timer
            letterTimer.Enabled = false;
            button_clicked++;

            //enables the timer when button is clicked
            letterTimer.Enabled = true;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            //if statement to copy the corresponding buttons into the word builder box
            if (clicked == true)
            {
                //clears the global listbox before proceeding
                global_Listbox.Items.Clear();
                //adds what has been added into the box for the corresponding button number
                global_Listbox.Items.AddRange(lb_6.Items);

                //
                text_sequence.AppendText("6".ToString());

            }

            //disables the timer
            letterTimer.Enabled = false;
            button_clicked++;

            //enables the timer when button is clicked
            letterTimer.Enabled = true;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            //if statement to copy the corresponding buttons into the word builder box
            if (clicked == true)
            {
                //clears the global listbox before proceeding
                global_Listbox.Items.Clear();
                //adds what has been added into the box for the corresponding button number
                global_Listbox.Items.AddRange(lb_1.Items);

                //
                text_sequence.AppendText("1".ToString());

            }

            //disables the timer
            letterTimer.Enabled = false;
            button_clicked++;

            //enables the timer when button is clicked
            letterTimer.Enabled = true;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            //if statement to copy the corresponding buttons into the word builder box
            if (clicked == true)
            {
                //clears the global listbox before proceeding
                global_Listbox.Items.Clear();
                //adds what has been added into the box for the corresponding button number
                global_Listbox.Items.AddRange(lb_2.Items);

                //
                text_sequence.AppendText("2".ToString());

            }

            //disables the timer
            letterTimer.Enabled = false;
            button_clicked++;

            //enables the timer when button is clicked
            letterTimer.Enabled = true;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            //if statement to copy the corresponding buttons into the word builder box
            if (clicked == true)
            {
                //clears the global listbox before proceeding
                global_Listbox.Items.Clear();
                //adds what has been added into the box for the corresponding button number
                global_Listbox.Items.AddRange(lb_3.Items);

                //
                text_sequence.AppendText("3".ToString());

            }

            //disables the timer
            letterTimer.Enabled = false;
            button_clicked++;

            //enables the timer when button is clicked
            letterTimer.Enabled = true;
        }

        private void button_hash_Click(object sender, EventArgs e)
        {
            //if statement to copy the corresponding buttons into the word builder box
            if (clicked == true)
            {
                //clears the global listbox before proceeding
                global_Listbox.Items.Clear();
                //adds what has been added into the box for the corresponding button number
                global_Listbox.Items.AddRange(lb_.Items);

                //
                text_sequence.AppendText("hash".ToString());

            }

            //disables the timer
            letterTimer.Enabled = false;
            button_clicked++;

            //enables the timer when button is clicked
            letterTimer.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

    }//if statement to copy the corresponding buttons into the word builder box
            if (clicked == true)
            {
                //clears the global listbox before proceeding
                global_Listbox.Items.Clear();
                //adds what has been added into the box for the corresponding button number
                global_Listbox.Items.AddRange(lb_5.Items);

                //
                text_sequence.AppendText("5".ToString());

            }

            //disables the timer
            letterTimer.Enabled = false;
            button_clicked++;

            //enables the timer when button is clicked
            letterTimer.Enabled = true;
}