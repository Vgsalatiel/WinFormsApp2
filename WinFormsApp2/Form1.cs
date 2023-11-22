using System.Media;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Candidato> _dicCanditado;
        public Form1()
        {
            InitializeComponent();
            _dicCanditado = new Dictionary<string, Candidato>();
            _dicCanditado.Add("13", new Candidato() { Id = 13, Nome = "Lula", Partido = "Partido dos Trabalhadores", Foto = Properties.Resources.Lalu });
            _dicCanditado.Add("17", new Candidato() { Id = 17, Nome = "Bolsonaro", Partido = "Partido Liberal", Foto = Properties.Resources.bosolaro });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarDigito("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            RegistrarDigito("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            RegistrarDigito("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            RegistrarDigito("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            RegistrarDigito("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            RegistrarDigito("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            RegistrarDigito("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            RegistrarDigito("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            RegistrarDigito("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            RegistrarDigito("0");
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            pnFim.Visible = true;
            Limpar();

            SoundPlayer s = new SoundPlayer(Properties.Resources.urna);
            s.Play();
            Relogio.Tick += new EventHandler(AcaoFinal);
            Relogio.Interval = 3000;
            Relogio.Enabled = true;
            Relogio.Start();
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            Limpar();
            Relogio.Stop();
            Relogio.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPresidente1.Text))
            {
                MessageBox.Show("Favor informar o candidato.");
                return;
            }

            pnFim.Visible = true;
            Limpar();

            SoundPlayer s = new SoundPlayer(Properties.Resources.urna);
            s.Play();
            Relogio.Tick += new EventHandler(AcaoFinal);
            Relogio.Interval = 3000;
            Relogio.Enabled = true;
            Relogio.Start();
        }

        private void picBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void AcaoFinal(Object myObject, EventArgs myEventArgs)
        {
            Relogio.Stop();
            Relogio.Enabled = false;
            pnFim.Visible = false;
        }

        private void RegistrarDigito(string digito)
        {
            if (string.IsNullOrEmpty(txtPresidente1.Text))
                txtPresidente1.Text = digito;
            else
            {
                txtPresidente2.Text = digito;
                PreencherCandidato(txtPresidente1.Text, txtPresidente2.Text);
            }
        }

        private void PreencherCandidato(string d1, string d2)
        {
            if (_dicCanditado.ContainsKey(d1 + d2))
            {
                lblNome.Text = _dicCanditado[d1 + d2].Nome;
                lblPartido.Text = _dicCanditado[d1 + d2].Partido;
                picBox1.Image = _dicCanditado[d1 + d2].Foto;
            }
            else
            {
                MessageBox.Show("Candidato não encontrado!");
            }
        }
        private void Limpar()
        {
            txtPresidente1.Text = "";
            txtPresidente2.Text = "";
            lblNome.Text = String.Empty;
            lblPartido.Text = String.Empty;
            picBox1.Image = null;
        }

        private void Relogio_Tick(object sender, EventArgs e)
        {

        }
    }
    public class Candidato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Partido { get; set; }
        public Image Foto { get; set; }
    }
}