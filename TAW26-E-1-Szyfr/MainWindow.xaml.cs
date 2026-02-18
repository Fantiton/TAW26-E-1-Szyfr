using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TAW26_E_1_Szyfr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(Object sender, EventArgs e)
        {
            List<char> inputText = TextTextBox.Text.ToList();

            int key;
            if (!int.TryParse(KeyTextBox.Text, out key))
            {
                key = 0;
            }

            List<char> encryptedText = new List<char>();

            foreach (char c in inputText)
            {
                char encryptedChar = c; 
                if (Char.IsLower(c))
                {
                    encryptedChar = (char)(((c + key - 'a') % 26) + 'a');
                }

                encryptedText.Add(encryptedChar);
            }

            EncryptedTextTextBlock.Text = new string(encryptedText.ToArray());
        }

        private void SaveCipherButton_Click(Object sender, EventArgs e)
        {
            
        }
    }
}