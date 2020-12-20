namespace WLED_Controller
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
            this.bightness = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.poweron = new System.Windows.Forms.Button();
            this.poweroff = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.intensityValue = new System.Windows.Forms.Label();
            this.speedValue = new System.Windows.Forms.Label();
            this.intensityLable = new System.Windows.Forms.Label();
            this.Intensity = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pwrstate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Preview = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.colorpicker = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rgbText = new System.Windows.Forms.Label();
            this.tabLog = new System.Windows.Forms.TabControl();
            this.tabControls = new System.Windows.Forms.TabPage();
            this.version = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.presetSave = new System.Windows.Forms.Button();
            this.presetGo = new System.Windows.Forms.Button();
            this.presetList = new System.Windows.Forms.ComboBox();
            this.syncEnable = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlers = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ipRemove = new System.Windows.Forms.Button();
            this.ipAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ipAddress = new System.Windows.Forms.TextBox();
            this.tabLogPage = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.RichTextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bightness)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Intensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Preview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.tabControls.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControlers.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabLogPage.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // bightness
            // 
            this.bightness.LargeChange = 15;
            this.bightness.Location = new System.Drawing.Point(6, 21);
            this.bightness.Maximum = 255;
            this.bightness.Name = "bightness";
            this.bightness.Size = new System.Drawing.Size(356, 56);
            this.bightness.TabIndex = 1;
            this.bightness.Scroll += new System.EventHandler(this.bightness_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // poweron
            // 
            this.poweron.Location = new System.Drawing.Point(8, 21);
            this.poweron.Name = "poweron";
            this.poweron.Size = new System.Drawing.Size(65, 39);
            this.poweron.TabIndex = 6;
            this.poweron.Text = "On";
            this.poweron.UseVisualStyleBackColor = true;
            this.poweron.Click += new System.EventHandler(this.poweron_Click);
            // 
            // poweroff
            // 
            this.poweroff.Location = new System.Drawing.Point(79, 21);
            this.poweroff.Name = "poweroff";
            this.poweroff.Size = new System.Drawing.Size(65, 39);
            this.poweroff.TabIndex = 7;
            this.poweroff.Text = "Off";
            this.poweroff.UseVisualStyleBackColor = true;
            this.poweroff.Click += new System.EventHandler(this.poweroff_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.intensityValue);
            this.groupBox1.Controls.Add(this.speedValue);
            this.groupBox1.Controls.Add(this.intensityLable);
            this.groupBox1.Controls.Add(this.Intensity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Speed);
            this.groupBox1.Controls.Add(this.bightness);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 239);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brightness";
            // 
            // intensityValue
            // 
            this.intensityValue.AutoSize = true;
            this.intensityValue.Location = new System.Drawing.Point(358, 178);
            this.intensityValue.Name = "intensityValue";
            this.intensityValue.Size = new System.Drawing.Size(16, 17);
            this.intensityValue.TabIndex = 10;
            this.intensityValue.Text = "0";
            this.intensityValue.Click += new System.EventHandler(this.label7_Click);
            // 
            // speedValue
            // 
            this.speedValue.AutoSize = true;
            this.speedValue.Location = new System.Drawing.Point(358, 104);
            this.speedValue.Name = "speedValue";
            this.speedValue.Size = new System.Drawing.Size(16, 17);
            this.speedValue.TabIndex = 9;
            this.speedValue.Text = "0";
            // 
            // intensityLable
            // 
            this.intensityLable.AutoSize = true;
            this.intensityLable.Location = new System.Drawing.Point(11, 150);
            this.intensityLable.Name = "intensityLable";
            this.intensityLable.Size = new System.Drawing.Size(60, 17);
            this.intensityLable.TabIndex = 8;
            this.intensityLable.Text = "Intensity";
            // 
            // Intensity
            // 
            this.Intensity.LargeChange = 15;
            this.Intensity.Location = new System.Drawing.Point(6, 170);
            this.Intensity.Maximum = 255;
            this.Intensity.Name = "Intensity";
            this.Intensity.Size = new System.Drawing.Size(356, 56);
            this.Intensity.TabIndex = 7;
            this.Intensity.Scroll += new System.EventHandler(this.Intensity_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Speed";
            // 
            // Speed
            // 
            this.Speed.LargeChange = 15;
            this.Speed.Location = new System.Drawing.Point(6, 97);
            this.Speed.Maximum = 255;
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(356, 56);
            this.Speed.TabIndex = 5;
            this.Speed.Scroll += new System.EventHandler(this.Speed_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pwrstate);
            this.groupBox2.Controls.Add(this.poweroff);
            this.groupBox2.Controls.Add(this.poweron);
            this.groupBox2.Location = new System.Drawing.Point(12, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 74);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Power";
            // 
            // pwrstate
            // 
            this.pwrstate.AutoSize = true;
            this.pwrstate.Location = new System.Drawing.Point(146, 29);
            this.pwrstate.Name = "pwrstate";
            this.pwrstate.Size = new System.Drawing.Size(39, 17);
            this.pwrstate.TabIndex = 8;
            this.pwrstate.Text = "state";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Preview);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(216, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 132);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Effect";
            // 
            // Preview
            // 
            this.Preview.Controls.Add(this.pictureBox1);
            this.Preview.Location = new System.Drawing.Point(6, 63);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(178, 62);
            this.Preview.TabIndex = 18;
            this.Preview.TabStop = false;
            this.Preview.Text = "Preview";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 33);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // colorpicker
            // 
            this.colorpicker.Location = new System.Drawing.Point(116, 21);
            this.colorpicker.Name = "colorpicker";
            this.colorpicker.Size = new System.Drawing.Size(76, 31);
            this.colorpicker.TabIndex = 11;
            this.colorpicker.Text = "Select";
            this.colorpicker.UseVisualStyleBackColor = true;
            this.colorpicker.Click += new System.EventHandler(this.colorpicker_Click);
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(68, 21);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(42, 31);
            this.colorBox.TabIndex = 13;
            this.colorBox.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.richTextBox2);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.rgbText);
            this.groupBox4.Controls.Add(this.colorBox);
            this.groupBox4.Controls.Add(this.colorpicker);
            this.groupBox4.Location = new System.Drawing.Point(12, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 147);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Third ";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(68, 96);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(42, 31);
            this.richTextBox2.TabIndex = 20;
            this.richTextBox2.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(116, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 31);
            this.button3.TabIndex = 19;
            this.button3.Text = "Select";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Second";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(68, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(42, 31);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Primary";
            // 
            // rgbText
            // 
            this.rgbText.AutoSize = true;
            this.rgbText.Location = new System.Drawing.Point(7, 64);
            this.rgbText.Name = "rgbText";
            this.rgbText.Size = new System.Drawing.Size(0, 17);
            this.rgbText.TabIndex = 14;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.tabControls);
            this.tabLog.Controls.Add(this.tabControlers);
            this.tabLog.Controls.Add(this.tabLogPage);
            this.tabLog.Location = new System.Drawing.Point(-1, -1);
            this.tabLog.Name = "tabLog";
            this.tabLog.SelectedIndex = 0;
            this.tabLog.Size = new System.Drawing.Size(426, 662);
            this.tabLog.TabIndex = 19;
            // 
            // tabControls
            // 
            this.tabControls.BackColor = System.Drawing.Color.Transparent;
            this.tabControls.Controls.Add(this.button4);
            this.tabControls.Controls.Add(this.version);
            this.tabControls.Controls.Add(this.groupBox6);
            this.tabControls.Controls.Add(this.syncEnable);
            this.tabControls.Controls.Add(this.comboBox2);
            this.tabControls.Controls.Add(this.label3);
            this.tabControls.Controls.Add(this.groupBox1);
            this.tabControls.Controls.Add(this.groupBox2);
            this.tabControls.Controls.Add(this.groupBox3);
            this.tabControls.Controls.Add(this.groupBox4);
            this.tabControls.Location = new System.Drawing.Point(4, 25);
            this.tabControls.Name = "tabControls";
            this.tabControls.Padding = new System.Windows.Forms.Padding(3);
            this.tabControls.Size = new System.Drawing.Size(418, 633);
            this.tabControls.TabIndex = 0;
            this.tabControls.Text = "Controls";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(317, 11);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(48, 17);
            this.version.TabIndex = 23;
            this.version.Text = "WLED";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.presetSave);
            this.groupBox6.Controls.Add(this.presetGo);
            this.groupBox6.Controls.Add(this.presetList);
            this.groupBox6.Location = new System.Drawing.Point(216, 178);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(190, 109);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Presets";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(325, 517);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // presetSave
            // 
            this.presetSave.Location = new System.Drawing.Point(7, 77);
            this.presetSave.Name = "presetSave";
            this.presetSave.Size = new System.Drawing.Size(97, 23);
            this.presetSave.TabIndex = 2;
            this.presetSave.Text = "Save Preset";
            this.presetSave.UseVisualStyleBackColor = true;
            // 
            // presetGo
            // 
            this.presetGo.Location = new System.Drawing.Point(7, 51);
            this.presetGo.Name = "presetGo";
            this.presetGo.Size = new System.Drawing.Size(97, 23);
            this.presetGo.TabIndex = 1;
            this.presetGo.Text = "Go";
            this.presetGo.UseVisualStyleBackColor = true;
            // 
            // presetList
            // 
            this.presetList.FormattingEnabled = true;
            this.presetList.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.presetList.Location = new System.Drawing.Point(7, 22);
            this.presetList.Name = "presetList";
            this.presetList.Size = new System.Drawing.Size(121, 24);
            this.presetList.TabIndex = 0;
            // 
            // syncEnable
            // 
            this.syncEnable.AutoSize = true;
            this.syncEnable.Location = new System.Drawing.Point(231, 11);
            this.syncEnable.Name = "syncEnable";
            this.syncEnable.Size = new System.Drawing.Size(61, 21);
            this.syncEnable.TabIndex = 21;
            this.syncEnable.Text = "Sync";
            this.syncEnable.UseVisualStyleBackColor = true;
            this.syncEnable.CheckedChanged += new System.EventHandler(this.syncEnable_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(81, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(143, 24);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Controler";
            // 
            // tabControlers
            // 
            this.tabControlers.BackColor = System.Drawing.Color.Transparent;
            this.tabControlers.Controls.Add(this.groupBox5);
            this.tabControlers.Controls.Add(this.ipAdd);
            this.tabControlers.Controls.Add(this.label2);
            this.tabControlers.Controls.Add(this.ipAddress);
            this.tabControlers.Location = new System.Drawing.Point(4, 25);
            this.tabControlers.Name = "tabControlers";
            this.tabControlers.Padding = new System.Windows.Forms.Padding(3);
            this.tabControlers.Size = new System.Drawing.Size(418, 633);
            this.tabControlers.TabIndex = 1;
            this.tabControlers.Text = "Controllers";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.Controls.Add(this.ipRemove);
            this.groupBox5.Location = new System.Drawing.Point(8, 69);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(284, 272);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controller List";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 212);
            this.listBox1.TabIndex = 23;
            // 
            // ipRemove
            // 
            this.ipRemove.Location = new System.Drawing.Point(198, 238);
            this.ipRemove.Name = "ipRemove";
            this.ipRemove.Size = new System.Drawing.Size(80, 28);
            this.ipRemove.TabIndex = 22;
            this.ipRemove.Text = "Remove";
            this.ipRemove.UseVisualStyleBackColor = true;
            this.ipRemove.Click += new System.EventHandler(this.ipRemove_Click);
            // 
            // ipAdd
            // 
            this.ipAdd.Location = new System.Drawing.Point(206, 42);
            this.ipAdd.Name = "ipAdd";
            this.ipAdd.Size = new System.Drawing.Size(75, 23);
            this.ipAdd.TabIndex = 21;
            this.ipAdd.Text = "Add";
            this.ipAdd.UseVisualStyleBackColor = true;
            this.ipAdd.Click += new System.EventHandler(this.ipAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "IP Address";
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(88, 14);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(193, 22);
            this.ipAddress.TabIndex = 18;
            // 
            // tabLogPage
            // 
            this.tabLogPage.BackColor = System.Drawing.Color.Transparent;
            this.tabLogPage.Controls.Add(this.groupBox7);
            this.tabLogPage.Controls.Add(this.groupBox8);
            this.tabLogPage.Location = new System.Drawing.Point(4, 25);
            this.tabLogPage.Name = "tabLogPage";
            this.tabLogPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogPage.Size = new System.Drawing.Size(418, 633);
            this.tabLogPage.TabIndex = 2;
            this.tabLogPage.Text = "Log";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.log);
            this.groupBox7.Location = new System.Drawing.Point(4, 9);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(410, 504);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Log";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(6, 21);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(400, 443);
            this.log.TabIndex = 0;
            this.log.Text = "";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Location = new System.Drawing.Point(10, 519);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(399, 108);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "About";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 34);
            this.label8.TabIndex = 3;
            this.label8.Text = "WLED Controller v1.0.0\r\nFor the Pixel Heads from Derek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 673);
            this.Controls.Add(this.tabLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WLED Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bightness)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Intensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.Preview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.tabControls.ResumeLayout(false);
            this.tabControls.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.tabControlers.ResumeLayout(false);
            this.tabControlers.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tabLogPage.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar bightness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button poweron;
        private System.Windows.Forms.Button poweroff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button colorpicker;
        private System.Windows.Forms.RichTextBox colorBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Preview;
        private System.Windows.Forms.Label rgbText;
        private System.Windows.Forms.TabControl tabLog;
        private System.Windows.Forms.TabPage tabControlers;
        private System.Windows.Forms.TabPage tabControls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipAddress;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ipRemove;
        private System.Windows.Forms.Button ipAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox syncEnable;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TabPage tabLogPage;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label intensityValue;
        private System.Windows.Forms.Label speedValue;
        private System.Windows.Forms.Label intensityLable;
        private System.Windows.Forms.TrackBar Intensity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar Speed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox presetList;
        private System.Windows.Forms.Button presetSave;
        private System.Windows.Forms.Button presetGo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label pwrstate;
        private System.Windows.Forms.Label version;
    }
}

