namespace Prolab2_1.deneme
{
    public partial class Bilet : Form
    {
        public Bilet()
        {
            InitializeComponent();

            TextBox textBox1 = new TextBox();

            this.Controls.Add(textBox1);

            textBox1.Text = "TC Kimlik NO:";

            button1.Text = "Giriþ Yap";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
