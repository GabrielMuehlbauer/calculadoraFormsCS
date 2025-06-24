using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalculadoraPrincipal_Click(object sender, EventArgs e)
        {
            Form calculadora = new Form1();
            calculadora.Show();
            this.Visible = false;
        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            Form imc = new Form3();
            imc.Show();
            this.Visible = false;
        }

        private void btnRegraDeTres_Click(object sender, EventArgs e)
        {
            Form regraDeTres = new Form4();
            regraDeTres.Show();
            this.Visible = false;
        }

        private void btnTemperatura_Click(object sender, EventArgs e)
        {
            Form convTemp = new Form5();
            convTemp.Show();
            this.Visible = false;
        }
    }
}
