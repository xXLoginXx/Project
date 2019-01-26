using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крестики_Нолики
{
    public partial class Form1 : Form
    {
        bool xTurn = true;
        bool NoWin = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button senderB = (Button)sender;
            if (xTurn)
            {
                senderB.Text = "X";
            }
            else
            {
                senderB.Text = "O";
            }
            xTurn = !xTurn;
            senderB.Enabled = false;
            
            CheckWin(senderB);
           


        }
        void CheckWin(Button pressedButton)

        {
            
            if(button1.Text==button2.Text&&button2.Text==button3.Text && button1.Enabled == false)
            {
                MessageBox.Show("Winner Chicken Diner: " + pressedButton.Text);
                NoWin = true;
              
                Reset();
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button5.Enabled == false)
            {
                MessageBox.Show("Winner Chicken Diner: " + pressedButton.Text);
                 NoWin = true;
                
                Reset();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button8.Enabled == false)
            {
                MessageBox.Show("Winner Chicken Diner: " + pressedButton.Text);
                NoWin = true;
                
                Reset();
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button4.Enabled == false)
            {
                MessageBox.Show("Winner Chicken Diner: " + pressedButton.Text);
                 NoWin = true;
               
                Reset();
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Enabled == false)
            {
                MessageBox.Show("Winner Chicken Diner: " + pressedButton.Text);
                NoWin = true;
                
                Reset();
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Enabled == false)
            {
                MessageBox.Show("Winner Chicken Diner: " + pressedButton.Text);
                NoWin = true;
                
                Reset();
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button5.Enabled == false)
            {
                MessageBox.Show("Winner Chicken Diner: " + pressedButton.Text);
                NoWin = true;
                
                Reset();
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button5.Enabled == false)
            {
                MessageBox.Show("Winner Chicken Diner: " + pressedButton.Text);
                NoWin = true;
                
                Reset();
            }

            if (NoWin == false && button1.Enabled == false && button2.Enabled == false && button3.Enabled == false &&button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("No Winners :(");
               
                Reset();
            }
        }

        

        

        private void aboutAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        { 
            MessageBox.Show("My First Game!");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Reset();
        }
        void Reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            xTurn = true;

        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
                xTurn = true;
            Reset();

            
        }
        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
                xTurn = false;
            Reset();

            
        }
    }
}
