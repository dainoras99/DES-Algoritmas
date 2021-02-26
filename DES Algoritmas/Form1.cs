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
        private string mode;
        private bool encrypt;
        public Form1()
        {
            InitializeComponent();
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
               // DecryptValidations();
                encrypt = false;
                string key = decryptKeyTextBox.Text;
                string text = decryptThisTextBox.Text;
                if (decryptCbcRadioButton.Checked)
                    mode = "CBC";
                if (decryptEcbRadioButton.Checked)
                    mode = "ECB";

                decrypted.Text = Encrypt_Decrypt_Text(encrypt, mode, key, text);
                

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
                //EncryptValidations();
                encrypt = true;
                string key = encryptKeyTextBox.Text;
                string text = encryptThisTextBox.Text;
                if (cbcEncryptRadioButton.Checked)
                    mode = "CBC";
                if (ecbEncryptRadioButton.Checked)
                    mode = "ECB";

                encrypted.Text = Encrypt_Decrypt_Text(encrypt, mode, key, text);

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
            if (encryptKeyTextBox.Text.Length != 8)
                throw new Exception("Raktas turi būti sudarytas iš aštuonių simbolių!");
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
            if (decryptKeyTextBox.Text.Length != 8)
                throw new Exception("Raktas turi būti sudarytas iš aštuonių simbolių!");
            if (string.IsNullOrWhiteSpace(decryptThisTextBox.Text))
                throw new Exception("Turite įkeltį nuskaitomą failą arba parašyti atkoduojamą tekstą");
            if (!decryptEcbRadioButton.Checked && !decryptCbcRadioButton.Checked)
                throw new Exception("Turite pasirinkite - ECB arba CBC!");
        }


        private string Encrypt_Decrypt_Text(bool encrypt, string mode, string key, string text)
        {
            byte[] keyNumbers = ASCIIEncoding.ASCII.GetBytes(key);
            byte[] textNumbers = ASCIIEncoding.ASCII.GetBytes(text);
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                DES.IV = keyNumbers;
                DES.Key = keyNumbers;
                if (mode == "ECB")
                    DES.Mode = CipherMode.ECB;
                if (mode == "CBC")
                    DES.Mode = CipherMode.CBC;

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = null;
            if (encrypt == true)
                cryptoStream = new CryptoStream(memoryStream, DES.CreateEncryptor(), CryptoStreamMode.Write);
            if (encrypt == false)
                cryptoStream = new CryptoStream(memoryStream, DES.CreateDecryptor(), CryptoStreamMode.Write);

            cryptoStream.Write(textNumbers, 0, textNumbers.Length);
            cryptoStream.FlushFinalBlock();

            byte[] encryptedOrDecryptedNumbers = memoryStream.ToArray();
            string encryptedOrDecryptedText = ASCIIEncoding.ASCII.GetString(encryptedOrDecryptedNumbers);

            return encryptedOrDecryptedText;

            // sukuriamas encryptorius(su key bitais ir pradzios vektoriumi) kuris darys basic pakeitimus
            //ICryptoTransform transform = DES.CreateEncryptor(keyNumbers, keyNumbers);
            //CryptoStreamMode mode = CryptoStreamMode.Write;

            //MemoryStream memStream = new MemoryStream();
            //CryptoStream cryptoStream = new CryptoStream(memStream, transform, mode);
            //cryptoStream.Write(textNumbers, 0, textNumbers.Length);
            //cryptoStream.FlushFinalBlock();

            //byte[] encryptedTextNumbers = new byte[memStream.Length];
            //memStream.Position = 0;
            //memStream.Read(encryptedTextNumbers, 0, encryptedTextNumbers.Length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
