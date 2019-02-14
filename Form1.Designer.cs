namespace tvspam
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
            this.txtPage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.txtmessagecount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotalmessagecount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSendingAccount = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnimportfile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsendinguser2 = new System.Windows.Forms.TextBox();
            this.btnstart2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnstop2 = new System.Windows.Forms.Button();
            this.txtText2 = new System.Windows.Forms.TextBox();
            this.txtsentcount2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txttotalsent2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(232, 23);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(245, 20);
            this.txtPage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "send messages to the followers of:";
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(92, 222);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(150, 23);
            this.btnstart.TabIndex = 3;
            this.btnstart.Text = "Start Sending";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(289, 222);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(150, 23);
            this.btnstop.TabIndex = 4;
            this.btnstop.Text = "Stop Sending";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // txtmessagecount
            // 
            this.txtmessagecount.Enabled = false;
            this.txtmessagecount.Location = new System.Drawing.Point(185, 273);
            this.txtmessagecount.Name = "txtmessagecount";
            this.txtmessagecount.Size = new System.Drawing.Size(142, 20);
            this.txtmessagecount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "sent messages count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "total messages sent:";
            // 
            // txttotalmessagecount
            // 
            this.txttotalmessagecount.Enabled = false;
            this.txttotalmessagecount.Location = new System.Drawing.Point(185, 308);
            this.txttotalmessagecount.Name = "txttotalmessagecount";
            this.txttotalmessagecount.Size = new System.Drawing.Size(142, 20);
            this.txttotalmessagecount.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "TEXT:";
            // 
            // txttext
            // 
            this.txttext.Location = new System.Drawing.Point(84, 109);
            this.txttext.Multiline = true;
            this.txttext.Name = "txttext";
            this.txttext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txttext.Size = new System.Drawing.Size(400, 86);
            this.txttext.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sending message by:";
            // 
            // txtSendingAccount
            // 
            this.txtSendingAccount.Enabled = false;
            this.txtSendingAccount.Location = new System.Drawing.Point(185, 359);
            this.txtSendingAccount.Name = "txtSendingAccount";
            this.txtSendingAccount.Size = new System.Drawing.Size(142, 20);
            this.txtSendingAccount.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 435);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtPage);
            this.tabPage1.Controls.Add(this.txtSendingAccount);
            this.tabPage1.Controls.Add(this.btnstart);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnstop);
            this.tabPage1.Controls.Add(this.txttext);
            this.tabPage1.Controls.Add(this.txtmessagecount);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txttotalmessagecount);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(502, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "send to followers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(76, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "import...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(28, 69);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnimportfile);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtsendinguser2);
            this.tabPage2.Controls.Add(this.btnstart2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnstop2);
            this.tabPage2.Controls.Add(this.txtText2);
            this.tabPage2.Controls.Add(this.txtsentcount2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txttotalsent2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(502, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "send to imported file";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnimportfile
            // 
            this.btnimportfile.Location = new System.Drawing.Point(81, 140);
            this.btnimportfile.Name = "btnimportfile";
            this.btnimportfile.Size = new System.Drawing.Size(150, 23);
            this.btnimportfile.TabIndex = 23;
            this.btnimportfile.Text = "import...";
            this.btnimportfile.UseVisualStyleBackColor = true;
            this.btnimportfile.Click += new System.EventHandler(this.btnimportfile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sending message by:";
            // 
            // txtsendinguser2
            // 
            this.txtsendinguser2.Enabled = false;
            this.txtsendinguser2.Location = new System.Drawing.Point(174, 325);
            this.txtsendinguser2.Name = "txtsendinguser2";
            this.txtsendinguser2.Size = new System.Drawing.Size(142, 20);
            this.txtsendinguser2.TabIndex = 21;
            // 
            // btnstart2
            // 
            this.btnstart2.Location = new System.Drawing.Point(81, 188);
            this.btnstart2.Name = "btnstart2";
            this.btnstart2.Size = new System.Drawing.Size(150, 23);
            this.btnstart2.TabIndex = 13;
            this.btnstart2.Text = "Start Sending";
            this.btnstart2.UseVisualStyleBackColor = true;
            this.btnstart2.Click += new System.EventHandler(this.btnstart2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "TEXT:";
            // 
            // btnstop2
            // 
            this.btnstop2.Location = new System.Drawing.Point(278, 188);
            this.btnstop2.Name = "btnstop2";
            this.btnstop2.Size = new System.Drawing.Size(150, 23);
            this.btnstop2.TabIndex = 14;
            this.btnstop2.Text = "Stop Sending";
            this.btnstop2.UseVisualStyleBackColor = true;
            this.btnstop2.Click += new System.EventHandler(this.btnstop2_Click);
            // 
            // txtText2
            // 
            this.txtText2.Location = new System.Drawing.Point(96, 19);
            this.txtText2.Multiline = true;
            this.txtText2.Name = "txtText2";
            this.txtText2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtText2.Size = new System.Drawing.Size(376, 104);
            this.txtText2.TabIndex = 19;
            // 
            // txtsentcount2
            // 
            this.txtsentcount2.Enabled = false;
            this.txtsentcount2.Location = new System.Drawing.Point(174, 239);
            this.txtsentcount2.Name = "txtsentcount2";
            this.txtsentcount2.Size = new System.Drawing.Size(142, 20);
            this.txtsentcount2.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "total messages sent:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "sent messages count:";
            // 
            // txttotalsent2
            // 
            this.txttotalsent2.Enabled = false;
            this.txttotalsent2.Location = new System.Drawing.Point(174, 274);
            this.txttotalsent2.Name = "txttotalsent2";
            this.txttotalsent2.Size = new System.Drawing.Size(142, 20);
            this.txttotalsent2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.TextBox txtmessagecount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotalmessagecount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSendingAccount;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnimportfile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsendinguser2;
        private System.Windows.Forms.Button btnstart2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnstop2;
        private System.Windows.Forms.TextBox txtText2;
        private System.Windows.Forms.TextBox txtsentcount2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttotalsent2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
    }
}

