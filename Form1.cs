using System.Data;

namespace calculadora
{
    public partial class Form1 : Form
    {
        string[] historico = new string[10];
        int indexHistorico = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbVisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbVisor.Clear();
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + ",";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "+";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "-";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "×";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "÷";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                // Copia a string do visor
                string expressao = txbVisor.Text;

                // Substitui os símbolos visuais pelos que o .NET entende
                expressao = expressao.Replace("×", "*").Replace("÷", "/").Replace(",", ".");

                // TRATAMENTO: "10%*200" ou "10%×200" ? "(10/100*200)"
                var regexMultiplicacaoPercentual = new System.Text.RegularExpressions.Regex(@"(\d+(?:\.\d+)?)%\s*[*×]\s*(\d+(?:\.\d+)?)");
                expressao = regexMultiplicacaoPercentual.Replace(expressao, match =>
                {
                    string percentual = match.Groups[1].Value;
                    string valorBase = match.Groups[2].Value;
                    return $"({percentual}/100*{valorBase})";
                });

                // TRATAMENTO DA PORCENTAGEM:
                // Procurar padrões como: número + operador + número%
                // Exemplo: "200+10%" ? "200+(10/100*200)"
                var regex = new System.Text.RegularExpressions.Regex(@"(\d+(?:\.\d+)?)([+\-*/])(\d+(?:\.\d+)?)%");
                expressao = regex.Replace(expressao, match =>
                {
                    string valorAnterior = match.Groups[1].Value;
                    string operador = match.Groups[2].Value;
                    string percentual = match.Groups[3].Value;

                    // Substitui por: anterior + (percentual / 100 * anterior)
                    return $"{valorAnterior}{operador}({percentual}/100*{valorAnterior})";
                });

                // Avalia a expressão
                var resultado = new DataTable().Compute(expressao, null);

                // Mostra o resultado no visor
                txbVisor.Text = $"{resultado}";

                // Salva no histórico
                string entradaFormatada = expressao.Replace("*", "×").Replace("/", "÷").Replace(".", ",");
                string saidaFormatada = Convert.ToString(resultado)?.Replace(".", ",") ?? "Erro";
                string entradaCompleta = entradaFormatada + " = " + saidaFormatada;

                if (indexHistorico < historico.Length)
                {
                    historico[indexHistorico++] = entradaCompleta;
                }
                else
                {
                    // Sobrescreve do início (modo circular)
                    indexHistorico = 0;
                    historico[indexHistorico++] = entradaCompleta;
                }
            }
            catch
            {
                txbVisor.Text = "Erro";
            }
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "%";
        }

        private void btnParenteses_Click(object sender, EventArgs e)
        {
            string textoAtual = txbVisor.Text;

            // Conta quantos parênteses de abertura e fechamento já existem
            int abre = textoAtual.Count(c => c == '(');
            int fecha = textoAtual.Count(c => c == ')');

            // Decide qual parêntese inserir
            if (abre > fecha)
            {
                txbVisor.Text += ")";
            }
            else
            {
                txbVisor.Text += "(";
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txbVisor.Text.Length > 0)
            {
                txbVisor.Text = txbVisor.Text.Substring(0, txbVisor.Text.Length - 1);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form menu = new Form2();
            menu.Show();
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            string[] historicoNaoNulo = historico.Where(h => !string.IsNullOrEmpty(h)).ToArray();

            if (historicoNaoNulo.Length == 0)
            {
                MessageBox.Show("Nenhum cálculo realizado ainda.", "Histórico");
                return;
            }

            string mensagem = string.Join("\n", historicoNaoNulo.Reverse());
            MessageBox.Show(mensagem, "Histórico de Cálculos");
        }
    }
}
