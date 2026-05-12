using ESWA07CalculadoraDeMedias;
using OOPFoundation;
namespace CalculadoraDeMedias01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtExame.Enabled = false;
            btnFinal.Enabled = false;
        }

        private void btnSemestral_Click(object sender, EventArgs e)
        {
            // 1. Tenta converter os textos para números com segurança
            bool n1Ok = double.TryParse(txtNP1.Text, out double n1);
            bool n2Ok = double.TryParse(txtNP2.Text, out double n2);
            bool pOk = double.TryParse(txtPIM.Text, out double p);

           
            NoteValidation validator = new NoteValidation();

            if (n1Ok && n2Ok && pOk &&
                validator.DoubleIsValid(n1, 10) &&
                validator.DoubleIsValid(n2, 10) &&
                validator.DoubleIsValid(p, 10))
            {
                // 3. Se estiver tudo OK, faz o cálculo usando sua DLL
                Calculadora calc = new Calculadora();
                double ms = calc.CalcularMediaSemestral(n1, n2, p);

                // Mostra o resultado
                lblResultadoSemestral.Text = ms.ToString("N1");

                // Lógica de Status
                if (ms >= 7.0)
                {
                    lblStatus.Text = "APROVADO";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.Text = "EM EXAME";
                    lblStatus.ForeColor = Color.Orange;

                    // Habilita os campos do exame
                    txtExame.Enabled = true;
                    btnFinal.Enabled = true;
                    btnLimparFinal.Enabled = true;
                }
            }
            else
            {
                // 4. Se algo estiver errado, avisa o usuário (Sanitização do Item 10)
                MessageBox.Show("Por favor, digite apenas notas de 0 a 10 em todos os campos.",
                                "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Pega a média que já estava na tela e a nota do exame
                double mediaS = double.Parse(lblResultadoSemestral.Text);
                double exame = double.Parse(txtExame.Text);

                // 2. Chama o cálculo da sua biblioteca (DLL)
                Calculadora calc = new Calculadora();
                double mediaFinal = calc.CalcularMediaFinal(mediaS, exame);

                // 3. Mostra o resultado na label lá de baixo
                lblResultadoFinal.Text = mediaFinal.ToString("N1");

                // 4. Regra de aprovação pós-exame (Média >= 5.0)
                if (mediaFinal >= 5.0)
                {
                    lblStatus.Text = "APROVADO EM EXAME";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.Text = "REPROVADO";
                    lblStatus.ForeColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Digite a nota do exame.");
            }
        }

        private void btnLimparSemestral_Click(object sender, EventArgs e)
        {
            // Dentro do btnLimparSemestral_Click
            txtNP1.Clear();
            txtNP2.Clear();
            txtPIM.Clear();
            lblResultadoSemestral.Text = "0,0";
            lblStatus.Text = "EM ANDAMENTO";
            lblStatus.ForeColor = Color.Black;
            btnLimparFinal.Enabled = false;

            // Bloqueia os campos de exame de novo (Item 8.i)
            txtExame.Clear();
            txtExame.Enabled = false;
            lblResultadoFinal.Text = "0,0";
            btnFinal.Enabled = false;

            // Opcional: coloca o foco no primeiro campo
            txtNP1.Focus();
        }

        private void btnLimparFinal_Click(object sender, EventArgs e)
        {
            // Dentro do btnLimparFinal_Click
            txtExame.Clear();
            lblResultadoFinal.Text = "0,0";

            // Status volte para "EM EXAME" ao limpar o final:
            lblStatus.Text = "EM EXAME";
            lblStatus.ForeColor = Color.Black;

            txtExame.Focus();
        }
    }
}