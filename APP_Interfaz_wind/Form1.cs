using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Interfaz_wind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            double res;
            num = int.Parse(this.numero.Text);

            res = APP_ProgramacionCapas.Factorial.fact(num);
            this.resu.Text = res.ToString();
        }

        private void sa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por visitar... :3");
            this.Close();
        }
    }
}
