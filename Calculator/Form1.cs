using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isoperationperformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void number1bt_Click(object sender, EventArgs e)
        {
            if (textBoxresult.Text == "0" || isoperationperformed)
            {
                textBoxresult.Clear();
            }
            Button button =(Button)sender;

            if(button.Text == ".")
            {
                if (!textBoxresult.Text.Contains("."))
                    textBoxresult.Text = textBoxresult.Text + button.Text;
            }else
            textBoxresult.Text = textBoxresult.Text+ button.Text;
            isoperationperformed = false;
            
        }

        private void Cbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void Actionbtn_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operationPerformed = btn.Text;
            resultValue = Double.Parse(textBoxresult.Text);
            Lablepreview.Text = resultValue + " " + operationPerformed;
            isoperationperformed = true;
        }

        private void CEbtn_Click(object sender, EventArgs e)
        {
            textBoxresult.Text = "0";
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            textBoxresult.Text = "0";
            resultValue = 0;
        }

        private void Equalbtn_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBoxresult.Text = (resultValue + Double.Parse(textBoxresult.Text)).ToString();
                    break;
                case "-":
                    textBoxresult.Text = (resultValue - Double.Parse(textBoxresult.Text)).ToString();
                    break;
                case "*":
                    textBoxresult.Text = (resultValue * Double.Parse(textBoxresult.Text)).ToString();
                    break;
                case "/":
                    textBoxresult.Text = (resultValue / Double.Parse(textBoxresult.Text)).ToString();
                    break;

                default:

                    break;




            }
            resultValue = Double.Parse(textBoxresult.Text);
            Lablepreview.Text = "";

        }

    }
}
