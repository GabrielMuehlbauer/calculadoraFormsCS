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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura e converte os valores
                double valor1 = double.Parse(txbValor1.Text);
                double valor2 = double.Parse(txbValor2.Text);
                double valor3 = double.Parse(txbValor3.Text);

                // Regra de três simples: (valor2 * valor3) / valor1
                double resultado = (valor2 * valor3) / valor1;

                // Mostra o resultado formatado
                txbValorX.Text = resultado.ToString("0.##");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, preencha todos os campos com números válidos.", "Erro de entrada");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("O primeiro valor não pode ser zero.", "Erro de cálculo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txbValor1.Clear();
            txbValor2.Clear();
            txbValor3.Clear();
            txbValorX.Clear();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form menu = new Form2();
            menu.Show();
            this.Visible = false;
        }
    }
}
