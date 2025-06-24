using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form menu = new Form2();
            menu.Show();
            this.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double peso = double.Parse(txbPeso.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                double altura = double.Parse(txbAltura.Text.Replace(',', '.'), CultureInfo.InvariantCulture);

                double imc = peso / (altura * altura);

                string situacao;

                if (imc < 18.5)
                    situacao = "Abaixo do peso";
                else if (imc < 24.9)
                    situacao = "Peso normal";
                else if (imc < 29.9)
                    situacao = "Sobrepeso";
                else if (imc < 34.9)
                    situacao = "Obesidade grau 1";
                else if (imc < 39.9)
                    situacao = "Obesidade grau 2";
                else
                    situacao = "Obesidade grau 3";

                txbIMC.Text = imc.ToString("F2");
                txbSituacao.Text = situacao;
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira valores numéricos válidos para peso e altura.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txbPeso.Clear();
            txbAltura.Clear();
            txbIMC.Clear();
            txbSituacao.Clear();
        }

        private void txbSituacao_TextChanged(object sender, EventArgs e)
        {
            txbSituacao.ReadOnly = true;
        }

        private void txbIMC_TextChanged(object sender, EventArgs e)
        {
            txbIMC.ReadOnly = true;
        }

        private void txbIMC_TextChanged_1(object sender, EventArgs e)
        {
            txbIMC.ReadOnly = true;
        }
    }
}
