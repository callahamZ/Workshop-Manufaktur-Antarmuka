namespace Percobaan_1_VS
{
    partial class Form9
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Tembok = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Lantai = new System.Windows.Forms.Panel();
            this.limitSwitch2 = new System.Windows.Forms.Panel();
            this.sensorUltra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sensorProx = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rollingDoor = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.limitSwitch1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sensorUltraIndikator = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sensorProxIndikator = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.limitSwitch1Indikator = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.limitSwitch2Indikator = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.rollingDoorIndikator = new System.Windows.Forms.Panel();
            this.gambarTruk = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Tembok.SuspendLayout();
            this.Lantai.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gambarTruk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Jalankan Truk";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tembok
            // 
            this.Tembok.BackColor = System.Drawing.Color.Silver;
            this.Tembok.Controls.Add(this.panel5);
            this.Tembok.Location = new System.Drawing.Point(500, -3);
            this.Tembok.Name = "Tembok";
            this.Tembok.Size = new System.Drawing.Size(30, 60);
            this.Tembok.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Location = new System.Drawing.Point(36, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 214);
            this.panel5.TabIndex = 3;
            // 
            // Lantai
            // 
            this.Lantai.BackColor = System.Drawing.Color.Silver;
            this.Lantai.Controls.Add(this.limitSwitch2);
            this.Lantai.Location = new System.Drawing.Point(-1, 225);
            this.Lantai.Name = "Lantai";
            this.Lantai.Size = new System.Drawing.Size(985, 19);
            this.Lantai.TabIndex = 3;
            // 
            // limitSwitch2
            // 
            this.limitSwitch2.BackColor = System.Drawing.Color.Green;
            this.limitSwitch2.Location = new System.Drawing.Point(530, 3);
            this.limitSwitch2.Name = "limitSwitch2";
            this.limitSwitch2.Size = new System.Drawing.Size(17, 12);
            this.limitSwitch2.TabIndex = 5;
            // 
            // sensorUltra
            // 
            this.sensorUltra.BackColor = System.Drawing.Color.Red;
            this.sensorUltra.Location = new System.Drawing.Point(483, 45);
            this.sensorUltra.Name = "sensorUltra";
            this.sensorUltra.Size = new System.Drawing.Size(31, 12);
            this.sensorUltra.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sensor Ultrasonik";
            // 
            // sensorProx
            // 
            this.sensorProx.BackColor = System.Drawing.Color.Red;
            this.sensorProx.Location = new System.Drawing.Point(485, 219);
            this.sensorProx.Name = "sensorProx";
            this.sensorProx.Size = new System.Drawing.Size(31, 10);
            this.sensorProx.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sensor Proximity";
            // 
            // rollingDoor
            // 
            this.rollingDoor.BackColor = System.Drawing.Color.Gray;
            this.rollingDoor.Location = new System.Drawing.Point(520, 30);
            this.rollingDoor.Name = "rollingDoor";
            this.rollingDoor.Size = new System.Drawing.Size(10, 210);
            this.rollingDoor.TabIndex = 4;
            // 
            // timer2
            // 
            this.timer2.Interval = 25;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // limitSwitch1
            // 
            this.limitSwitch1.BackColor = System.Drawing.Color.Red;
            this.limitSwitch1.Location = new System.Drawing.Point(530, 45);
            this.limitSwitch1.Name = "limitSwitch1";
            this.limitSwitch1.Size = new System.Drawing.Size(17, 12);
            this.limitSwitch1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Limit Switch 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Limit Switch 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 254);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Stop Bits";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "1.5"});
            this.comboBox5.Location = new System.Drawing.Point(153, 150);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 24);
            this.comboBox5.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Data Bits";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBox4.Location = new System.Drawing.Point(153, 97);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Parity";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.comboBox3.Location = new System.Drawing.Point(15, 150);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Baud Rate";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "76800",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(15, 97);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(153, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 36);
            this.button2.TabIndex = 22;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(15, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 36);
            this.button3.TabIndex = 21;
            this.button3.Text = "Connect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Serial Port";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(982, 26);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rollingDoorIndikator);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.limitSwitch2Indikator);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.limitSwitch1Indikator);
            this.groupBox2.Controls.Add(this.sensorProxIndikator);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.sensorUltraIndikator);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(351, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 254);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kontrol";
            // 
            // sensorUltraIndikator
            // 
            this.sensorUltraIndikator.BackColor = System.Drawing.Color.Red;
            this.sensorUltraIndikator.Location = new System.Drawing.Point(21, 115);
            this.sensorUltraIndikator.Name = "sensorUltraIndikator";
            this.sensorUltraIndikator.Size = new System.Drawing.Size(15, 12);
            this.sensorUltraIndikator.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "Indikator";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Sensor Ultrasonik";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(44, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Sensor Proximity";
            // 
            // sensorProxIndikator
            // 
            this.sensorProxIndikator.BackColor = System.Drawing.Color.Red;
            this.sensorProxIndikator.Location = new System.Drawing.Point(21, 137);
            this.sensorProxIndikator.Name = "sensorProxIndikator";
            this.sensorProxIndikator.Size = new System.Drawing.Size(15, 12);
            this.sensorProxIndikator.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(44, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "Limit Switch 1";
            // 
            // limitSwitch1Indikator
            // 
            this.limitSwitch1Indikator.BackColor = System.Drawing.Color.Red;
            this.limitSwitch1Indikator.Location = new System.Drawing.Point(21, 158);
            this.limitSwitch1Indikator.Name = "limitSwitch1Indikator";
            this.limitSwitch1Indikator.Size = new System.Drawing.Size(15, 12);
            this.limitSwitch1Indikator.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(44, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Limit Switch 2";
            // 
            // limitSwitch2Indikator
            // 
            this.limitSwitch2Indikator.BackColor = System.Drawing.Color.Green;
            this.limitSwitch2Indikator.Location = new System.Drawing.Point(21, 179);
            this.limitSwitch2Indikator.Name = "limitSwitch2Indikator";
            this.limitSwitch2Indikator.Size = new System.Drawing.Size(15, 12);
            this.limitSwitch2Indikator.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(51, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 18);
            this.label15.TabIndex = 19;
            this.label15.Text = "Rolling Door";
            // 
            // rollingDoorIndikator
            // 
            this.rollingDoorIndikator.BackColor = System.Drawing.Color.Red;
            this.rollingDoorIndikator.Location = new System.Drawing.Point(21, 197);
            this.rollingDoorIndikator.Name = "rollingDoorIndikator";
            this.rollingDoorIndikator.Size = new System.Drawing.Size(27, 24);
            this.rollingDoorIndikator.TabIndex = 7;
            // 
            // gambarTruk
            // 
            this.gambarTruk.BackColor = System.Drawing.SystemColors.Control;
            this.gambarTruk.Image = global::Percobaan_1_VS.Properties.Resources.trukGif2;
            this.gambarTruk.Location = new System.Drawing.Point(12, 112);
            this.gambarTruk.Name = "gambarTruk";
            this.gambarTruk.Size = new System.Drawing.Size(279, 122);
            this.gambarTruk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gambarTruk.TabIndex = 0;
            this.gambarTruk.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = global::Percobaan_1_VS.Properties.Resources.signal2_removebg_FLIP_Rotated;
            this.pictureBox2.Location = new System.Drawing.Point(395, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.limitSwitch1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rollingDoor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lantai);
            this.Controls.Add(this.sensorProx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sensorUltra);
            this.Controls.Add(this.Tembok);
            this.Controls.Add(this.gambarTruk);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form9";
            this.Text = "Form9";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form9_FormClosing);
            this.Load += new System.EventHandler(this.Form9_Load);
            this.Tembok.ResumeLayout(false);
            this.Lantai.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gambarTruk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gambarTruk;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Tembok;
        private System.Windows.Forms.Panel Lantai;
        private System.Windows.Forms.Panel sensorUltra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel sensorProx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel rollingDoor;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel limitSwitch1;
        private System.Windows.Forms.Panel limitSwitch2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel limitSwitch2Indikator;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel limitSwitch1Indikator;
        private System.Windows.Forms.Panel sensorProxIndikator;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel sensorUltraIndikator;
        private System.Windows.Forms.Panel rollingDoorIndikator;
        private System.Windows.Forms.Label label15;
    }
}