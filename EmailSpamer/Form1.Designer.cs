namespace EmailSpamer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.IbkEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtreciver = new System.Windows.Forms.TextBox();
            this.txtattachment = new System.Windows.Forms.TextBox();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.txtbody = new System.Windows.Forms.TextBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.spam = new System.Windows.Forms.NumericUpDown();
            this.txtreciver2 = new System.Windows.Forms.TextBox();
            this.txtreciver3 = new System.Windows.Forms.TextBox();
            this.txtreciver4 = new System.Windows.Forms.TextBox();
            this.txtreciver5 = new System.Windows.Forms.TextBox();
            this.txtreciver6 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spam)).BeginInit();
            this.SuspendLayout();
            // 
            // IbkEmail
            // 
            this.IbkEmail.AutoSize = true;
            this.IbkEmail.Location = new System.Drawing.Point(6, 9);
            this.IbkEmail.Name = "IbkEmail";
            this.IbkEmail.Size = new System.Drawing.Size(57, 13);
            this.IbkEmail.TabIndex = 0;
            this.IbkEmail.Text = "Your Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recivers Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Body";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add Attachment";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(75, 6);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(332, 20);
            this.txtemail.TabIndex = 7;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(497, 6);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(291, 20);
            this.txtpassword.TabIndex = 8;
            // 
            // txtreciver
            // 
            this.txtreciver.Location = new System.Drawing.Point(101, 72);
            this.txtreciver.Name = "txtreciver";
            this.txtreciver.Size = new System.Drawing.Size(340, 20);
            this.txtreciver.TabIndex = 9;
            // 
            // txtattachment
            // 
            this.txtattachment.Enabled = false;
            this.txtattachment.Location = new System.Drawing.Point(101, 183);
            this.txtattachment.Name = "txtattachment";
            this.txtattachment.Size = new System.Drawing.Size(606, 20);
            this.txtattachment.TabIndex = 10;
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(101, 217);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(687, 20);
            this.txtsubject.TabIndex = 11;
            // 
            // txtbody
            // 
            this.txtbody.Location = new System.Drawing.Point(101, 273);
            this.txtbody.Multiline = true;
            this.txtbody.Name = "txtbody";
            this.txtbody.Size = new System.Drawing.Size(687, 102);
            this.txtbody.TabIndex = 12;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(713, 181);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 23);
            this.btnbrowse.TabIndex = 13;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(630, 400);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(158, 23);
            this.btnsend.TabIndex = 14;
            this.btnsend.Text = "Send Email";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sending Emails";
            // 
            // spam
            // 
            this.spam.AllowDrop = true;
            this.spam.Cursor = System.Windows.Forms.Cursors.Cross;
            this.spam.Location = new System.Drawing.Point(101, 403);
            this.spam.Name = "spam";
            this.spam.Size = new System.Drawing.Size(460, 20);
            this.spam.TabIndex = 17;
            this.spam.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtreciver2
            // 
            this.txtreciver2.Location = new System.Drawing.Point(448, 72);
            this.txtreciver2.Name = "txtreciver2";
            this.txtreciver2.Size = new System.Drawing.Size(340, 20);
            this.txtreciver2.TabIndex = 18;
            // 
            // txtreciver3
            // 
            this.txtreciver3.Location = new System.Drawing.Point(101, 98);
            this.txtreciver3.Name = "txtreciver3";
            this.txtreciver3.Size = new System.Drawing.Size(340, 20);
            this.txtreciver3.TabIndex = 19;
            // 
            // txtreciver4
            // 
            this.txtreciver4.Location = new System.Drawing.Point(448, 98);
            this.txtreciver4.Name = "txtreciver4";
            this.txtreciver4.Size = new System.Drawing.Size(340, 20);
            this.txtreciver4.TabIndex = 20;
            // 
            // txtreciver5
            // 
            this.txtreciver5.Location = new System.Drawing.Point(101, 124);
            this.txtreciver5.Name = "txtreciver5";
            this.txtreciver5.Size = new System.Drawing.Size(340, 20);
            this.txtreciver5.TabIndex = 21;
            // 
            // txtreciver6
            // 
            this.txtreciver6.Location = new System.Drawing.Point(448, 124);
            this.txtreciver6.Name = "txtreciver6";
            this.txtreciver6.Size = new System.Drawing.Size(340, 20);
            this.txtreciver6.TabIndex = 22;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(75, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Use Default Credentials";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(567, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Emails left";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtreciver6);
            this.Controls.Add(this.txtreciver5);
            this.Controls.Add(this.txtreciver4);
            this.Controls.Add(this.txtreciver3);
            this.Controls.Add(this.txtreciver2);
            this.Controls.Add(this.spam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.txtbody);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.txtattachment);
            this.Controls.Add(this.txtreciver);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IbkEmail);
            this.Name = "Form1";
            this.Text = "EmailSpamer";
            ((System.ComponentModel.ISupportInitialize)(this.spam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IbkEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtreciver;
        private System.Windows.Forms.TextBox txtattachment;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.TextBox txtbody;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown spam;
        private System.Windows.Forms.TextBox txtreciver2;
        private System.Windows.Forms.TextBox txtreciver3;
        private System.Windows.Forms.TextBox txtreciver4;
        private System.Windows.Forms.TextBox txtreciver5;
        private System.Windows.Forms.TextBox txtreciver6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
    }
}

