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
                if (string.IsNullOrWhiteSpace(keyTextBox.Text))
                    throw new Exception("Raktas negali būti tusčias");
                if (string.IsNullOrWhiteSpace(saveLocationTextBox.Text))
                    throw new Exception("Turite nurodytį failo išsaugojimo vietą");
            }
            catch
            {

            }
        }
    }
}
