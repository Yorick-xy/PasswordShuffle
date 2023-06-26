using System;
using System.Text;
using System.Windows.Forms;

namespace PasswordShuffle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNbCaract.Text, out int nbCaract))
            {
                string password = GenerateRandomPassword(nbCaract);
                textBoxPassword.Text = password;
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide dans le champ de caractères !");
            }
        }

        private string GenerateRandomPassword(int length)
        {
            const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890&~#{[-|_@])}=+<>,;:/!§*$.";
            StringBuilder password = new StringBuilder();

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(0, allowedChars.Length);
                password.Append(allowedChars[randomIndex]);
            }

            return password.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}