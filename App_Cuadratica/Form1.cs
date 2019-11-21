using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Cuadratica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c,x1,x2;
            a = Double.Parse(this.a.Text);
            b = Double.Parse(this.b.Text);
            c = Double.Parse(this.c.Text);
            string msg1;
            string msg2;
            x1 = APP_ProgramacionCapas.Ecuacion.X1(a,b,c,out msg1);
            x2 = APP_ProgramacionCapas.Ecuacion.X2(a,b,c,out msg2);
            //CONDICION PARA MENSAJE DEL VALOR X1
            if (msg1.Length == 0)
            {
                this.x1.Text = x1.ToString("0.00");
            }
            else
            {
                this.x1.Text = msg1;
            }
            //CONDICION PARA EL MENSAJE DEL VALOR X2
            if (msg2.Length == 0)
                this.x2.Text = x2.ToString("0.00");
            else
                this.x2.Text = msg2;
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            this.a.Text = "";
            this.b.Text = "";
            this.c.Text = "";
            this.x1.Text = "";
            this.x2.Text = "";
        }

        private void dispos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
