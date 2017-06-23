namespace SteamKnockoff
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.HinzufügenButton = new System.Windows.Forms.Button();
            this.EntfernenButton = new System.Windows.Forms.Button();
            this.TitelBox = new System.Windows.Forms.TextBox();
            this.DatumBox = new System.Windows.Forms.TextBox();
            this.LetztesSpielDatumBox = new System.Windows.Forms.TextBox();
            this.InstallationspfadBox = new System.Windows.Forms.TextBox();
            this.KategorieBox = new System.Windows.Forms.TextBox();
            this.PublisherBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.USKBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.ErstellError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 316);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // HinzufügenButton
            // 
            this.HinzufügenButton.Location = new System.Drawing.Point(12, 334);
            this.HinzufügenButton.Name = "HinzufügenButton";
            this.HinzufügenButton.Size = new System.Drawing.Size(75, 23);
            this.HinzufügenButton.TabIndex = 1;
            this.HinzufügenButton.Text = "Hinzufügen";
            this.HinzufügenButton.UseVisualStyleBackColor = true;
            this.HinzufügenButton.Click += new System.EventHandler(this.HinzufügenButton_Click);
            // 
            // EntfernenButton
            // 
            this.EntfernenButton.Location = new System.Drawing.Point(158, 334);
            this.EntfernenButton.Name = "EntfernenButton";
            this.EntfernenButton.Size = new System.Drawing.Size(75, 23);
            this.EntfernenButton.TabIndex = 2;
            this.EntfernenButton.Text = "Entfernen";
            this.EntfernenButton.UseVisualStyleBackColor = true;
            this.EntfernenButton.Click += new System.EventHandler(this.EntfernenButton_Click);
            // 
            // TitelBox
            // 
            this.TitelBox.Location = new System.Drawing.Point(239, 30);
            this.TitelBox.Name = "TitelBox";
            this.TitelBox.Size = new System.Drawing.Size(100, 20);
            this.TitelBox.TabIndex = 3;
            // 
            // DatumBox
            // 
            this.DatumBox.Location = new System.Drawing.Point(239, 69);
            this.DatumBox.Name = "DatumBox";
            this.DatumBox.Size = new System.Drawing.Size(100, 20);
            this.DatumBox.TabIndex = 4;
            // 
            // LetztesSpielDatumBox
            // 
            this.LetztesSpielDatumBox.Location = new System.Drawing.Point(239, 108);
            this.LetztesSpielDatumBox.Name = "LetztesSpielDatumBox";
            this.LetztesSpielDatumBox.Size = new System.Drawing.Size(100, 20);
            this.LetztesSpielDatumBox.TabIndex = 5;
            // 
            // InstallationspfadBox
            // 
            this.InstallationspfadBox.Location = new System.Drawing.Point(239, 147);
            this.InstallationspfadBox.Name = "InstallationspfadBox";
            this.InstallationspfadBox.Size = new System.Drawing.Size(100, 20);
            this.InstallationspfadBox.TabIndex = 6;
            // 
            // KategorieBox
            // 
            this.KategorieBox.Location = new System.Drawing.Point(239, 186);
            this.KategorieBox.Name = "KategorieBox";
            this.KategorieBox.Size = new System.Drawing.Size(100, 20);
            this.KategorieBox.TabIndex = 7;
            // 
            // PublisherBox
            // 
            this.PublisherBox.Location = new System.Drawing.Point(239, 225);
            this.PublisherBox.Name = "PublisherBox";
            this.PublisherBox.Size = new System.Drawing.Size(100, 20);
            this.PublisherBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Titel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Installationsdatum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Letztes mal gespielt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Installationspfad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kategorie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Publisher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "USK";
            // 
            // USKBox
            // 
            this.USKBox.Location = new System.Drawing.Point(239, 264);
            this.USKBox.Name = "USKBox";
            this.USKBox.Size = new System.Drawing.Size(100, 20);
            this.USKBox.TabIndex = 16;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(360, 27);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 17;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(360, 69);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 18;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ErstellError
            // 
            this.ErstellError.AutoSize = true;
            this.ErstellError.Location = new System.Drawing.Point(360, 99);
            this.ErstellError.Name = "ErstellError";
            this.ErstellError.Size = new System.Drawing.Size(231, 13);
            this.ErstellError.TabIndex = 19;
            this.ErstellError.Text = "Spiel existiert nicht oder falsches Eingabeformat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 445);
            this.Controls.Add(this.ErstellError);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.USKBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PublisherBox);
            this.Controls.Add(this.KategorieBox);
            this.Controls.Add(this.InstallationspfadBox);
            this.Controls.Add(this.LetztesSpielDatumBox);
            this.Controls.Add(this.DatumBox);
            this.Controls.Add(this.TitelBox);
            this.Controls.Add(this.EntfernenButton);
            this.Controls.Add(this.HinzufügenButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button HinzufügenButton;
        private System.Windows.Forms.Button EntfernenButton;
        private System.Windows.Forms.TextBox TitelBox;
        private System.Windows.Forms.TextBox DatumBox;
        private System.Windows.Forms.TextBox LetztesSpielDatumBox;
        private System.Windows.Forms.TextBox InstallationspfadBox;
        private System.Windows.Forms.TextBox KategorieBox;
        private System.Windows.Forms.TextBox PublisherBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox USKBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label ErstellError;
    }
}

