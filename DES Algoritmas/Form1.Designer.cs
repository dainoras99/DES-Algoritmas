
namespace DES_Algoritmas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabEncryptPage = new System.Windows.Forms.TabPage();
            this.saveLocationTextBox = new System.Windows.Forms.RichTextBox();
            this.cbcEncryptRadioButton = new System.Windows.Forms.RadioButton();
            this.ecbEncryptRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.saveAtThisLocationButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptKeyTextBox = new System.Windows.Forms.RichTextBox();
            this.encryptThisTextBox = new System.Windows.Forms.RichTextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.tabDecryptPage = new System.Windows.Forms.TabPage();
            this.scanFileTextBox = new System.Windows.Forms.RichTextBox();
            this.decryptCbcRadioButton = new System.Windows.Forms.RadioButton();
            this.decryptEcbRadioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.getFileAtThisLocationButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.decryptKeyTextBox = new System.Windows.Forms.RichTextBox();
            this.decryptThisTextBox = new System.Windows.Forms.RichTextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabEncryptPage.SuspendLayout();
            this.tabDecryptPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabEncryptPage);
            this.tabControl.Controls.Add(this.tabDecryptPage);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1120, 622);
            this.tabControl.TabIndex = 2;
            // 
            // tabEncryptPage
            // 
            this.tabEncryptPage.BackColor = System.Drawing.SystemColors.Info;
            this.tabEncryptPage.Controls.Add(this.saveLocationTextBox);
            this.tabEncryptPage.Controls.Add(this.cbcEncryptRadioButton);
            this.tabEncryptPage.Controls.Add(this.ecbEncryptRadioButton);
            this.tabEncryptPage.Controls.Add(this.label5);
            this.tabEncryptPage.Controls.Add(this.saveAtThisLocationButton);
            this.tabEncryptPage.Controls.Add(this.label4);
            this.tabEncryptPage.Controls.Add(this.label3);
            this.tabEncryptPage.Controls.Add(this.label2);
            this.tabEncryptPage.Controls.Add(this.label1);
            this.tabEncryptPage.Controls.Add(this.encryptKeyTextBox);
            this.tabEncryptPage.Controls.Add(this.encryptThisTextBox);
            this.tabEncryptPage.Controls.Add(this.encryptButton);
            this.tabEncryptPage.Location = new System.Drawing.Point(4, 22);
            this.tabEncryptPage.Name = "tabEncryptPage";
            this.tabEncryptPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabEncryptPage.Size = new System.Drawing.Size(1112, 596);
            this.tabEncryptPage.TabIndex = 0;
            this.tabEncryptPage.Text = "Šifravimas";
            // 
            // saveLocationTextBox
            // 
            this.saveLocationTextBox.Location = new System.Drawing.Point(351, 110);
            this.saveLocationTextBox.Name = "saveLocationTextBox";
            this.saveLocationTextBox.ReadOnly = true;
            this.saveLocationTextBox.Size = new System.Drawing.Size(321, 21);
            this.saveLocationTextBox.TabIndex = 12;
            this.saveLocationTextBox.Text = "";
            // 
            // cbcEncryptRadioButton
            // 
            this.cbcEncryptRadioButton.AutoSize = true;
            this.cbcEncryptRadioButton.Location = new System.Drawing.Point(324, 458);
            this.cbcEncryptRadioButton.Name = "cbcEncryptRadioButton";
            this.cbcEncryptRadioButton.Size = new System.Drawing.Size(46, 17);
            this.cbcEncryptRadioButton.TabIndex = 11;
            this.cbcEncryptRadioButton.TabStop = true;
            this.cbcEncryptRadioButton.Text = "CBC";
            this.cbcEncryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // ecbEncryptRadioButton
            // 
            this.ecbEncryptRadioButton.AutoSize = true;
            this.ecbEncryptRadioButton.Location = new System.Drawing.Point(272, 458);
            this.ecbEncryptRadioButton.Name = "ecbEncryptRadioButton";
            this.ecbEncryptRadioButton.Size = new System.Drawing.Size(46, 17);
            this.ecbEncryptRadioButton.TabIndex = 10;
            this.ecbEncryptRadioButton.TabStop = true;
            this.ecbEncryptRadioButton.Text = "ECB";
            this.ecbEncryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pasirinkite šifravimo modą:";
            // 
            // saveAtThisLocationButton
            // 
            this.saveAtThisLocationButton.Location = new System.Drawing.Point(678, 110);
            this.saveAtThisLocationButton.Name = "saveAtThisLocationButton";
            this.saveAtThisLocationButton.Size = new System.Drawing.Size(24, 23);
            this.saveAtThisLocationButton.TabIndex = 7;
            this.saveAtThisLocationButton.Text = "...";
            this.saveAtThisLocationButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nurodykite išsaugoto teksto failo vietą:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Norimas šifruoti tekstas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Raktas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Šifruoti";
            // 
            // encryptKeyTextBox
            // 
            this.encryptKeyTextBox.Location = new System.Drawing.Point(134, 76);
            this.encryptKeyTextBox.Name = "encryptKeyTextBox";
            this.encryptKeyTextBox.Size = new System.Drawing.Size(321, 21);
            this.encryptKeyTextBox.TabIndex = 2;
            this.encryptKeyTextBox.Text = "";
            // 
            // encryptThisTextBox
            // 
            this.encryptThisTextBox.Location = new System.Drawing.Point(56, 163);
            this.encryptThisTextBox.Name = "encryptThisTextBox";
            this.encryptThisTextBox.Size = new System.Drawing.Size(594, 272);
            this.encryptThisTextBox.TabIndex = 1;
            this.encryptThisTextBox.Text = "";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(289, 532);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "Šifruoti";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // tabDecryptPage
            // 
            this.tabDecryptPage.BackColor = System.Drawing.SystemColors.Info;
            this.tabDecryptPage.Controls.Add(this.scanFileTextBox);
            this.tabDecryptPage.Controls.Add(this.decryptCbcRadioButton);
            this.tabDecryptPage.Controls.Add(this.decryptEcbRadioButton);
            this.tabDecryptPage.Controls.Add(this.label6);
            this.tabDecryptPage.Controls.Add(this.getFileAtThisLocationButton);
            this.tabDecryptPage.Controls.Add(this.label7);
            this.tabDecryptPage.Controls.Add(this.label8);
            this.tabDecryptPage.Controls.Add(this.label9);
            this.tabDecryptPage.Controls.Add(this.label10);
            this.tabDecryptPage.Controls.Add(this.decryptKeyTextBox);
            this.tabDecryptPage.Controls.Add(this.decryptThisTextBox);
            this.tabDecryptPage.Controls.Add(this.decryptButton);
            this.tabDecryptPage.Controls.Add(this.button2);
            this.tabDecryptPage.Location = new System.Drawing.Point(4, 22);
            this.tabDecryptPage.Name = "tabDecryptPage";
            this.tabDecryptPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabDecryptPage.Size = new System.Drawing.Size(1112, 596);
            this.tabDecryptPage.TabIndex = 1;
            this.tabDecryptPage.Text = "Dešifravimas";
            // 
            // scanFileTextBox
            // 
            this.scanFileTextBox.Location = new System.Drawing.Point(243, 111);
            this.scanFileTextBox.Name = "scanFileTextBox";
            this.scanFileTextBox.Size = new System.Drawing.Size(403, 21);
            this.scanFileTextBox.TabIndex = 23;
            this.scanFileTextBox.Text = "";
            // 
            // decryptCbcRadioButton
            // 
            this.decryptCbcRadioButton.AutoSize = true;
            this.decryptCbcRadioButton.Location = new System.Drawing.Point(336, 459);
            this.decryptCbcRadioButton.Name = "decryptCbcRadioButton";
            this.decryptCbcRadioButton.Size = new System.Drawing.Size(46, 17);
            this.decryptCbcRadioButton.TabIndex = 22;
            this.decryptCbcRadioButton.TabStop = true;
            this.decryptCbcRadioButton.Text = "CBC";
            this.decryptCbcRadioButton.UseVisualStyleBackColor = true;
            // 
            // decryptEcbRadioButton
            // 
            this.decryptEcbRadioButton.AutoSize = true;
            this.decryptEcbRadioButton.Location = new System.Drawing.Point(284, 459);
            this.decryptEcbRadioButton.Name = "decryptEcbRadioButton";
            this.decryptEcbRadioButton.Size = new System.Drawing.Size(46, 17);
            this.decryptEcbRadioButton.TabIndex = 21;
            this.decryptEcbRadioButton.TabStop = true;
            this.decryptEcbRadioButton.Text = "ECB";
            this.decryptEcbRadioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Pasirinkite dešifravimo modą:";
            // 
            // getFileAtThisLocationButton
            // 
            this.getFileAtThisLocationButton.Location = new System.Drawing.Point(652, 109);
            this.getFileAtThisLocationButton.Name = "getFileAtThisLocationButton";
            this.getFileAtThisLocationButton.Size = new System.Drawing.Size(24, 23);
            this.getFileAtThisLocationButton.TabIndex = 19;
            this.getFileAtThisLocationButton.Text = "...";
            this.getFileAtThisLocationButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nuskaityti tekstą iš failo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(240, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Norimas dešifruoti tekstas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Raktas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(265, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 42);
            this.label10.TabIndex = 15;
            this.label10.Text = "Dešifruoti";
            // 
            // decryptKeyTextBox
            // 
            this.decryptKeyTextBox.Location = new System.Drawing.Point(134, 77);
            this.decryptKeyTextBox.Name = "decryptKeyTextBox";
            this.decryptKeyTextBox.Size = new System.Drawing.Size(321, 21);
            this.decryptKeyTextBox.TabIndex = 14;
            this.decryptKeyTextBox.Text = "";
            // 
            // decryptThisTextBox
            // 
            this.decryptThisTextBox.Location = new System.Drawing.Point(56, 164);
            this.decryptThisTextBox.Name = "decryptThisTextBox";
            this.decryptThisTextBox.Size = new System.Drawing.Size(594, 272);
            this.decryptThisTextBox.TabIndex = 13;
            this.decryptThisTextBox.Text = "";
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(289, 533);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 12;
            this.decryptButton.Text = "Dešifruoti";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(954, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(752, 593);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabEncryptPage.ResumeLayout(false);
            this.tabEncryptPage.PerformLayout();
            this.tabDecryptPage.ResumeLayout(false);
            this.tabDecryptPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabEncryptPage;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TabPage tabDecryptPage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox encryptKeyTextBox;
        private System.Windows.Forms.RichTextBox encryptThisTextBox;
        private System.Windows.Forms.Button saveAtThisLocationButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton cbcEncryptRadioButton;
        private System.Windows.Forms.RadioButton ecbEncryptRadioButton;
        private System.Windows.Forms.RadioButton decryptCbcRadioButton;
        private System.Windows.Forms.RadioButton decryptEcbRadioButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button getFileAtThisLocationButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox decryptKeyTextBox;
        private System.Windows.Forms.RichTextBox decryptThisTextBox;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.RichTextBox saveLocationTextBox;
        private System.Windows.Forms.RichTextBox scanFileTextBox;
    }
}

