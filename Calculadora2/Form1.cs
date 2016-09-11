using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        String valor = "";
        double [] valores = new double[100];
        int indice = 0;
        String operacion="";
        double [] valores2 = new double[100];

        
        public Form1()
        {
            InitializeComponent();
            
            double a = 1;
            for (int i = 0; i < valores2.Length; i++)
            {
                valores2[i] = a;
                

            }
            
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            valor += "9";
            this.textBox1.Text = valor;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor += "1";
            this.textBox1.Text = valor;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor += "2";
            this.textBox1.Text = valor;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor += "3";
            this.textBox1.Text = valor;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            valor += "4";
            this.textBox1.Text = valor;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            valor += "5";
            this.textBox1.Text = valor;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            valor += "6";
            this.textBox1.Text = valor;


        }

        private void button9_Click(object sender, EventArgs e)
        {
            valor += "7";
            this.textBox1.Text = valor;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            valor += "8";
            this.textBox1.Text = valor;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            valor += "0";
            this.textBox1.Text = valor;


        }

        private void button11_Click(object sender, EventArgs e)
        {
            double v = Convert.ToDouble(valor);
            this.textBox1.Text = "";
            valor = "";
            valores[indice] = v;
            indice++;
            operacion = "suma";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            double res;
            if (operacion == "suma") 
            {
                res = 0;
                double v = Convert.ToDouble(valor);
                valores[indice] = v;
                for (int i = 0; i < valores.Length; i++)
                {
                    res += valores[i];
                }
                valor = res.ToString();
                this.textBox1.Text = res.ToString();  // mostrar resultado
                indice = 0;
                res = 0;
                for (int j = 0; j < valores.Length; j++)
                {
                    valores[j] = 0;
                }
            }
            if (this.operacion == "resta")
            {
                res = 0;
                double v = Convert.ToDouble(valor);
                valores[indice] = v;
                for (int i = 0; i < valores.Length; i++)
                {
                    if (i == 0)
                    {
                        res = valores[i];
                    }
                    else
                    {
                        res = res - valores[i];
                    }
                }
                valor = res.ToString();
                this.textBox1.Text = res.ToString();
                indice = 0;
                res = 0;
                for (int j = 0; j < valores.Length; j++)
                {
                    valores[j] = 0;
                }
            }
            if (this.operacion == "mul")
            {
                res = 1;
                double v = Convert.ToDouble(valor);
                valores2[indice] = v;
                for (int i = 0; i < valores2.Length; i++)
                {
                    
                    
                        res =res* valores2[i];
                    
                }
                valor = res.ToString();
                this.textBox1.Text = res.ToString();
                indice = 0;
                res = 1;
                for (int j = 0; j < valores2.Length; j++)
                {
                    valores2[j] = 1;
                }

            }
            if (this.operacion == "div")
            {
                res = 1;
                double v = Convert.ToDouble(valor);
                valores2[indice] = v;
                for (int i = 0; i < valores2.Length; i++)
                {

                    if (i == 0)
                    {
                        res = valores2[i];
                    }
                    else
                    {
                        res = res / valores2[i];
                    }
                }
                valor = res.ToString();
                this.textBox1.Text = res.ToString();
                indice = 0;
                res = 1;
                for (int j = 0; j < valores2.Length; j++)
                {
                    valores2[j] = 1;
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
             valor = "";
             indice = 0;
             operacion = "";
             this.textBox1.Text = "";
             
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double v = Convert.ToDouble(valor);
            this.textBox1.Text = "";
            valor = "";
            valores[indice] = v;
            indice++;
            operacion = "resta";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double v = Convert.ToDouble(valor);
            this.textBox1.Text = "";
            valor = "";
            valores2[indice] = v;
            indice++;
            operacion = "mul";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            double v = Convert.ToDouble(valor);
            this.textBox1.Text = "";
            valor = "";
            valores2[indice] = v;
            indice++;
            operacion = "div";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double v = Convert.ToDouble(valor);
            this.textBox1.Text = Math.Pow(v,2).ToString();
            valor = this.textBox1.Text;
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double v = Convert.ToDouble(valor);
            this.textBox1.Text = Math.Sqrt(v).ToString();
            valor = this.textBox1.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            valor += ".";
            this.textBox1.Text = valor;
        }

       
    }
}
