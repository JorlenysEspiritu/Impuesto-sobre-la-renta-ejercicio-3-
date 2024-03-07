namespace InterfazGrafica_Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAfp.Clear();
            txtIsr.Clear();
            txtMensaje.Clear();
            txtSfs.Clear();
            txtSueldo.Clear();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            double sfs, afp, isr, sueldo, sueldo_anual;

            sueldo = double.Parse(txtSueldo.Text);

            sueldo_anual = sueldo * 12;

            sfs = (sueldo * 3.04) / 100;
            afp = (sueldo * 2.87) / 100;

            if (sueldo_anual >= 416220.01)
            {
                isr = ((sueldo * 15) / 100) / 12;
                txtIsr.Text = isr.ToString();
                txtMensaje.Text = "Aplica";
            }

            else if (sueldo_anual >= 624329.01)
            {
                isr = ((sueldo * 20) / 100) / 12;
                txtIsr.Text = isr.ToString();
                txtMensaje.Text = "Aplica";
            }

            else if (sueldo_anual >= 867123.01)
            {
                isr = ((sueldo * 25) / 100) / 12;
                txtIsr.Text = isr.ToString();
                txtMensaje.Text = "Aplica";
            }

            else
            {

                txtMensaje.Text = "N/A";
                txtIsr.Enabled = false;
            }

            txtSueldo.Text = sueldo.ToString();
            txtSfs.Text = sfs.ToString();
            txtAfp.Text = afp.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}