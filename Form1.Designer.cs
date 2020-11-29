namespace Mail
{
    partial class frmGlavna
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
            this.BtnSalji = new System.Windows.Forms.Button();
            this.txtBrojMailova = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUcitajAcc = new System.Windows.Forms.TextBox();
            this.BtnUcitajListu = new System.Windows.Forms.Button();
            this.txtUcitajLozinku = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstUcitajListu = new System.Windows.Forms.ListBox();
            this.txtPoruka = new System.Windows.Forms.RichTextBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnUcitajSliku = new System.Windows.Forms.Button();
            this.lstOdradeno = new System.Windows.Forms.ListView();
            this.clmnMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSalji
            // 
            this.BtnSalji.Location = new System.Drawing.Point(800, 280);
            this.BtnSalji.Name = "BtnSalji";
            this.BtnSalji.Size = new System.Drawing.Size(203, 49);
            this.BtnSalji.TabIndex = 0;
            this.BtnSalji.Text = "Pocni";
            this.BtnSalji.UseVisualStyleBackColor = true;
            this.BtnSalji.Click += new System.EventHandler(this.BtnSalji_Click);
            // 
            // txtBrojMailova
            // 
            this.txtBrojMailova.Location = new System.Drawing.Point(784, 231);
            this.txtBrojMailova.Name = "txtBrojMailova";
            this.txtBrojMailova.Size = new System.Drawing.Size(233, 20);
            this.txtBrojMailova.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(848, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Koliko mailova (1-1000)";
            // 
            // txtUcitajAcc
            // 
            this.txtUcitajAcc.Location = new System.Drawing.Point(784, 120);
            this.txtUcitajAcc.Name = "txtUcitajAcc";
            this.txtUcitajAcc.Size = new System.Drawing.Size(233, 20);
            this.txtUcitajAcc.TabIndex = 4;
            // 
            // BtnUcitajListu
            // 
            this.BtnUcitajListu.Location = new System.Drawing.Point(12, 218);
            this.BtnUcitajListu.Name = "BtnUcitajListu";
            this.BtnUcitajListu.Size = new System.Drawing.Size(233, 23);
            this.BtnUcitajListu.TabIndex = 7;
            this.BtnUcitajListu.Text = "Ucitaj listu";
            this.BtnUcitajListu.UseVisualStyleBackColor = true;
            this.BtnUcitajListu.Click += new System.EventHandler(this.BtnUcitajListu_Click);
            // 
            // txtUcitajLozinku
            // 
            this.txtUcitajLozinku.Location = new System.Drawing.Point(784, 165);
            this.txtUcitajLozinku.Name = "txtUcitajLozinku";
            this.txtUcitajLozinku.PasswordChar = '*';
            this.txtUcitajLozinku.Size = new System.Drawing.Size(233, 20);
            this.txtUcitajLozinku.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(784, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(784, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lozinka:";
            // 
            // lstUcitajListu
            // 
            this.lstUcitajListu.FormattingEnabled = true;
            this.lstUcitajListu.Location = new System.Drawing.Point(12, 22);
            this.lstUcitajListu.Name = "lstUcitajListu";
            this.lstUcitajListu.Size = new System.Drawing.Size(233, 186);
            this.lstUcitajListu.TabIndex = 11;
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(310, 58);
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(409, 141);
            this.txtPoruka.TabIndex = 12;
            this.txtPoruka.Text = "";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(310, 22);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(409, 20);
            this.txtNaslov.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Naslov:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Poruka:";
            // 
            // BtnUcitajSliku
            // 
            this.BtnUcitajSliku.Location = new System.Drawing.Point(310, 218);
            this.BtnUcitajSliku.Name = "BtnUcitajSliku";
            this.BtnUcitajSliku.Size = new System.Drawing.Size(409, 23);
            this.BtnUcitajSliku.TabIndex = 16;
            this.BtnUcitajSliku.Text = "Ucitaj Sliku";
            this.BtnUcitajSliku.UseVisualStyleBackColor = true;
            this.BtnUcitajSliku.Click += new System.EventHandler(this.BtnUcitajSliku_Click);
            // 
            // lstOdradeno
            // 
            this.lstOdradeno.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnMail,
            this.clmnStatus});
            this.lstOdradeno.Location = new System.Drawing.Point(270, 278);
            this.lstOdradeno.Name = "lstOdradeno";
            this.lstOdradeno.Size = new System.Drawing.Size(486, 97);
            this.lstOdradeno.TabIndex = 17;
            this.lstOdradeno.UseCompatibleStateImageBehavior = false;
            // 
            // clmnMail
            // 
            this.clmnMail.Text = "E-Mail";
            // 
            // clmnStatus
            // 
            this.clmnStatus.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Odrađeno";
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Items.AddRange(new object[] {
            "smtp.gmail.com",
            "smtp.mail.yahoo.com"});
            this.cmbServer.Location = new System.Drawing.Point(784, 22);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(233, 21);
            this.cmbServer.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(784, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Server";
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 387);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbServer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstOdradeno);
            this.Controls.Add(this.BtnUcitajSliku);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.txtPoruka);
            this.Controls.Add(this.lstUcitajListu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUcitajLozinku);
            this.Controls.Add(this.BtnUcitajListu);
            this.Controls.Add(this.txtUcitajAcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojMailova);
            this.Controls.Add(this.BtnSalji);
            this.Name = "frmGlavna";
            this.Text = "MailSender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalji;
        private System.Windows.Forms.TextBox txtBrojMailova;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUcitajAcc;
        private System.Windows.Forms.Button BtnUcitajListu;
        private System.Windows.Forms.TextBox txtUcitajLozinku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstUcitajListu;
        private System.Windows.Forms.RichTextBox txtPoruka;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnUcitajSliku;
        private System.Windows.Forms.ListView lstOdradeno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader clmnMail;
        private System.Windows.Forms.ColumnHeader clmnStatus;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.Label label7;
    }
}

