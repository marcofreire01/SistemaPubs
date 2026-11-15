namespace SistemaPubs
{
    public partial class FrmLogin : Form
    {
        private int intentos = 0;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" &&
                txtClave.Text == "1234")
            {
                MessageBox.Show("Bienvenido al sistema");
                FrmMenu frm = new FrmMenu();
                frm.Show();

                this.Hide();
            }
            else
            {
                intentos++;

                MessageBox.Show(
                    $"Usuario o contraseña incorrectos.\nIntento {intentos} de 3");

                txtClave.Clear();
                txtClave.Focus();

                if (intentos >= 3)
                {
                    MessageBox.Show(
                        "Ha superado los 3 intentos permitidos.");

                    Application.Exit();
                }
            }
        }
    }
}