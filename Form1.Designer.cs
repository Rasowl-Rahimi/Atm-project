namespace ATM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btwhitdrawal = new System.Windows.Forms.Button();
            this.btbalance = new System.Windows.Forms.Button();
            this.btdeposit = new System.Windows.Forms.Button();
            this.btloan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbpin = new System.Windows.Forms.TextBox();
            this.lbFastCash = new System.Windows.Forms.Label();
            this.lbloan = new System.Windows.Forms.Label();
            this.lbwhitdraw = new System.Windows.Forms.Label();
            this.lbbalance = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btenter = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn3000 = new System.Windows.Forms.Button();
            this.btn5000 = new System.Windows.Forms.Button();
            this.btn1000 = new System.Windows.Forms.Button();
            this.btn2000 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btnWhitdraw = new System.Windows.Forms.Button();
            this.txtbWhitdraw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btpexit = new System.Windows.Forms.Button();
            this.btpreset = new System.Windows.Forms.Button();
            this.btpreceipt = new System.Windows.Forms.Button();
            this.btploan = new System.Windows.Forms.Button();
            this.pre = new System.Windows.Forms.RichTextBox();
            this.ptotal = new System.Windows.Forms.TextBox();
            this.pmonth = new System.Windows.Forms.TextBox();
            this.prate = new System.Windows.Forms.TextBox();
            this.pyear = new System.Windows.Forms.TextBox();
            this.ploan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.btwhitdrawal);
            this.groupBox1.Controls.Add(this.btbalance);
            this.groupBox1.Controls.Add(this.btdeposit);
            this.groupBox1.Controls.Add(this.btloan);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(471, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btwhitdrawal
            // 
            this.btwhitdrawal.BackgroundImage = global::ATM.Properties.Resources.lArrow;
            this.btwhitdrawal.Location = new System.Drawing.Point(8, 128);
            this.btwhitdrawal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btwhitdrawal.Name = "btwhitdrawal";
            this.btwhitdrawal.Size = new System.Drawing.Size(105, 60);
            this.btwhitdrawal.TabIndex = 21;
            this.btwhitdrawal.UseVisualStyleBackColor = true;
            this.btwhitdrawal.Click += new System.EventHandler(this.btwhitdrawal_Click);
            // 
            // btbalance
            // 
            this.btbalance.BackgroundImage = global::ATM.Properties.Resources.lArrow;
            this.btbalance.Location = new System.Drawing.Point(11, 46);
            this.btbalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btbalance.Name = "btbalance";
            this.btbalance.Size = new System.Drawing.Size(105, 60);
            this.btbalance.TabIndex = 20;
            this.btbalance.UseVisualStyleBackColor = true;
            this.btbalance.Click += new System.EventHandler(this.btbalance_Click);
            // 
            // btdeposit
            // 
            this.btdeposit.BackgroundImage = global::ATM.Properties.Resources.rArrow;
            this.btdeposit.Location = new System.Drawing.Point(360, 132);
            this.btdeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btdeposit.Name = "btdeposit";
            this.btdeposit.Size = new System.Drawing.Size(105, 60);
            this.btdeposit.TabIndex = 19;
            this.btdeposit.UseVisualStyleBackColor = true;
            this.btdeposit.Click += new System.EventHandler(this.btdeposit_Click);
            // 
            // btloan
            // 
            this.btloan.BackgroundImage = global::ATM.Properties.Resources.rArrow;
            this.btloan.Location = new System.Drawing.Point(360, 46);
            this.btloan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btloan.Name = "btloan";
            this.btloan.Size = new System.Drawing.Size(105, 60);
            this.btloan.TabIndex = 18;
            this.btloan.UseVisualStyleBackColor = true;
            this.btloan.Click += new System.EventHandler(this.btloan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.lbpin);
            this.groupBox3.Controls.Add(this.lbFastCash);
            this.groupBox3.Controls.Add(this.lbloan);
            this.groupBox3.Controls.Add(this.lbwhitdraw);
            this.groupBox3.Controls.Add(this.lbbalance);
            this.groupBox3.Location = new System.Drawing.Point(119, 26);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(231, 186);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // lbpin
            // 
            this.lbpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpin.Location = new System.Drawing.Point(3, 76);
            this.lbpin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbpin.Name = "lbpin";
            this.lbpin.Size = new System.Drawing.Size(220, 35);
            this.lbpin.TabIndex = 2;
            this.lbpin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lbpin.TextChanged += new System.EventHandler(this.lbpin_TextChanged);
            // 
            // lbFastCash
            // 
            this.lbFastCash.AutoSize = true;
            this.lbFastCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFastCash.Location = new System.Drawing.Point(122, 118);
            this.lbFastCash.Name = "lbFastCash";
            this.lbFastCash.Size = new System.Drawing.Size(114, 29);
            this.lbFastCash.TabIndex = 4;
            this.lbFastCash.Text = "FastCash";
            this.lbFastCash.Click += new System.EventHandler(this.lbFastCash_Click);
            // 
            // lbloan
            // 
            this.lbloan.AutoSize = true;
            this.lbloan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloan.Location = new System.Drawing.Point(168, 31);
            this.lbloan.Name = "lbloan";
            this.lbloan.Size = new System.Drawing.Size(66, 29);
            this.lbloan.TabIndex = 5;
            this.lbloan.Text = "Loan";
            this.lbloan.Click += new System.EventHandler(this.lbloan_Click);
            // 
            // lbwhitdraw
            // 
            this.lbwhitdraw.AutoSize = true;
            this.lbwhitdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwhitdraw.Location = new System.Drawing.Point(-2, 118);
            this.lbwhitdraw.Name = "lbwhitdraw";
            this.lbwhitdraw.Size = new System.Drawing.Size(113, 29);
            this.lbwhitdraw.TabIndex = 3;
            this.lbwhitdraw.Text = "Whitdraw";
            // 
            // lbbalance
            // 
            this.lbbalance.AutoSize = true;
            this.lbbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbalance.Location = new System.Drawing.Point(-6, 31);
            this.lbbalance.Name = "lbbalance";
            this.lbbalance.Size = new System.Drawing.Size(100, 29);
            this.lbbalance.TabIndex = 2;
            this.lbbalance.Text = "Balance";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.btclear);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.btenter);
            this.groupBox2.Controls.Add(this.bt0);
            this.groupBox2.Controls.Add(this.btcancel);
            this.groupBox2.Controls.Add(this.bt6);
            this.groupBox2.Controls.Add(this.bt4);
            this.groupBox2.Controls.Add(this.bt5);
            this.groupBox2.Controls.Add(this.bt9);
            this.groupBox2.Controls.Add(this.bt7);
            this.groupBox2.Controls.Add(this.bt8);
            this.groupBox2.Controls.Add(this.bt3);
            this.groupBox2.Controls.Add(this.bt1);
            this.groupBox2.Controls.Add(this.bt2);
            this.groupBox2.Location = new System.Drawing.Point(14, 259);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(471, 320);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button13
            // 
            this.button13.BackgroundImage = global::ATM.Properties.Resources.empty;
            this.button13.Location = new System.Drawing.Point(341, 239);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(105, 60);
            this.button13.TabIndex = 17;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::ATM.Properties.Resources.empty;
            this.button10.Location = new System.Drawing.Point(230, 239);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(105, 60);
            this.button10.TabIndex = 13;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btclear
            // 
            this.btclear.BackgroundImage = global::ATM.Properties.Resources.clear;
            this.btclear.Location = new System.Drawing.Point(341, 104);
            this.btclear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(105, 60);
            this.btclear.TabIndex = 16;
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::ATM.Properties.Resources.empty;
            this.button11.Location = new System.Drawing.Point(17, 239);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(101, 60);
            this.button11.TabIndex = 12;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // btenter
            // 
            this.btenter.BackgroundImage = global::ATM.Properties.Resources.enter;
            this.btenter.Location = new System.Drawing.Point(341, 171);
            this.btenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btenter.Name = "btenter";
            this.btenter.Size = new System.Drawing.Size(105, 60);
            this.btenter.TabIndex = 15;
            this.btenter.UseVisualStyleBackColor = true;
            this.btenter.Click += new System.EventHandler(this.btenter_Click);
            // 
            // bt0
            // 
            this.bt0.BackgroundImage = global::ATM.Properties.Resources.zero;
            this.bt0.Location = new System.Drawing.Point(119, 239);
            this.bt0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(104, 60);
            this.bt0.TabIndex = 14;
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btcancel
            // 
            this.btcancel.BackgroundImage = global::ATM.Properties.Resources.cancel;
            this.btcancel.Location = new System.Drawing.Point(341, 36);
            this.btcancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(105, 60);
            this.btcancel.TabIndex = 14;
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // bt6
            // 
            this.bt6.BackgroundImage = global::ATM.Properties.Resources.six;
            this.bt6.Location = new System.Drawing.Point(230, 104);
            this.bt6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(105, 60);
            this.bt6.TabIndex = 10;
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt4
            // 
            this.bt4.BackgroundImage = global::ATM.Properties.Resources.four;
            this.bt4.Location = new System.Drawing.Point(17, 104);
            this.bt4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(101, 60);
            this.bt4.TabIndex = 9;
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt5
            // 
            this.bt5.BackgroundImage = global::ATM.Properties.Resources.five;
            this.bt5.Location = new System.Drawing.Point(119, 104);
            this.bt5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(104, 60);
            this.bt5.TabIndex = 11;
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt9
            // 
            this.bt9.BackgroundImage = global::ATM.Properties.Resources.nine;
            this.bt9.Location = new System.Drawing.Point(230, 171);
            this.bt9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(105, 60);
            this.bt9.TabIndex = 7;
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt7
            // 
            this.bt7.BackgroundImage = global::ATM.Properties.Resources.seven;
            this.bt7.Location = new System.Drawing.Point(17, 171);
            this.bt7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(101, 60);
            this.bt7.TabIndex = 6;
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.BackgroundImage = global::ATM.Properties.Resources.eight;
            this.bt8.Location = new System.Drawing.Point(119, 171);
            this.bt8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(104, 60);
            this.bt8.TabIndex = 8;
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt3
            // 
            this.bt3.BackgroundImage = global::ATM.Properties.Resources.three;
            this.bt3.Location = new System.Drawing.Point(230, 36);
            this.bt3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(105, 60);
            this.bt3.TabIndex = 4;
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt1
            // 
            this.bt1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt1.BackgroundImage")));
            this.bt1.Location = new System.Drawing.Point(17, 36);
            this.bt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(101, 60);
            this.bt1.TabIndex = 2;
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.BackgroundImage = global::ATM.Properties.Resources.two;
            this.bt2.Location = new System.Drawing.Point(122, 36);
            this.bt2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(104, 60);
            this.bt2.TabIndex = 5;
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btn3000);
            this.panel1.Controls.Add(this.btn5000);
            this.panel1.Controls.Add(this.btn1000);
            this.panel1.Controls.Add(this.btn2000);
            this.panel1.Controls.Add(this.btn500);
            this.panel1.Controls.Add(this.btnWhitdraw);
            this.panel1.Controls.Add(this.txtbWhitdraw);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btpexit);
            this.panel1.Controls.Add(this.btpreset);
            this.panel1.Controls.Add(this.btpreceipt);
            this.panel1.Controls.Add(this.btploan);
            this.panel1.Controls.Add(this.pre);
            this.panel1.Controls.Add(this.ptotal);
            this.panel1.Controls.Add(this.pmonth);
            this.panel1.Controls.Add(this.prate);
            this.panel1.Controls.Add(this.pyear);
            this.panel1.Controls.Add(this.ploan);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(492, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 562);
            this.panel1.TabIndex = 2;
            // 
            // btn3000
            // 
            this.btn3000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3000.Location = new System.Drawing.Point(738, 348);
            this.btn3000.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn3000.Name = "btn3000";
            this.btn3000.Size = new System.Drawing.Size(215, 90);
            this.btn3000.TabIndex = 22;
            this.btn3000.Text = "3000";
            this.btn3000.UseVisualStyleBackColor = true;
            this.btn3000.Click += new System.EventHandler(this.btn3000_Click);
            // 
            // btn5000
            // 
            this.btn5000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5000.Location = new System.Drawing.Point(738, 452);
            this.btn5000.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn5000.Name = "btn5000";
            this.btn5000.Size = new System.Drawing.Size(215, 90);
            this.btn5000.TabIndex = 21;
            this.btn5000.Text = "5000";
            this.btn5000.UseVisualStyleBackColor = true;
            this.btn5000.Click += new System.EventHandler(this.btn5000_Click);
            // 
            // btn1000
            // 
            this.btn1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1000.Location = new System.Drawing.Point(741, 132);
            this.btn1000.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(215, 90);
            this.btn1000.TabIndex = 20;
            this.btn1000.Text = "1000";
            this.btn1000.UseVisualStyleBackColor = true;
            this.btn1000.Click += new System.EventHandler(this.btn1000_Click);
            // 
            // btn2000
            // 
            this.btn2000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2000.Location = new System.Drawing.Point(738, 244);
            this.btn2000.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn2000.Name = "btn2000";
            this.btn2000.Size = new System.Drawing.Size(215, 90);
            this.btn2000.TabIndex = 19;
            this.btn2000.Text = "2000";
            this.btn2000.UseVisualStyleBackColor = true;
            this.btn2000.Click += new System.EventHandler(this.btn2000_Click);
            // 
            // btn500
            // 
            this.btn500.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn500.Location = new System.Drawing.Point(738, 26);
            this.btn500.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(215, 90);
            this.btn500.TabIndex = 18;
            this.btn500.Text = "500";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
            // 
            // btnWhitdraw
            // 
            this.btnWhitdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhitdraw.Location = new System.Drawing.Point(372, 472);
            this.btnWhitdraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWhitdraw.Name = "btnWhitdraw";
            this.btnWhitdraw.Size = new System.Drawing.Size(359, 70);
            this.btnWhitdraw.TabIndex = 17;
            this.btnWhitdraw.Text = "Whitdraw";
            this.btnWhitdraw.UseVisualStyleBackColor = true;
            this.btnWhitdraw.Click += new System.EventHandler(this.btnWhitdraw_Click);
            // 
            // txtbWhitdraw
            // 
            this.txtbWhitdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbWhitdraw.Location = new System.Drawing.Point(626, 431);
            this.txtbWhitdraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbWhitdraw.Name = "txtbWhitdraw";
            this.txtbWhitdraw.Size = new System.Drawing.Size(105, 32);
            this.txtbWhitdraw.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(368, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Enter amount of money\r\n";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btpexit
            // 
            this.btpexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpexit.Location = new System.Drawing.Point(194, 460);
            this.btpexit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btpexit.Name = "btpexit";
            this.btpexit.Size = new System.Drawing.Size(168, 85);
            this.btpexit.TabIndex = 14;
            this.btpexit.Text = "exit";
            this.btpexit.UseVisualStyleBackColor = true;
            this.btpexit.Click += new System.EventHandler(this.btpexit_Click);
            // 
            // btpreset
            // 
            this.btpreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpreset.Location = new System.Drawing.Point(3, 460);
            this.btpreset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btpreset.Name = "btpreset";
            this.btpreset.Size = new System.Drawing.Size(169, 85);
            this.btpreset.TabIndex = 13;
            this.btpreset.Text = "reset";
            this.btpreset.UseVisualStyleBackColor = true;
            this.btpreset.Click += new System.EventHandler(this.btpreset_Click);
            // 
            // btpreceipt
            // 
            this.btpreceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpreceipt.Location = new System.Drawing.Point(194, 362);
            this.btpreceipt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btpreceipt.Name = "btpreceipt";
            this.btpreceipt.Size = new System.Drawing.Size(168, 90);
            this.btpreceipt.TabIndex = 12;
            this.btpreceipt.Text = "receipt";
            this.btpreceipt.UseVisualStyleBackColor = true;
            this.btpreceipt.Click += new System.EventHandler(this.btpreceipt_Click);
            // 
            // btploan
            // 
            this.btploan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btploan.Location = new System.Drawing.Point(3, 362);
            this.btploan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btploan.Name = "btploan";
            this.btploan.Size = new System.Drawing.Size(169, 90);
            this.btploan.TabIndex = 11;
            this.btploan.Text = "loan";
            this.btploan.UseVisualStyleBackColor = true;
            this.btploan.Click += new System.EventHandler(this.btploan_Click);
            // 
            // pre
            // 
            this.pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre.Location = new System.Drawing.Point(368, 26);
            this.pre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pre.Name = "pre";
            this.pre.Size = new System.Drawing.Size(363, 384);
            this.pre.TabIndex = 10;
            this.pre.Text = "";
            // 
            // ptotal
            // 
            this.ptotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptotal.Location = new System.Drawing.Point(238, 274);
            this.ptotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptotal.Name = "ptotal";
            this.ptotal.Size = new System.Drawing.Size(92, 32);
            this.ptotal.TabIndex = 9;
            // 
            // pmonth
            // 
            this.pmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pmonth.Location = new System.Drawing.Point(238, 211);
            this.pmonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pmonth.Name = "pmonth";
            this.pmonth.Size = new System.Drawing.Size(92, 32);
            this.pmonth.TabIndex = 8;
            // 
            // prate
            // 
            this.prate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prate.Location = new System.Drawing.Point(238, 144);
            this.prate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prate.Name = "prate";
            this.prate.Size = new System.Drawing.Size(92, 32);
            this.prate.TabIndex = 7;
            // 
            // pyear
            // 
            this.pyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pyear.Location = new System.Drawing.Point(238, 81);
            this.pyear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pyear.Name = "pyear";
            this.pyear.Size = new System.Drawing.Size(93, 32);
            this.pyear.TabIndex = 6;
            // 
            // ploan
            // 
            this.ploan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ploan.Location = new System.Drawing.Point(238, 26);
            this.ploan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ploan.Name = "ploan";
            this.ploan.Size = new System.Drawing.Size(92, 32);
            this.ploan.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total payment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monthly payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter interest rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter number of year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter amount of loan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1461, 592);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button btwhitdrawal;
        private System.Windows.Forms.Button btbalance;
        private System.Windows.Forms.Button btdeposit;
        private System.Windows.Forms.Button btloan;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Button btenter;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Label lbbalance;
        private System.Windows.Forms.Label lbwhitdraw;
        private System.Windows.Forms.Label lbFastCash;
        private System.Windows.Forms.Label lbloan;
        private System.Windows.Forms.TextBox lbpin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btpexit;
        private System.Windows.Forms.Button btpreset;
        private System.Windows.Forms.Button btpreceipt;
        private System.Windows.Forms.Button btploan;
        private System.Windows.Forms.RichTextBox pre;
        private System.Windows.Forms.TextBox ptotal;
        private System.Windows.Forms.TextBox pmonth;
        private System.Windows.Forms.TextBox prate;
        private System.Windows.Forms.TextBox pyear;
        private System.Windows.Forms.TextBox ploan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnWhitdraw;
        private System.Windows.Forms.TextBox txtbWhitdraw;
        private System.Windows.Forms.Button btn3000;
        private System.Windows.Forms.Button btn5000;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Button btn2000;
        private System.Windows.Forms.Button btn500;
    }
}

