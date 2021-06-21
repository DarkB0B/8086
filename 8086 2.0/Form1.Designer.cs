
namespace _8086_2._0
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
            this.c_set = new System.Windows.Forms.ComboBox();
            this.c_mov2 = new System.Windows.Forms.ComboBox();
            this.c_mov1 = new System.Windows.Forms.ComboBox();
            this.t_set = new System.Windows.Forms.TextBox();
            this.l_AH = new System.Windows.Forms.Label();
            this.l_AL = new System.Windows.Forms.Label();
            this.l_BH = new System.Windows.Forms.Label();
            this.l_BL = new System.Windows.Forms.Label();
            this.l_CH = new System.Windows.Forms.Label();
            this.l_CL = new System.Windows.Forms.Label();
            this.l_DH = new System.Windows.Forms.Label();
            this.l_DL = new System.Windows.Forms.Label();
            this.l_AX = new System.Windows.Forms.Label();
            this.l_BX = new System.Windows.Forms.Label();
            this.l_CX = new System.Windows.Forms.Label();
            this.l_DX = new System.Windows.Forms.Label();
            this.b_set = new System.Windows.Forms.Button();
            this.b_mov = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.c_mov3 = new System.Windows.Forms.ComboBox();
            this.c_mov4 = new System.Windows.Forms.ComboBox();
            this.b_mov2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.t_set2 = new System.Windows.Forms.TextBox();
            this.b_set2 = new System.Windows.Forms.Button();
            this.c_set2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.l_AXD = new System.Windows.Forms.Label();
            this.l_BXD = new System.Windows.Forms.Label();
            this.l_CXD = new System.Windows.Forms.Label();
            this.l_DXD = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // c_set
            // 
            this.c_set.FormattingEnabled = true;
            this.c_set.Items.AddRange(new object[] {
            "AH",
            "AL",
            "BH",
            "BL",
            "CH",
            "CL",
            "DH",
            "DL"});
            this.c_set.Location = new System.Drawing.Point(247, 133);
            this.c_set.Name = "c_set";
            this.c_set.Size = new System.Drawing.Size(121, 21);
            this.c_set.TabIndex = 0;
            this.c_set.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // c_mov2
            // 
            this.c_mov2.FormattingEnabled = true;
            this.c_mov2.Items.AddRange(new object[] {
            "AH",
            "AL",
            "BH",
            "BL",
            "CH",
            "CL",
            "DH",
            "DL"});
            this.c_mov2.Location = new System.Drawing.Point(247, 255);
            this.c_mov2.Name = "c_mov2";
            this.c_mov2.Size = new System.Drawing.Size(121, 21);
            this.c_mov2.TabIndex = 1;
            this.c_mov2.SelectedIndexChanged += new System.EventHandler(this.c_mov2_SelectedIndexChanged);
            // 
            // c_mov1
            // 
            this.c_mov1.FormattingEnabled = true;
            this.c_mov1.Items.AddRange(new object[] {
            "AH",
            "AL",
            "BH",
            "BL",
            "CH",
            "CL",
            "DH",
            "DL"});
            this.c_mov1.Location = new System.Drawing.Point(92, 255);
            this.c_mov1.Name = "c_mov1";
            this.c_mov1.Size = new System.Drawing.Size(121, 21);
            this.c_mov1.TabIndex = 2;
            this.c_mov1.SelectedIndexChanged += new System.EventHandler(this.c_mov1_SelectedIndexChanged);
            // 
            // t_set
            // 
            this.t_set.Location = new System.Drawing.Point(113, 134);
            this.t_set.Name = "t_set";
            this.t_set.Size = new System.Drawing.Size(100, 20);
            this.t_set.TabIndex = 3;
            // 
            // l_AH
            // 
            this.l_AH.AutoSize = true;
            this.l_AH.Location = new System.Drawing.Point(697, 80);
            this.l_AH.Name = "l_AH";
            this.l_AH.Size = new System.Drawing.Size(19, 13);
            this.l_AH.TabIndex = 4;
            this.l_AH.Text = "00";
            // 
            // l_AL
            // 
            this.l_AL.AutoSize = true;
            this.l_AL.Location = new System.Drawing.Point(753, 80);
            this.l_AL.Name = "l_AL";
            this.l_AL.Size = new System.Drawing.Size(19, 13);
            this.l_AL.TabIndex = 5;
            this.l_AL.Text = "00";
            this.l_AL.Click += new System.EventHandler(this.l_AL_Click);
            // 
            // l_BH
            // 
            this.l_BH.AutoSize = true;
            this.l_BH.Location = new System.Drawing.Point(695, 120);
            this.l_BH.Name = "l_BH";
            this.l_BH.Size = new System.Drawing.Size(19, 13);
            this.l_BH.TabIndex = 6;
            this.l_BH.Text = "00";
            this.l_BH.Click += new System.EventHandler(this.label3_Click);
            // 
            // l_BL
            // 
            this.l_BL.AutoSize = true;
            this.l_BL.Location = new System.Drawing.Point(753, 120);
            this.l_BL.Name = "l_BL";
            this.l_BL.Size = new System.Drawing.Size(19, 13);
            this.l_BL.TabIndex = 7;
            this.l_BL.Text = "00";
            // 
            // l_CH
            // 
            this.l_CH.AutoSize = true;
            this.l_CH.Location = new System.Drawing.Point(695, 160);
            this.l_CH.Name = "l_CH";
            this.l_CH.Size = new System.Drawing.Size(19, 13);
            this.l_CH.TabIndex = 8;
            this.l_CH.Text = "00";
            // 
            // l_CL
            // 
            this.l_CL.AutoSize = true;
            this.l_CL.Location = new System.Drawing.Point(753, 160);
            this.l_CL.Name = "l_CL";
            this.l_CL.Size = new System.Drawing.Size(19, 13);
            this.l_CL.TabIndex = 9;
            this.l_CL.Text = "00";
            // 
            // l_DH
            // 
            this.l_DH.AutoSize = true;
            this.l_DH.Location = new System.Drawing.Point(695, 200);
            this.l_DH.Name = "l_DH";
            this.l_DH.Size = new System.Drawing.Size(19, 13);
            this.l_DH.TabIndex = 10;
            this.l_DH.Text = "00";
            // 
            // l_DL
            // 
            this.l_DL.AutoSize = true;
            this.l_DL.Location = new System.Drawing.Point(753, 200);
            this.l_DL.Name = "l_DL";
            this.l_DL.Size = new System.Drawing.Size(19, 13);
            this.l_DL.TabIndex = 11;
            this.l_DL.Text = "00";
            // 
            // l_AX
            // 
            this.l_AX.AutoSize = true;
            this.l_AX.Location = new System.Drawing.Point(620, 80);
            this.l_AX.Name = "l_AX";
            this.l_AX.Size = new System.Drawing.Size(31, 13);
            this.l_AX.TabIndex = 12;
            this.l_AX.Text = "0000";
            // 
            // l_BX
            // 
            this.l_BX.AutoSize = true;
            this.l_BX.Location = new System.Drawing.Point(620, 120);
            this.l_BX.Name = "l_BX";
            this.l_BX.Size = new System.Drawing.Size(31, 13);
            this.l_BX.TabIndex = 13;
            this.l_BX.Text = "0000";
            // 
            // l_CX
            // 
            this.l_CX.AutoSize = true;
            this.l_CX.Location = new System.Drawing.Point(620, 160);
            this.l_CX.Name = "l_CX";
            this.l_CX.Size = new System.Drawing.Size(31, 13);
            this.l_CX.TabIndex = 14;
            this.l_CX.Text = "0000";
            // 
            // l_DX
            // 
            this.l_DX.AutoSize = true;
            this.l_DX.Location = new System.Drawing.Point(620, 200);
            this.l_DX.Name = "l_DX";
            this.l_DX.Size = new System.Drawing.Size(31, 13);
            this.l_DX.TabIndex = 15;
            this.l_DX.Text = "0000";
            // 
            // b_set
            // 
            this.b_set.Location = new System.Drawing.Point(382, 131);
            this.b_set.Name = "b_set";
            this.b_set.Size = new System.Drawing.Size(75, 23);
            this.b_set.TabIndex = 16;
            this.b_set.Text = "SET";
            this.b_set.UseVisualStyleBackColor = true;
            this.b_set.Click += new System.EventHandler(this.b_set_Click);
            // 
            // b_mov
            // 
            this.b_mov.Location = new System.Drawing.Point(382, 250);
            this.b_mov.Name = "b_mov";
            this.b_mov.Size = new System.Drawing.Size(75, 23);
            this.b_mov.TabIndex = 17;
            this.b_mov.Text = "MOV";
            this.b_mov.UseVisualStyleBackColor = true;
            this.b_mov.Click += new System.EventHandler(this.b_mov_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "MOV 8 BIT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // c_mov3
            // 
            this.c_mov3.FormattingEnabled = true;
            this.c_mov3.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.c_mov3.Location = new System.Drawing.Point(92, 288);
            this.c_mov3.Name = "c_mov3";
            this.c_mov3.Size = new System.Drawing.Size(121, 21);
            this.c_mov3.TabIndex = 19;
            // 
            // c_mov4
            // 
            this.c_mov4.FormattingEnabled = true;
            this.c_mov4.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.c_mov4.Location = new System.Drawing.Point(247, 288);
            this.c_mov4.Name = "c_mov4";
            this.c_mov4.Size = new System.Drawing.Size(121, 21);
            this.c_mov4.TabIndex = 20;
            // 
            // b_mov2
            // 
            this.b_mov2.Location = new System.Drawing.Point(382, 286);
            this.b_mov2.Name = "b_mov2";
            this.b_mov2.Size = new System.Drawing.Size(75, 23);
            this.b_mov2.TabIndex = 21;
            this.b_mov2.Text = "MOV";
            this.b_mov2.UseVisualStyleBackColor = true;
            this.b_mov2.Click += new System.EventHandler(this.b_mov2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "MOV 16 BIT";
            // 
            // t_set2
            // 
            this.t_set2.Location = new System.Drawing.Point(113, 75);
            this.t_set2.Name = "t_set2";
            this.t_set2.Size = new System.Drawing.Size(100, 20);
            this.t_set2.TabIndex = 23;
            // 
            // b_set2
            // 
            this.b_set2.Location = new System.Drawing.Point(382, 75);
            this.b_set2.Name = "b_set2";
            this.b_set2.Size = new System.Drawing.Size(75, 23);
            this.b_set2.TabIndex = 24;
            this.b_set2.Text = "SET";
            this.b_set2.UseVisualStyleBackColor = true;
            this.b_set2.Click += new System.EventHandler(this.b_set2_Click);
            // 
            // c_set2
            // 
            this.c_set2.FormattingEnabled = true;
            this.c_set2.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.c_set2.Location = new System.Drawing.Point(247, 75);
            this.c_set2.Name = "c_set2";
            this.c_set2.Size = new System.Drawing.Size(121, 21);
            this.c_set2.TabIndex = 25;
            this.c_set2.SelectedIndexChanged += new System.EventHandler(this.c_set2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "SET 16 BIT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "SET 8 BIT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "TO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "TO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(196, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 31);
            this.label7.TabIndex = 30;
            this.label7.Text = "MOV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label8.Location = new System.Drawing.Point(196, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 31);
            this.label8.TabIndex = 31;
            this.label8.Text = "SET";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(682, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "HIGH";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(740, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "LOW";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(713, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "8 BIT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(592, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "16 BIT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(620, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "HEX";
            // 
            // l_AXD
            // 
            this.l_AXD.AutoSize = true;
            this.l_AXD.Location = new System.Drawing.Point(566, 80);
            this.l_AXD.Name = "l_AXD";
            this.l_AXD.Size = new System.Drawing.Size(31, 13);
            this.l_AXD.TabIndex = 37;
            this.l_AXD.Text = "0000";
            // 
            // l_BXD
            // 
            this.l_BXD.AutoSize = true;
            this.l_BXD.Location = new System.Drawing.Point(566, 120);
            this.l_BXD.Name = "l_BXD";
            this.l_BXD.Size = new System.Drawing.Size(31, 13);
            this.l_BXD.TabIndex = 38;
            this.l_BXD.Text = "0000";
            // 
            // l_CXD
            // 
            this.l_CXD.AutoSize = true;
            this.l_CXD.Location = new System.Drawing.Point(566, 160);
            this.l_CXD.Name = "l_CXD";
            this.l_CXD.Size = new System.Drawing.Size(31, 13);
            this.l_CXD.TabIndex = 39;
            this.l_CXD.Text = "0000";
            // 
            // l_DXD
            // 
            this.l_DXD.AutoSize = true;
            this.l_DXD.Location = new System.Drawing.Point(566, 200);
            this.l_DXD.Name = "l_DXD";
            this.l_DXD.Size = new System.Drawing.Size(31, 13);
            this.l_DXD.TabIndex = 40;
            this.l_DXD.Text = "0000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(568, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "DEC";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(539, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "AX";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(539, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "BX";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(539, 160);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "CX";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(539, 200);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "DX";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(670, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "AH";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(668, 120);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "BH";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(668, 160);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "CH";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(668, 200);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(23, 13);
            this.label22.TabIndex = 49;
            this.label22.Text = "DH";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(726, 80);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 13);
            this.label23.TabIndex = 50;
            this.label23.Text = "AL";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(726, 120);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 13);
            this.label24.TabIndex = 51;
            this.label24.Text = "BL";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(726, 160);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(20, 13);
            this.label25.TabIndex = 52;
            this.label25.Text = "CL";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(726, 200);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(21, 13);
            this.label26.TabIndex = 53;
            this.label26.Text = "DL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "CLEAR ALL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.l_DXD);
            this.Controls.Add(this.l_CXD);
            this.Controls.Add(this.l_BXD);
            this.Controls.Add(this.l_AXD);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.c_set2);
            this.Controls.Add(this.b_set2);
            this.Controls.Add(this.t_set2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_mov2);
            this.Controls.Add(this.c_mov4);
            this.Controls.Add(this.c_mov3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_mov);
            this.Controls.Add(this.b_set);
            this.Controls.Add(this.l_DX);
            this.Controls.Add(this.l_CX);
            this.Controls.Add(this.l_BX);
            this.Controls.Add(this.l_AX);
            this.Controls.Add(this.l_DL);
            this.Controls.Add(this.l_DH);
            this.Controls.Add(this.l_CL);
            this.Controls.Add(this.l_CH);
            this.Controls.Add(this.l_BL);
            this.Controls.Add(this.l_BH);
            this.Controls.Add(this.l_AL);
            this.Controls.Add(this.l_AH);
            this.Controls.Add(this.t_set);
            this.Controls.Add(this.c_mov1);
            this.Controls.Add(this.c_mov2);
            this.Controls.Add(this.c_set);
            this.Name = "Form1";
            this.Text = ",";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox c_set;
        private System.Windows.Forms.ComboBox c_mov2;
        private System.Windows.Forms.ComboBox c_mov1;
        private System.Windows.Forms.TextBox t_set;
        private System.Windows.Forms.Label l_AH;
        private System.Windows.Forms.Label l_AL;
        private System.Windows.Forms.Label l_BH;
        private System.Windows.Forms.Label l_BL;
        private System.Windows.Forms.Label l_CH;
        private System.Windows.Forms.Label l_CL;
        private System.Windows.Forms.Label l_DH;
        private System.Windows.Forms.Label l_DL;
        private System.Windows.Forms.Label l_AX;
        private System.Windows.Forms.Label l_BX;
        private System.Windows.Forms.Label l_CX;
        private System.Windows.Forms.Label l_DX;
        private System.Windows.Forms.Button b_set;
        private System.Windows.Forms.Button b_mov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox c_mov3;
        private System.Windows.Forms.ComboBox c_mov4;
        private System.Windows.Forms.Button b_mov2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_set2;
        private System.Windows.Forms.Button b_set2;
        private System.Windows.Forms.ComboBox c_set2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label l_AXD;
        private System.Windows.Forms.Label l_BXD;
        private System.Windows.Forms.Label l_CXD;
        private System.Windows.Forms.Label l_DXD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button1;
    }
}

