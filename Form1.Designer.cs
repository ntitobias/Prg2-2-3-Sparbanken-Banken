namespace Prg2_2_3_Sparbanken_Banken
{
    partial class frmBank
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxÖppnaKontoPersonNr = new System.Windows.Forms.TextBox();
            this.tbxÖppnaKontoRäntesats = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxÖppnaKontoKredit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnÖppnaKontoRegistrera = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUttag = new System.Windows.Forms.Button();
            this.tbxBelopp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsättning = new System.Windows.Forms.Button();
            this.lbxKonton = new System.Windows.Forms.ListBox();
            this.btnUppdateraMedÅrsränta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnÖppnaKontoRegistrera);
            this.groupBox1.Controls.Add(this.tbxÖppnaKontoKredit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxÖppnaKontoRäntesats);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxÖppnaKontoPersonNr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(204, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öppna konto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PersonNr";
            // 
            // tbxÖppnaKontoPersonNr
            // 
            this.tbxÖppnaKontoPersonNr.Location = new System.Drawing.Point(75, 17);
            this.tbxÖppnaKontoPersonNr.Name = "tbxÖppnaKontoPersonNr";
            this.tbxÖppnaKontoPersonNr.Size = new System.Drawing.Size(100, 20);
            this.tbxÖppnaKontoPersonNr.TabIndex = 1;
            // 
            // tbxÖppnaKontoRäntesats
            // 
            this.tbxÖppnaKontoRäntesats.Location = new System.Drawing.Point(75, 43);
            this.tbxÖppnaKontoRäntesats.Name = "tbxÖppnaKontoRäntesats";
            this.tbxÖppnaKontoRäntesats.Size = new System.Drawing.Size(100, 20);
            this.tbxÖppnaKontoRäntesats.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Räntesats";
            // 
            // tbxÖppnaKontoKredit
            // 
            this.tbxÖppnaKontoKredit.Location = new System.Drawing.Point(75, 69);
            this.tbxÖppnaKontoKredit.Name = "tbxÖppnaKontoKredit";
            this.tbxÖppnaKontoKredit.Size = new System.Drawing.Size(100, 20);
            this.tbxÖppnaKontoKredit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kredit";
            // 
            // btnÖppnaKontoRegistrera
            // 
            this.btnÖppnaKontoRegistrera.Location = new System.Drawing.Point(100, 109);
            this.btnÖppnaKontoRegistrera.Name = "btnÖppnaKontoRegistrera";
            this.btnÖppnaKontoRegistrera.Size = new System.Drawing.Size(75, 23);
            this.btnÖppnaKontoRegistrera.TabIndex = 6;
            this.btnÖppnaKontoRegistrera.Text = "Registrera";
            this.btnÖppnaKontoRegistrera.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInsättning);
            this.groupBox2.Controls.Add(this.btnUttag);
            this.groupBox2.Controls.Add(this.tbxBelopp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 145);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insättning/Uttag";
            // 
            // btnUttag
            // 
            this.btnUttag.Location = new System.Drawing.Point(100, 109);
            this.btnUttag.Name = "btnUttag";
            this.btnUttag.Size = new System.Drawing.Size(75, 23);
            this.btnUttag.TabIndex = 6;
            this.btnUttag.Text = "Uttag";
            this.btnUttag.UseVisualStyleBackColor = true;
            // 
            // tbxBelopp
            // 
            this.tbxBelopp.Location = new System.Drawing.Point(75, 17);
            this.tbxBelopp.Name = "tbxBelopp";
            this.tbxBelopp.Size = new System.Drawing.Size(100, 20);
            this.tbxBelopp.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Belopp";
            // 
            // btnInsättning
            // 
            this.btnInsättning.Location = new System.Drawing.Point(100, 80);
            this.btnInsättning.Name = "btnInsättning";
            this.btnInsättning.Size = new System.Drawing.Size(75, 23);
            this.btnInsättning.TabIndex = 7;
            this.btnInsättning.Text = "Insättning";
            this.btnInsättning.UseVisualStyleBackColor = true;
            // 
            // lbxKonton
            // 
            this.lbxKonton.FormattingEnabled = true;
            this.lbxKonton.Location = new System.Drawing.Point(407, 13);
            this.lbxKonton.Name = "lbxKonton";
            this.lbxKonton.Size = new System.Drawing.Size(226, 95);
            this.lbxKonton.TabIndex = 8;
            // 
            // btnUppdateraMedÅrsränta
            // 
            this.btnUppdateraMedÅrsränta.Location = new System.Drawing.Point(407, 122);
            this.btnUppdateraMedÅrsränta.Name = "btnUppdateraMedÅrsränta";
            this.btnUppdateraMedÅrsränta.Size = new System.Drawing.Size(226, 23);
            this.btnUppdateraMedÅrsränta.TabIndex = 9;
            this.btnUppdateraMedÅrsränta.Text = "Uppdatera med årsränta";
            this.btnUppdateraMedÅrsränta.UseVisualStyleBackColor = true;
            // 
            // frmBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 166);
            this.Controls.Add(this.btnUppdateraMedÅrsränta);
            this.Controls.Add(this.lbxKonton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBank";
            this.Text = "Banken";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnÖppnaKontoRegistrera;
        private System.Windows.Forms.TextBox tbxÖppnaKontoKredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxÖppnaKontoRäntesats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxÖppnaKontoPersonNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInsättning;
        private System.Windows.Forms.Button btnUttag;
        private System.Windows.Forms.TextBox tbxBelopp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbxKonton;
        private System.Windows.Forms.Button btnUppdateraMedÅrsränta;
    }
}

