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
        private Random random = new Random();
        private byte[] IV = new byte[8];
        Encoding encoding = Encoding.GetEncoding("437"); // Code Page 437 to translate the 8-bit ASCII text to the Unicode equivalent.
        public Form1()
        {
            InitializeComponent();
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            try
            {
               // DecryptValidations();
                encrypt = false;
                string key = decryptKeyTextBox.Text;
                string text = decryptThisTextBox.Text;
                if (decryptCbcRadioButton.Checked)
                    mode = "CBC";
                if (decryptEcbRadioButton.Checked)
                    mode = "ECB";

                // decrypted.Text = Encrypt_Decrypt_Text(key, text);
                /////////////////////////////////////////////////
                decryptedText.Text = Encrypt_Decrypt_Text(key, text);

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
                random.NextBytes(IV);


                
                
                encryptIV.Text = encoding.GetString(IV);

                if (cbcEncryptRadioButton.Checked)
                    mode = "CBC";
                if (ecbEncryptRadioButton.Checked)
                    mode = "ECB";

                //encrypted.Text = Encrypt_Decrypt_Text(key, text);
                ////////////////////////////////////////////////
                encrytedText.Text = Encrypt_Decrypt_Text(key, text);

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


        private string Encrypt_Decrypt_Text(string key, string text)
        {
            byte[] keyNumbers = encoding.GetBytes(key);
            byte[] textNumbers = encoding.GetBytes(text);
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = keyNumbers;
            DES.BlockSize = 64;
            if (mode == "ECB")
                DES.Mode = CipherMode.ECB;
            if (mode == "CBC")
            {
                DES.IV = IV;
                DES.Mode = CipherMode.CBC;
            }


            MemoryStream memoryStream = new MemoryStream();
            memoryStream.Position = 0;
            CryptoStream cryptoStream = null;
            if (encrypt == true)
                cryptoStream = new CryptoStream(memoryStream, DES.CreateEncryptor(), CryptoStreamMode.Write);
            if (encrypt == false)
                cryptoStream = new CryptoStream(memoryStream, DES.CreateDecryptor(), CryptoStreamMode.Write);

            cryptoStream.Write(textNumbers, 0, textNumbers.Length);
            cryptoStream.FlushFinalBlock();
            
            byte[] encryptedOrDecryptedNumbers = memoryStream.ToArray();
           
            string encryptedOrDecryptedText = encoding.GetString(encryptedOrDecryptedNumbers);

            return encryptedOrDecryptedText;
        }
    }
}
