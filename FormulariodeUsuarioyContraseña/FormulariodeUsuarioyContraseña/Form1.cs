namespace FormulariodeUsuarioyContraseña
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        bool InicioDeSecion = false;
        string mensaje = "";
        int Numeros_intentos = 0;
        private void InicialSecion_Click(object sender, EventArgs e)
        {
            Numeros_intentos++;
            if (Numeros_intentos >= 4)
            {
                InicialSecion.Enabled = false;
            }

            string nombre = textBoxNombre.Text;
            string constraseña = textBoxcontraseña.Text;

            if (nombre == "Eduardo" && constraseña == "1234")
            {
                Numeros_intentos = 0;
                InicioDeSecion = true;
                MessageBox.Show("Iniciaste secion");
                mensaje = "Iniciaste Secion";
            }
            else
            { 
                MessageBox.Show("Datos invalidos");
                mensaje = Convert.ToString(Numeros_intentos);
            }
            
            intentos.Text = "intento : " + mensaje;
            
        }
    }
}
