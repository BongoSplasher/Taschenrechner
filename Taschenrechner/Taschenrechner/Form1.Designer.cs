namespace Taschenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.rechnerTextBox = new System.Windows.Forms.RichTextBox();
            this.einLöschenButton = new System.Windows.Forms.Button();
            this.löschenVorherButton = new System.Windows.Forms.Button();
            this.allesLöschenButton = new System.Windows.Forms.Button();
            this.vorzeichenÄndernButton = new System.Windows.Forms.Button();
            this.buttonSieben = new System.Windows.Forms.Button();
            this.buttonAcht = new System.Windows.Forms.Button();
            this.buttonNeun = new System.Windows.Forms.Button();
            this.buttonMultiplikation = new System.Windows.Forms.Button();
            this.buttonVier = new System.Windows.Forms.Button();
            this.wurzelButton = new System.Windows.Forms.Button();
            this.buttonPotenz = new System.Windows.Forms.Button();
            this.buttonFünf = new System.Windows.Forms.Button();
            this.buttonSechs = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonEins = new System.Windows.Forms.Button();
            this.buttonZwei = new System.Windows.Forms.Button();
            this.buttonDrei = new System.Windows.Forms.Button();
            this.buttonSubtraktion = new System.Windows.Forms.Button();
            this.buttonNull = new System.Windows.Forms.Button();
            this.buttonPunkt = new System.Windows.Forms.Button();
            this.buttonKomma = new System.Windows.Forms.Button();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.buttonGleich = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rechnerTextBox
            // 
            this.rechnerTextBox.Location = new System.Drawing.Point(12, 12);
            this.rechnerTextBox.Name = "rechnerTextBox";
            this.rechnerTextBox.Size = new System.Drawing.Size(264, 46);
            this.rechnerTextBox.TabIndex = 1;
            this.rechnerTextBox.Text = "";
            this.rechnerTextBox.TextChanged += new System.EventHandler(this.rechnerTextBox_TextChanged);
            // 
            // einLöschenButton
            // 
            this.einLöschenButton.Location = new System.Drawing.Point(12, 64);
            this.einLöschenButton.Name = "einLöschenButton";
            this.einLöschenButton.Size = new System.Drawing.Size(48, 28);
            this.einLöschenButton.TabIndex = 2;
            this.einLöschenButton.Text = "<---";
            this.einLöschenButton.UseVisualStyleBackColor = true;
            // 
            // löschenVorherButton
            // 
            this.löschenVorherButton.Location = new System.Drawing.Point(66, 64);
            this.löschenVorherButton.Name = "löschenVorherButton";
            this.löschenVorherButton.Size = new System.Drawing.Size(48, 28);
            this.löschenVorherButton.TabIndex = 3;
            this.löschenVorherButton.Text = "CE";
            this.löschenVorherButton.UseVisualStyleBackColor = true;
            // 
            // allesLöschenButton
            // 
            this.allesLöschenButton.Location = new System.Drawing.Point(120, 64);
            this.allesLöschenButton.Name = "allesLöschenButton";
            this.allesLöschenButton.Size = new System.Drawing.Size(48, 28);
            this.allesLöschenButton.TabIndex = 4;
            this.allesLöschenButton.Text = "C";
            this.allesLöschenButton.UseVisualStyleBackColor = true;
            // 
            // vorzeichenÄndernButton
            // 
            this.vorzeichenÄndernButton.Location = new System.Drawing.Point(174, 64);
            this.vorzeichenÄndernButton.Name = "vorzeichenÄndernButton";
            this.vorzeichenÄndernButton.Size = new System.Drawing.Size(48, 28);
            this.vorzeichenÄndernButton.TabIndex = 5;
            this.vorzeichenÄndernButton.Text = "+/-";
            this.vorzeichenÄndernButton.UseVisualStyleBackColor = true;
            this.vorzeichenÄndernButton.Click += new System.EventHandler(this.buttonVier_Click);
            // 
            // buttonSieben
            // 
            this.buttonSieben.Location = new System.Drawing.Point(12, 107);
            this.buttonSieben.Name = "buttonSieben";
            this.buttonSieben.Size = new System.Drawing.Size(48, 28);
            this.buttonSieben.TabIndex = 6;
            this.buttonSieben.Text = "7";
            this.buttonSieben.UseVisualStyleBackColor = true;
            // 
            // buttonAcht
            // 
            this.buttonAcht.Location = new System.Drawing.Point(66, 107);
            this.buttonAcht.Name = "buttonAcht";
            this.buttonAcht.Size = new System.Drawing.Size(48, 28);
            this.buttonAcht.TabIndex = 7;
            this.buttonAcht.Text = "8";
            this.buttonAcht.UseVisualStyleBackColor = true;
            // 
            // buttonNeun
            // 
            this.buttonNeun.Location = new System.Drawing.Point(120, 107);
            this.buttonNeun.Name = "buttonNeun";
            this.buttonNeun.Size = new System.Drawing.Size(48, 28);
            this.buttonNeun.TabIndex = 8;
            this.buttonNeun.Text = "9";
            this.buttonNeun.UseVisualStyleBackColor = true;
            // 
            // buttonMultiplikation
            // 
            this.buttonMultiplikation.Location = new System.Drawing.Point(174, 107);
            this.buttonMultiplikation.Name = "buttonMultiplikation";
            this.buttonMultiplikation.Size = new System.Drawing.Size(48, 28);
            this.buttonMultiplikation.TabIndex = 9;
            this.buttonMultiplikation.Text = "*";
            this.buttonMultiplikation.UseVisualStyleBackColor = true;
            // 
            // buttonVier
            // 
            this.buttonVier.Location = new System.Drawing.Point(12, 141);
            this.buttonVier.Name = "buttonVier";
            this.buttonVier.Size = new System.Drawing.Size(48, 28);
            this.buttonVier.TabIndex = 10;
            this.buttonVier.Text = "4";
            this.buttonVier.UseVisualStyleBackColor = true;
            this.buttonVier.Click += new System.EventHandler(this.buttonVier_Click);
            // 
            // wurzelButton
            // 
            this.wurzelButton.Location = new System.Drawing.Point(174, 175);
            this.wurzelButton.Name = "wurzelButton";
            this.wurzelButton.Size = new System.Drawing.Size(48, 28);
            this.wurzelButton.TabIndex = 11;
            this.wurzelButton.Text = "sqrt";
            this.wurzelButton.UseVisualStyleBackColor = true;
            // 
            // buttonPotenz
            // 
            this.buttonPotenz.Location = new System.Drawing.Point(227, 64);
            this.buttonPotenz.Name = "buttonPotenz";
            this.buttonPotenz.Size = new System.Drawing.Size(48, 28);
            this.buttonPotenz.TabIndex = 12;
            this.buttonPotenz.Text = "x²";
            this.buttonPotenz.UseVisualStyleBackColor = true;
            // 
            // buttonFünf
            // 
            this.buttonFünf.Location = new System.Drawing.Point(66, 141);
            this.buttonFünf.Name = "buttonFünf";
            this.buttonFünf.Size = new System.Drawing.Size(48, 28);
            this.buttonFünf.TabIndex = 14;
            this.buttonFünf.Text = "5";
            this.buttonFünf.UseVisualStyleBackColor = true;
            // 
            // buttonSechs
            // 
            this.buttonSechs.Location = new System.Drawing.Point(120, 142);
            this.buttonSechs.Name = "buttonSechs";
            this.buttonSechs.Size = new System.Drawing.Size(48, 28);
            this.buttonSechs.TabIndex = 15;
            this.buttonSechs.Text = "6";
            this.buttonSechs.UseVisualStyleBackColor = true;
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(174, 142);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(48, 28);
            this.buttonDivision.TabIndex = 16;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            // 
            // buttonEins
            // 
            this.buttonEins.Location = new System.Drawing.Point(12, 175);
            this.buttonEins.Name = "buttonEins";
            this.buttonEins.Size = new System.Drawing.Size(48, 28);
            this.buttonEins.TabIndex = 17;
            this.buttonEins.Text = "1";
            this.buttonEins.UseVisualStyleBackColor = true;
            // 
            // buttonZwei
            // 
            this.buttonZwei.Location = new System.Drawing.Point(66, 175);
            this.buttonZwei.Name = "buttonZwei";
            this.buttonZwei.Size = new System.Drawing.Size(48, 28);
            this.buttonZwei.TabIndex = 18;
            this.buttonZwei.Text = "2";
            this.buttonZwei.UseVisualStyleBackColor = true;
            this.buttonZwei.Click += new System.EventHandler(this.buttonZwei_Click);
            // 
            // buttonDrei
            // 
            this.buttonDrei.Location = new System.Drawing.Point(120, 176);
            this.buttonDrei.Name = "buttonDrei";
            this.buttonDrei.Size = new System.Drawing.Size(48, 28);
            this.buttonDrei.TabIndex = 19;
            this.buttonDrei.Text = "3";
            this.buttonDrei.UseVisualStyleBackColor = true;
            // 
            // buttonSubtraktion
            // 
            this.buttonSubtraktion.Location = new System.Drawing.Point(228, 107);
            this.buttonSubtraktion.Name = "buttonSubtraktion";
            this.buttonSubtraktion.Size = new System.Drawing.Size(48, 28);
            this.buttonSubtraktion.TabIndex = 20;
            this.buttonSubtraktion.Text = "-";
            this.buttonSubtraktion.UseVisualStyleBackColor = true;
            // 
            // buttonNull
            // 
            this.buttonNull.Location = new System.Drawing.Point(12, 209);
            this.buttonNull.Name = "buttonNull";
            this.buttonNull.Size = new System.Drawing.Size(102, 28);
            this.buttonNull.TabIndex = 22;
            this.buttonNull.Text = "0";
            this.buttonNull.UseVisualStyleBackColor = true;
            // 
            // buttonPunkt
            // 
            this.buttonPunkt.Location = new System.Drawing.Point(174, 209);
            this.buttonPunkt.Name = "buttonPunkt";
            this.buttonPunkt.Size = new System.Drawing.Size(48, 28);
            this.buttonPunkt.TabIndex = 23;
            this.buttonPunkt.Text = ".";
            this.buttonPunkt.UseVisualStyleBackColor = true;
            // 
            // buttonKomma
            // 
            this.buttonKomma.Location = new System.Drawing.Point(120, 210);
            this.buttonKomma.Name = "buttonKomma";
            this.buttonKomma.Size = new System.Drawing.Size(48, 28);
            this.buttonKomma.TabIndex = 24;
            this.buttonKomma.Text = ",";
            this.buttonKomma.UseVisualStyleBackColor = true;
            // 
            // buttonAddition
            // 
            this.buttonAddition.Location = new System.Drawing.Point(228, 141);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(48, 28);
            this.buttonAddition.TabIndex = 25;
            this.buttonAddition.Text = "+";
            this.buttonAddition.UseVisualStyleBackColor = true;
            // 
            // buttonGleich
            // 
            this.buttonGleich.Location = new System.Drawing.Point(227, 176);
            this.buttonGleich.Name = "buttonGleich";
            this.buttonGleich.Size = new System.Drawing.Size(48, 61);
            this.buttonGleich.TabIndex = 26;
            this.buttonGleich.Text = "=";
            this.buttonGleich.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 252);
            this.Controls.Add(this.buttonGleich);
            this.Controls.Add(this.buttonAddition);
            this.Controls.Add(this.buttonKomma);
            this.Controls.Add(this.buttonPunkt);
            this.Controls.Add(this.buttonNull);
            this.Controls.Add(this.buttonSubtraktion);
            this.Controls.Add(this.buttonDrei);
            this.Controls.Add(this.buttonZwei);
            this.Controls.Add(this.buttonEins);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonSechs);
            this.Controls.Add(this.buttonFünf);
            this.Controls.Add(this.buttonPotenz);
            this.Controls.Add(this.wurzelButton);
            this.Controls.Add(this.buttonVier);
            this.Controls.Add(this.buttonMultiplikation);
            this.Controls.Add(this.buttonNeun);
            this.Controls.Add(this.buttonAcht);
            this.Controls.Add(this.buttonSieben);
            this.Controls.Add(this.vorzeichenÄndernButton);
            this.Controls.Add(this.allesLöschenButton);
            this.Controls.Add(this.löschenVorherButton);
            this.Controls.Add(this.einLöschenButton);
            this.Controls.Add(this.rechnerTextBox);
            this.Name = "Form1";
            this.Text = "Rechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rechnerTextBox;
        private System.Windows.Forms.Button einLöschenButton;
        private System.Windows.Forms.Button löschenVorherButton;
        private System.Windows.Forms.Button allesLöschenButton;
        private System.Windows.Forms.Button vorzeichenÄndernButton;
        private System.Windows.Forms.Button buttonSieben;
        private System.Windows.Forms.Button buttonAcht;
        private System.Windows.Forms.Button buttonNeun;
        private System.Windows.Forms.Button buttonMultiplikation;
        private System.Windows.Forms.Button buttonVier;
        private System.Windows.Forms.Button wurzelButton;
        private System.Windows.Forms.Button buttonPotenz;
        private System.Windows.Forms.Button buttonFünf;
        private System.Windows.Forms.Button buttonSechs;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonEins;
        private System.Windows.Forms.Button buttonZwei;
        private System.Windows.Forms.Button buttonDrei;
        private System.Windows.Forms.Button buttonSubtraktion;
        private System.Windows.Forms.Button buttonNull;
        private System.Windows.Forms.Button buttonPunkt;
        private System.Windows.Forms.Button buttonKomma;
        private System.Windows.Forms.Button buttonAddition;
        private System.Windows.Forms.Button buttonGleich;
    }
}

