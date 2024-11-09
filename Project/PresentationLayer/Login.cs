using Project.PresentationLayer;
using Project.BusinessLayer;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        AuthenticationService service = new AuthenticationService();

        private void button1_Click(object sender, EventArgs e)
        {
            if (service.isAuthenticated(textBox1.Text, textBox2.Text))
            {
                Display display = new Display();
                display.Show();
                this.Hide();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // service.createFile();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            service.registerUser(textBox1.Text, textBox2.Text);
        }
    }
}