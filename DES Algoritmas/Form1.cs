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
        private bool encryptTrue_decryptFalse;
        private Random random = new Random();
        private byte[] IV = new byte[8];
        private string lastIVencrypt = "";
        private string lastIVdecrypt = "";
        Encoding encoding = Encoding.GetEncoding("437"); // Code Page 437 leidžia naudoti ir supranta visus 255 ASCII table simbolius
        public Form1()
        {
            InitializeComponent();
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                DecryptValidations();
                encryptTrue_decryptFalse = false;
                string key = decryptKeyTextBox.Text;
                string text = decryptThisTextBox.Text;
                if (decryptCbcRadioButton.Checked)
                    mode = "CBC";
                if (decryptEcbRadioButton.Checked)
                    mode = "ECB";

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
                EncryptValidations();
                encryptTrue_decryptFalse = true;
                string key = encryptKeyTextBox.Text;
                string text = encryptThisTextBox.Text;

                if (cbcEncryptRadioButton.Checked)
                    mode = "CBC";
                if (ecbEncryptRadioButton.Checked)
                    mode = "ECB";

                string encryptedText = Encrypt_Decrypt_Text(key, text);
                encrytedText.Text = encryptedText;

                string path = filePath.Text;
                if (path != "")
                    WriteToFile(path, encryptedText);


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
                throw new Exception("Turite parašyti norimą šifruoti tekstą");
            if (!ecbEncryptRadioButton.Checked && !cbcEncryptRadioButton.Checked)
                throw new Exception("Turite pasirinkite - ECB arba CBC!");
            if (cbcEncryptRadioButton.Checked == true)
                if (encryptIV.Text == "")
                    throw new Exception("Pasirinkus cbc modą, turite sugeneruoti IV (pradžios vektorių)");

        }
        private void DecryptValidations()
        {
            if (string.IsNullOrWhiteSpace(decryptKeyTextBox.Text))
                throw new Exception("Raktas negali būti tusčias");
            if (decryptKeyTextBox.Text.Length != 8)
                throw new Exception("Raktas turi būti sudarytas iš aštuonių simbolių!");
            if (string.IsNullOrWhiteSpace(decryptThisTextBox.Text))
                throw new Exception("Turite įkelti nuskaitomą failą arba parašyti atšifruojamą tekstą");
            if (!decryptEcbRadioButton.Checked && !decryptCbcRadioButton.Checked)
                throw new Exception("Turite pasirinkite - ECB arba CBC!");
            if (decryptCbcRadioButton.Checked == true)
                if (decryptIV.Text == "")
                    throw new Exception("Pasirinkus cbc modą, turite sugeneruoti IV (pradžios vektorių)");
        }


        private string Encrypt_Decrypt_Text(string key, string text) // Šifravimo/dešifravimo funkcija
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


            MemoryStream memoryStream = new MemoryStream(); // memoryStream į kurį įrašomas rezultatas
            memoryStream.Position = 0;
            CryptoStream cryptoStream = null;
            if (encryptTrue_decryptFalse == true)
                cryptoStream = new CryptoStream(memoryStream, DES.CreateEncryptor(), CryptoStreamMode.Write);
            if (encryptTrue_decryptFalse == false)
                cryptoStream = new CryptoStream(memoryStream, DES.CreateDecryptor(), CryptoStreamMode.Write);

            cryptoStream.Write(textNumbers, 0, textNumbers.Length); 
            cryptoStream.FlushFinalBlock();
            
            byte[] encryptedOrDecryptedNumbers = memoryStream.ToArray();
           
            string encryptedOrDecryptedText = encoding.GetString(encryptedOrDecryptedNumbers);

            return encryptedOrDecryptedText;
        }
        private void WriteToFile(string path, string encryptedText) // teksto įrašymas į failą pagal path
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(encryptedText);
            }
        }

        private void ReadFromFile(string path) // nuskaitytą failo informaciją įkeliama į textboxą
        {
            decryptThisTextBox.Text = File.ReadAllText(path);
        }
        private void saveAtThisLocationButton_Click(object sender, EventArgs e) // mygtukas kuris atidaro filedialog(doc, docx, txt, text) ir gauna path
        { 
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text Files|*.doc;*.docx;*.txt;*.text";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = fileDialog.FileName;
            }
        }

        private void getFileAtThisLocationButton_Click(object sender, EventArgs e) // Nuskaitymas iš failo mygtukas 
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text Files|*.doc;*.docx;*.txt;*.text";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                scanFileTextBox.Text = fileDialog.FileName;
                ReadFromFile(scanFileTextBox.Text);
            }
        }

        private void ecbEncryptRadioButton_CheckedChanged(object sender, EventArgs e) // Jeigu pasirenkamas ECB radio mygtukas iškviečiamos funkcijos kurios visibility pradžios vektoriui nustatys true - šifravime
        {
            IVencryptVisibilityFalse();
            encryptIV.Text = "";
        }

        private void cbcEncryptRadioButton_CheckedChanged(object sender, EventArgs e) // Jeigu pasirenkamas CBC radio mygtukas iškviečiamos funkcijos kurios visibility pradžios vektoriui nustatys true - šifravime
        {
            IVencryptVisibilityTrue();
        }

        private void decryptEcbRadioButton_CheckedChanged(object sender, EventArgs e) // Jeigu pasirenkamas ECB radio mygtukas iškviečiamos funkcijos kurios visibility pradžios vektoriui nustatys true - dešifravime
        {
            IVdecryptVisibilityFalse();
            decryptIV.Text = "";
        }

        private void decryptCbcRadioButton_CheckedChanged(object sender, EventArgs e) // Jeigu pasirenkamas CBC radio mygtukas iškviečiamos funkcijos kurios visibility pradžios vektoriui nustatys true - dešifravime
        {
            IVdecryptVisibilityTrue();
        }
        private void IVencryptVisibilityTrue() // visibility pakeitimas (pradžios vektoriui) į true šifravimo skilty
        {
            label15.Visible = true;
            encryptIV.Visible = true;
            pastepreviousIVButton.Visible = true;
            generateIVButton.Visible = true;
        }

        private void IVencryptVisibilityFalse() // visibility pakeitimas (pradžios vektoriui) į false šifravimo skilty
        {
            label15.Visible = false;
            encryptIV.Visible = false;
            pastepreviousIVButton.Visible = false;
            generateIVButton.Visible = false;
        }
        private void IVdecryptVisibilityTrue() // visibility pakeitimas (pradžios vektoriui) į true dešifravimo skiltį
        {
            label13.Visible = true;
            decryptIV.Visible = true;
            pasteLastIv.Visible = true;
            GeneratedIV.Visible = true;
        }
        private void IVdecryptVisibilityFalse() // visibility pakeitimas (pradžios vektoriui) į false dešifravimo skilį
        {
            label13.Visible = false;
            decryptIV.Visible = false;
            pasteLastIv.Visible = false;
            GeneratedIV.Visible = false;
        }

        private void generateIVButton_Click(object sender, EventArgs e) // Mygtukas sugeneruoja random pradžios vektorių šifravime
        {
            random.NextBytes(IV);
            lastIVencrypt = encoding.GetString(IV);
            encryptIV.Text = lastIVencrypt;
        }


        private void pastepreviousIVButton_Click(object sender, EventArgs e) // Mygtukas leidžia šifravimo skilty atspausdinti paskutinį naudotą pradžios vektorių dešifravime
        {
            try
            {
                if (lastIVdecrypt == "")
                    throw new Exception("Dešifravime IV raktas nebuvo sugeneruotas");
                encryptIV.Text = lastIVdecrypt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void GeneratedIV_Click(object sender, EventArgs e) // Mygtukas  sugeneruoja random pradžios vektorių dešifravime
        {
            random.NextBytes(IV);
            lastIVdecrypt = encoding.GetString(IV);
            decryptIV.Text = lastIVdecrypt;
        }

        private void pasteLastIv_Click(object sender, EventArgs e) // Mygtukas leidžia dešifravimo skilty atspausdinti paskutinį naudotą pradžios vektorių šifravime
        {
            try
            {
                if (lastIVencrypt == "")
                    throw new Exception("Dešifravime IV raktas nebuvo sugeneruotas");
                decryptIV.Text = lastIVencrypt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void encryptCleanButton_Click(object sender, EventArgs e) // Mygtukas "Valyti" šifravime
        {
            encryptKeyTextBox.Text = "";
            encryptThisTextBox.Text = "";
            encryptIV.Text = "";
            filePath.Text = "";
            encrytedText.Text = "";
            ecbEncryptRadioButton.Checked = false;
            cbcEncryptRadioButton.Checked = false;


        }

        private void decryptCleanButton_Click(object sender, EventArgs e) // Mygtukas "Valyti" dešifravime
        {
            decryptKeyTextBox.Text = "";
            scanFileTextBox.Text = "";
            decryptThisTextBox.Text = "";
            decryptIV.Text = "";
            decryptedText.Text = "";
            decryptEcbRadioButton.Checked = false;
            decryptCbcRadioButton.Checked = false;
        }

        private void cleanenPath_Click(object sender, EventArgs e) // Mygtukas "x" prie failo lokacijos textbox'e, kuris išvalo text'boxą šifravime
        {
            filePath.Text = "";
        }

        private void cleandePath_Click(object sender, EventArgs e) // Mygtukas "x" prie failo lokacijos textbox'e, kuris išvalo text'boxą dešifravime
        {
            scanFileTextBox.Text = "";
        }
    }
}
