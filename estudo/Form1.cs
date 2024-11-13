namespace estudo
{
    public partial class Form1 : Form
    {
        public class Candidato
        {
            public int Numero { get; set; }
            public string Nome { get; set; }

            public Candidato(int numero, string nome)
            {
                Numero = numero;
                Nome = nome;
            }
        }

        // Declaração da lista de candidatos
        List<Candidato> candidatos;

        public Form1()
        {
            InitializeComponent();
            // Inicialização da lista de candidatos
            candidatos = new List<Candidato>
            {
                new Candidato(10, "Candidato 10"),
                new Candidato(25, "Candidato 25"),
                new Candidato(30, "Candidato 30")
            };
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            AdicionarNumero("0");
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            AdicionarNumero("1");
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            AdicionarNumero("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            AdicionarNumero("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            AdicionarNumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            AdicionarNumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            AdicionarNumero("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            AdicionarNumero("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            AdicionarNumero("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            AdicionarNumero("9");
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "0";
        }

        private void btnComfirma_Click(object sender, EventArgs e)
        {
            int numero;
            if (int.TryParse(txtNumero.Text, out numero))
            {
                if (numero == 0)
                {
                    MessageBox.Show("Voto em branco registrado.");
                }
                else
                {
                    var candidato = candidatos.FirstOrDefault(c => c.Numero == numero);
                    if (candidato != null)
                    {
                        MessageBox.Show($"Voto registrado para {candidato.Nome}.");
                    }
                    else
                    {
                        MessageBox.Show("Candidato não encontrado.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Número inválido.");
            }
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            txtNumero.Text = string.Empty;
        }

        private void AdicionarNumero(string numero)
        {
            txtNumero.Text += numero;
        }
    }
}
