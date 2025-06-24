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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(tbxTemp1.Text);
            string origem = cb1.SelectedItem.ToString();
            string destino = cb2.SelectedItem.ToString();
            double resultado = ConverterTemperatura(valor, origem, destino);
            tbxTemp2.Text = resultado.ToString("F2");
        }

        private double ConverterTemperatura(double valor, string origem, string destino)
        {
            if (origem == destino) return valor;

            // Celsius para...
            if (origem == "Celsius" && destino == "Fahrenheit")
                return (valor * 9 / 5) + 32;
            if (origem == "Celsius" && destino == "Kelvin")
                return valor + 273.15;

            // Fahrenheit para...
            if (origem == "Fahrenheit" && destino == "Celsius")
                return (valor - 32) * 5 / 9;
            if (origem == "Fahrenheit" && destino == "Kelvin")
                return (valor - 32) * 5 / 9 + 273.15;

            // Kelvin para...
            if (origem == "Kelvin" && destino == "Celsius")
                return valor - 273.15;
            if (origem == "Kelvin" && destino == "Fahrenheit")
                return (valor - 273.15) * 9 / 5 + 32;

            throw new Exception("Conversão inválida.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbxTemp1.Clear();
            tbxTemp2.Clear();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form menu = new Form2();
            menu.Show();
            this.Visible = false;
        }
    }
}
