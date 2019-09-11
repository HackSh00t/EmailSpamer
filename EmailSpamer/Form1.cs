using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace EmailSpamer
{
    public partial class Form1 : Form
    {
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtemail.Enabled = false;
                txtpassword.Enabled = false;
            }
            else
            {
                txtemail.Enabled = true;
                txtpassword.Enabled = true;
            }
        }
        public Form1()
        {
            InitializeComponent();
            spam.Text = "0";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtattachment.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail acount
                MailMessage message = new MailMessage(); //New object
                
                message.To.Add(txtreciver.Text); //Recivers Email Id
                message.Body = txtbody.Text; //Body
                message.Subject = txtsubject.Text; //Subject
                client.UseDefaultCredentials = false;
                client.EnableSsl = true; //enabeling ssl security

                if(txtattachment.Text != "") //cheking attachment
                {
                    message.Attachments.Add(new Attachment(txtattachment.Text));
                }

                if(checkBox1.Checked == true)
                {
                    client.Credentials = new System.Net.NetworkCredential("em4il.sp4mer@gmail.com", "Email_Sp@mer1234"); //login CCredentials
                    message.From = new MailAddress("em4il.sp4mer@gmail.com"); //Email Idd
                }
                else
                {
                    client.Credentials = new System.Net.NetworkCredential(txtemail.Text, txtpassword.Text); //login CCredentials
                    message.From = new MailAddress(txtemail.Text); //Email Idd
                }

                int spm = 0;
                Decimal Spam = spam.Value;
                Decimal Delay = delay.Value;

                if (txtreciver2.Text != "")
                {
                    message.To.Add(txtreciver2.Text);
                }

                if (txtreciver3.Text != "")
                {
                    message.To.Add(txtreciver3.Text);
                }

                if (txtreciver4.Text != "")
                {
                    message.To.Add(txtreciver4.Text);
                }

                if (txtreciver5.Text != "")
                {
                    message.To.Add(txtreciver5.Text);
                }

                if (txtreciver6.Text != "")
                {
                    message.To.Add(txtreciver6.Text);
                }

                while (spm != Spam)
                {
                    client.Send(message); //Sending

                    int spmNum = (int)Spam - spm;
                    lblLeft.Text = spmNum.ToString();
                    System.Threading.Thread.Sleep((int)Delay);
                    
                    spm = spm + 1;
                }
                spm = 0;
                lblLeft.Text = "0";

                message = null; //freeing the memory of message

                MessageBox.Show("Message Sended");
            }

            catch(Exception s)
            {
                MessageBox.Show("Fail");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
