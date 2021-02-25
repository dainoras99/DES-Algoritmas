using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace DES_Algoritmas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                DecryptValidations();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                EncryptValidations();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void EncryptValidations()
        {
            if (string.IsNullOrWhiteSpace(encryptKeyTextBox.Text))
                throw new Exception("Raktas negali būti tusčias");
            if (string.IsNullOrWhiteSpace(encryptThisTextBox.Text))
                throw new Exception("Turite įkelti failą arba parašyti norimą koduoti tekstą");
            if (string.IsNullOrWhiteSpace(saveLocationTextBox.Text))
                throw new Exception("Turite nurodytį kur įrašysite failą");
            if (!ecbEncryptRadioButton.Checked && !cbcEncryptRadioButton.Checked)
                throw new Exception("Turite pasirinkite - ECB arba CBC!");

        }
        private void DecryptValidations()
        {
            if (string.IsNullOrWhiteSpace(decryptKeyTextBox.Text))
                throw new Exception("Raktas negali būti tusčias");
            if (string.IsNullOrWhiteSpace(decryptThisTextBox.Text))
                throw new Exception("Turite įkeltį nuskaitomą failą arba parašyti atkoduojamą tekstą");
            if (!decryptEcbRadioButton.Checked && !decryptCbcRadioButton.Checked)
                throw new Exception("Turite pasirinkite - ECB arba CBC!");
        }

    }
}
