using System.Diagnostics;
using System.Text.RegularExpressions;

namespace desktop_app
{
    public partial class Form1 : Form
    {
        string letters = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPLKJHGFDSAZXCVBNM";
        string numbers = "0123456789";
        string specialChar = "!@#$%^&*()_+-=";
        string password;

        public Form1()
        {
            InitializeComponent();
        }

        // nazwa funkcji: randomChar
        // opis funkcji: funkcja losuje 1 losowy znak z przekazanego stringu
        // parametry: regex - ci¹g znaków z którego bêdzie losowany znak 
        // zwracany typ: char, zwraca losowy znak 
        // autor: 00000000000


        private char randomChar(string regex)
        {
            Random random = new Random();
            if (string.IsNullOrEmpty(regex))
            {
                Console.WriteLine("ERROR");
            }

            int index = random.Next(regex.Length);

            char randomCharacter = regex[index];

            return randomCharacter;
        }



        // nazwa funkcji: generPassBtn_Click
        // opis funkcji: funkcja wywo³ywana po przycisku "generuj has³o"
        // parametry: object sender, EventArgs e 
        // zwracany typ: void 
        // autor: 00000000000
        private void generPassBtn_Click(object sender, EventArgs e)
        {
            int passwordLong = int.Parse(textBox3.Text);
            string generatePassword = "";


            for (int i = 0; i < passwordLong; i++)
            {
                if (lettersCheckBox.Checked)
                {

                    char randomLetter = randomChar(letters);
                    generatePassword = generatePassword + randomLetter;

                }

                if (numbersCheckBox.Checked)

                {
                    char randomNumber = randomChar(numbers);
                    generatePassword = generatePassword + randomNumber;
                }

                if (specialCharCheckBox.Checked)
                {

                    char randomSpecialChar = randomChar(specialChar);
                    generatePassword = generatePassword + randomSpecialChar;
                }
            }

           password = generatePassword.Substring(0, passwordLong);

            MessageBox.Show(password);

        }

        // nazwa funkcji: saveBtn_Click
        // opis funkcji: funkcja wywo³ywana po przycisku "zatwierdŸ"
        // parametry: object sender, EventArgs e 
        // zwracany typ: void 
        // autor: 00000000000
        private void saveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dane pracownika: " + textBox1.Text + " " + textBox2.Text + " " + comboBox1.Text +" " + "Has³o: " + password );
        }
    }
}
