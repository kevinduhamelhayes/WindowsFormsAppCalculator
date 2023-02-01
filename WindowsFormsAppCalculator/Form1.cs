using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCalculator
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;
        private double resultado;
        private int operacion;
        private object textBox1Display;

        public Form1()
        {
            InitializeComponent();
        }
        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //numero 0
            tb1.Text = tb1.Text + "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //numero 1
            tb1.Text = tb1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //numero 2
            tb1.Text = tb1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //numero 3
            tb1.Text = tb1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //numero 4
            tb1.Text = tb1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //numero 5
            tb1.Text = tb1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //numero 6
            tb1.Text = tb1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //numero 7
            tb1.Text = tb1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //numero 8
            tb1.Text = tb1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //numero 9
            tb1.Text = tb1.Text + "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //resultado

            valor2 = Convert.ToDouble(tb1.Text);
            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    tb1.Text = resultado.ToString();
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    tb1.Text = resultado.ToString();
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    tb1.Text = resultado.ToString();
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    tb1.Text = resultado.ToString();
                    break;

            }

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //suma
            operacion = 1;
            valor1 = Convert.ToDouble(tb1.Text);
            tb1.Text = "";
            
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //resta
            operacion = 2;
            valor1 = Convert.ToDouble(tb1.Text);
            tb1.Text = "";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            //multiplicacion
            operacion = 3;
            valor1 = Convert.ToDouble(tb1.Text);
            tb1.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            //division
            operacion = 4;
            valor1 = Convert.ToDouble(tb1.Text);
            tb1.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear
            tb1.Text = "";
        }

        private void btncoma_Click(object sender, EventArgs e)
        {
            //.
            tb1.Text = tb1.Text + ".";
        }
    }
}
