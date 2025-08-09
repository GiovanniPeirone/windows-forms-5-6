namespace CálculodeDistanciaRecorrida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox2.Enabled = true;
                button1.Enabled = true;
                textBox3.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double velocidad = int.Parse(textBox1.Text);
                double tiempo = int.Parse(textBox2.Text);

                double distancia = velocidad * tiempo;

                textBox3.Text = distancia.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO ES UN NUMERO VALIDO"+ex);
            }

        }
    }
}
