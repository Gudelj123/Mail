using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;

namespace Mail
{
    public partial class frmGlavna : Form
    {
        public string Slika;
        public frmGlavna()
        {
            InitializeComponent();

        }

        public void BtnSalji_Click(object sender, EventArgs e)
        {

            int i, c;
            string Kome, Server;
            string n = txtBrojMailova.Text;
            //UNOS PONAVLJANJA
            int.TryParse(n, out c);
            if (Slika != null) {
                Server = cmbServer.Text;
                for (i = 0; i < c; i++)
                {
                    
                        //UCITAVANJE PORUKE I CILJANE ADRESE
                        MailMessage NoviMail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient();
                        NoviMail.From =new MailAddress(txtUcitajAcc.Text);
                        lstUcitajListu.SelectedIndex = 0;
                        Kome = (Convert.ToString(lstUcitajListu.SelectedItem));
                        NoviMail.Bcc.Add(Kome);
                        NoviMail.Subject = txtNaslov.Text;
                        NoviMail.Body = txtPoruka.Text;
                        System.Net.Mail.Attachment attachment;
                        attachment = new System.Net.Mail.Attachment(Slika);
                        NoviMail.Attachments.Add(attachment);
                        //PODATCI SERVERA
                        SmtpServer.EnableSsl = true;
                        SmtpServer.Port = 587;
                        SmtpServer.Host = Server;
                        SmtpServer.UseDefaultCredentials = false;
                        SmtpServer.Credentials = new System.Net.NetworkCredential(txtUcitajAcc.Text, txtUcitajLozinku.Text);
                    try{
                        SmtpServer.Send(NoviMail);
                        string[] red = { Kome, "Odradeno" };
                        var listViewItem = new ListViewItem(red);
                        lstOdradeno.Items.Add(listViewItem);
                        //UKLANJANJE PRVOG (POSLANOG) MAILA IZ LISTE
                        lstUcitajListu.Items.Remove(lstUcitajListu.SelectedItem);
                        SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        public void BtnUcitajListu_Click(object sender, EventArgs e)
        {
            //UCITAVANJE LISTE
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                lstUcitajListu.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        lstUcitajListu.Items.Add(line);

                    }
                }
            }
        }

        public void BtnUcitajSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog otvorisliku = new OpenFileDialog();
            DialogResult DR = otvorisliku.ShowDialog();
            if(DR== System.Windows.Forms.DialogResult.OK)
            {
                Slika = otvorisliku.FileName;
            }
            
        }
    }
}
