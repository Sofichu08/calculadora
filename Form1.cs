using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double numero1 = 0;
        double numero2 = 0;
        double resultado = 0;
        string operacion;

        public Form1()
        {
            InitializeComponent();
          
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            pantalla.Text = "0";
           // int acumulador = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //pantalla.Text = numero1.ToString();
            //label1.Text = "";

            numero2 = double.Parse(pantalla.Text);
            label1.Text =numero1.ToString()+operacion+ numero2.ToString() + "=";

            switch(operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    label1.Text += resultado.ToString();
                    pantalla.Text = resultado.ToString();

                    break;
                case "-":
                    resultado = numero1 - numero2;
                    label1.Text += resultado.ToString();
                    pantalla.Text = resultado.ToString();
                    break;
                case "X":
                    resultado = numero1 * numero2;
                    label1.Text += resultado.ToString();
                    pantalla.Text = resultado.ToString();
                    break;
                case "/":
                    if(numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        label1.Text += resultado.ToString();
                        pantalla.Text = resultado.ToString();
                    }
                    else
                    {
                        label1.Text = "Error matemático";
                    }

                        break;
                default:
                    label1.Text = pantalla.Text;
                    break;

            }
            numero1= 0;
            numero2 = 0;
            resultado = 0;
            operacion = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uno_Click(object sender, EventArgs e)
        {
            pantalla.Text += "1";

        }

        private void dos_Click(object sender, EventArgs e)
        {
            pantalla.Text += "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            pantalla.Text += "3";
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            pantalla.Text += "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            pantalla.Text += "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            pantalla.Text += "6";
        }

        private void siete_Click(object sender, EventArgs e)
        {
            pantalla.Text += "7";
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            pantalla.Text += "8";
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            pantalla.Text += "9";
        }

        private void cero_Click(object sender, EventArgs e)
        {
            pantalla.Text += "0";
        }

        private void divi_Click(object sender, EventArgs e)
        {
            operacion = "/";
            numero1 = double.Parse(pantalla.Text);
            pantalla.Text = "0";
            label1.Text = numero1.ToString() + operacion;
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if(pantalla.Text.Length > 1)
            {
                pantalla.Text = pantalla.Text.Remove(pantalla.Text.Length - 1);
            }
          
        }

        private void multi_Click(object sender, EventArgs e)
        {
            operacion= "X";
            numero1 = double.Parse(pantalla.Text);
            pantalla.Text = "0";
            label1.Text = numero1.ToString() + operacion;
        }

        private void menos_Click(object sender, EventArgs e)
        { 
            operacion = "-";
            numero1= double.Parse(pantalla.Text);
            pantalla.Text = "0";
            label1.Text = numero1.ToString() + operacion;
        }

        private void mas_Click(object sender, EventArgs e)
        {
            operacion= "+";
            numero1 = double.Parse(pantalla.Text);
            pantalla.Text = "0";
            label1.Text = numero1.ToString() + operacion;
        }
    }
}
