using System;
using System.Text;
using System.Windows.Forms;

namespace PasswordShuffle
{
    public partial class Form1 : Form
    {
        private const string lettersLower = "abcdefghijklmnopqrstuvwxyz";
        private const string lettersUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string numbers = "1234567890";
        private const string specialChars = "!@#$%^&*()";
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
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            string allowedChars = "";

            if (checkBoxLetters.Checked)
                allowedChars += lettersLower + lettersUpper;

            if (checkBoxNumbers.Checked)
                allowedChars += numbers;

            if (checkBoxCaract.Checked)
                allowedChars += specialChars;

            if (allowedChars.Length == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins une option pour la génération du mot de passe !");
                return string.Empty;
            }

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