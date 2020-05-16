using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BismillahCalculatorFitrah
{
    public partial class Form1 : Form
    {
        double val = 0;
        String text = "";
        bool oper_press = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            tampilan.Text = output.Text + text;
            if (oper_press == true)
            {
                output.Clear();
            }
            oper_press = false;
            Button button = (Button)sender;
            output.Text = output.Text + button.Text;
            if ((output.Text == "0")||(oper_press))
            {
                output.Clear();
            }

            oper_press = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            output.Text = "0";
        }

        private void op_pres(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            text = button.Text;
            val = Double.Parse(output.Text);
            oper_press = true;
            /* label1.Text = val.ToString() + "＋";
            label1.Text = val.ToString() + "－";
            label1.Text = val.ToString() + "×";
            label1.Text = val.ToString() + "÷";
            label1.Text = val.ToString() + ""; */
        }

        private void op_res(object sender, EventArgs e)
        {
            switch(text)
            {
                case "＋":
                    output.Text = (val + Double.Parse(output.Text)).ToString();
                    break;
                case "－":
                    output.Text = (val - Double.Parse(output.Text)).ToString();
                    break;
                case "×":
                    output.Text = (val * Double.Parse(output.Text)).ToString();
                    break;
                case "÷":
                    output.Text = (val / Double.Parse(output.Text)).ToString();
                    break;
                default:
                    break;
            }
            tampilan.Text = "";
            text = "";
            oper_press = false;
        }

        private void c_pres(object sender, EventArgs e)
        {
            output.Clear();
            val = 0;
        }

        public void enable() //methode to enable calculator
        {
            output.Enabled = true;
            button19.Hide();
            button20.Show();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            enable(); //call enable
        }

        public void disable() //methode to disable Calculator
        {
            output.Enabled = false;
            button19.Show();
            button20.Hide();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            disable(); //call disable
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e) //PLUSMINUS
        {
                if (output.Text.Contains("-"))

                    output.Text = output.Text.Remove(0, 1);
                else
                    output.Text = "-" + output.Text;

            
        }

        private void button22_Click(object sender, EventArgs e) //backspace
        {
           output.Text = output.Text.Remove(output.Text.Length - 1, 1);
        }

        private void sqrt(object sender, EventArgs e)
        {
            output.Text = (Math.Sqrt(Double.Parse(output.Text))).ToString();
        }

        private void persen_click(object sender, EventArgs e)
        {
            output.Text = (Double.Parse(output.Text) * 0.01).ToString();
        }

        private void reciprocal(object sender, EventArgs e)
        {
            output.Text = (1 / Double.Parse(output.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tampilan_Click(object sender, EventArgs e)
        {

        }
    }
}
