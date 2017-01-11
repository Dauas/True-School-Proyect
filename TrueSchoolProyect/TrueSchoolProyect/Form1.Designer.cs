namespace TrueSchoolProyect
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
        /// Bryce: "Do not modify the contents? Haha, that's a good one."
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 359);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trapped in Cyber Space";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        public void BuildMenu()
        {
            this.Play_Button = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Play_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            // 
            // Play_Button
            // 
            this.Play_Button.BackColor = System.Drawing.Color.Transparent;
            this.Play_Button.Image = global::TrueSchoolProyect.Properties.Resources.PlayButton;
            this.Play_Button.Location = new System.Drawing.Point(11, 403);
            this.Play_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Play_Button.Name = "Play_Button";
            this.Play_Button.Size = new System.Drawing.Size(320, 120);
            this.Play_Button.TabIndex = 0;
            this.Play_Button.TabStop = false;
            this.Play_Button.Click += new System.EventHandler(this.Play_Button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::TrueSchoolProyect.Properties.Resources.ExitButton_png;
            this.pictureBox2.Location = new System.Drawing.Point(470, 403);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 120);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::TrueSchoolProyect.Properties.Resources.RecordsButtonFixed;
            this.pictureBox3.Location = new System.Drawing.Point(11, 231);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(320, 120);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.Records_Click);
            //
            // Form Stuffs
            //
            this.ClientSize = new System.Drawing.Size(780, 558);
            this.BackgroundImage = global::TrueSchoolProyect.Properties.Resources.GameMenuBackdropFixed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Play_Button);
            ((System.ComponentModel.ISupportInitialize)(this.Play_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
        }
        public void ClearMenu()
        {
            Play_Button.Dispose();
            pictureBox2.Dispose();
            pictureBox3.Dispose();
            this.BackgroundImage = null;
        }
        public void BuildTextZone()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();

            // 
            // textBox1
            // 
            //this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Enabled = false;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(7, 528);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(767, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            //
            //this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Enabled = false;
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.Location = new System.Drawing.Point(7, 506);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(767, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            //this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Enabled = false;
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(7, 484);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(767, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            //this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Enabled = false;
            this.textBox4.BackColor = System.Drawing.Color.Silver;
            this.textBox4.Location = new System.Drawing.Point(7, 462);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(767, 22);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            //
            //this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Enabled = false;
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(7, 440);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(767, 22);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // Form Stuff
            //
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            //
            // Extra Stuff
            //
            //InitializeTZ();
        }
        public void ClearTextZone()
        {
            //tblist.Clear();
            textBox1.Dispose();
            textBox2.Dispose();
            textBox3.Dispose();
            textBox4.Dispose();
            textBox5.Dispose();
        }
        public void BuildTestGame()
        {
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.HealthCounter = new System.Windows.Forms.TextBox();
            this.HealthPotButton = new System.Windows.Forms.PictureBox();
            this.AttackButton = new System.Windows.Forms.PictureBox();
            this.TurnRightBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TurnRightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthPotButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackButton)).BeginInit();
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(7, 214);
            this.HealthBar.Enabled = false;
            this.HealthBar.Margin = new System.Windows.Forms.Padding(4);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(767, 28);
            this.HealthBar.TabIndex = 11;
            this.HealthBar.Value = 100;
            // 
            // HealthCounter
            // 
            this.HealthCounter.Location = new System.Drawing.Point(344, 214);
            this.HealthCounter.ForeColor = System.Drawing.Color.Black;
            this.HealthCounter.Enabled = false;
            this.HealthCounter.Margin = new System.Windows.Forms.Padding(4);
            this.HealthCounter.Name = "HealthCounter";
            this.HealthCounter.Size = new System.Drawing.Size(132, 28);
            this.HealthCounter.TabIndex = 12;
            this.HealthCounter.Text = "100/100";
            this.HealthCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HealthCounter.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // HealthPotButton
            // 
            this.HealthPotButton.BackgroundImage = global::TrueSchoolProyect.Properties.Resources.HealthPotionTemp;
            this.HealthPotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HealthPotButton.Location = new System.Drawing.Point(300, 0);
            this.HealthPotButton.Name = "HealthPotButton";
            this.HealthPotButton.Size = new System.Drawing.Size(200, 200);
            this.HealthPotButton.TabIndex = 13;
            this.HealthPotButton.TabStop = false;
            //this.HealthPotButton.Click += new System.EventHandler(this.HealthPotButton_Click);
            // 
            // AttackButton
            // 
            this.AttackButton.BackgroundImage = global::TrueSchoolProyect.Properties.Resources.SimpleRiotFist;
            this.AttackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AttackButton.Location = new System.Drawing.Point(300, 230);
            this.AttackButton.Margin = new System.Windows.Forms.Padding(4);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(200, 200);
            this.AttackButton.TabIndex = 10;
            this.AttackButton.TabStop = false;
            //this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click);
            // 
            // TurnRightBox
            // 
            this.TurnRightBox.Image = global::TrueSchoolProyect.Properties.Resources.RightPointTriangle;
            this.TurnRightBox.Location = new System.Drawing.Point(650, 100);
            this.TurnRightBox.Name = "TurnRightBox";
            this.TurnRightBox.Size = new System.Drawing.Size(100, 100);
            this.TurnRightBox.TabIndex = 0;
            this.TurnRightBox.TabStop = false;
            this.TurnRightBox.Click += new System.EventHandler(this.TurnRightBox_Click);
            //
            // Form Stuff
            //
            this.Controls.Add(this.HealthCounter);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.AttackButton);
            this.Controls.Add(this.HealthPotButton);
            this.Controls.Add(this.TurnRightBox);
            ((System.ComponentModel.ISupportInitialize)(this.HealthPotButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnRightBox)).EndInit();
        }
        public void ClearTestGame()
        {
            HealthBar.Dispose();
            HealthCounter.Dispose();
            HealthPotButton.Dispose();
            AttackButton.Dispose();
            TurnRightBox.Dispose();
        }
        public void BuildPlayer()
        {
            //Break Down on Declaring Objects
            //Object Class (Player) - Name of Object (player) - Declaration (new) - Constructor (Player()) //~Brice
            Player player = new Player();
            //Add a Reader here
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrueSchoolProyect.Properties.Resources.PlacementPlayer1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            //
            // Form Stuff
            //
            this.Controls.Add(this.pictureBox1);

        }
        public void ClearPlayer()
        {
            //Add a Writer here
            pictureBox1.Dispose();
        }
        public void BuildPause()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            //this.button2.Click += new System.EventHandler(this.button2_Click);
            //
            // Form Stuff
            //
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
        }
        public void ClearPause()
        {
            button1.Dispose();
            button2.Dispose();
        }
        public void BuildCAT5()
        {
            
            //
            // Initialize
            //
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t1p3 = new System.Windows.Forms.PictureBox();
            this.t1p4 = new System.Windows.Forms.PictureBox();
            this.t1p5 = new System.Windows.Forms.PictureBox();
            this.t1p6 = new System.Windows.Forms.PictureBox();
            this.t1p7 = new System.Windows.Forms.PictureBox();
            this.t1p8 = new System.Windows.Forms.PictureBox();
            this.t2p1 = new System.Windows.Forms.PictureBox();
            this.t2p2 = new System.Windows.Forms.PictureBox();
            this.t2p3 = new System.Windows.Forms.PictureBox();
            this.t2p4 = new System.Windows.Forms.PictureBox();
            this.t2p5 = new System.Windows.Forms.PictureBox();
            this.t2p6 = new System.Windows.Forms.PictureBox();
            this.t2p7 = new System.Windows.Forms.PictureBox();
            this.t2p8 = new System.Windows.Forms.PictureBox();
            this.blue1 = new System.Windows.Forms.PictureBox();
            this.brown1 = new System.Windows.Forms.PictureBox();
            this.green1 = new System.Windows.Forms.PictureBox();
            this.orange1 = new System.Windows.Forms.PictureBox();
            this.whiteBlue1 = new System.Windows.Forms.PictureBox();
            this.whiteBrown1 = new System.Windows.Forms.PictureBox();
            this.whiteGreen1 = new System.Windows.Forms.PictureBox();
            this.whiteOrange1 = new System.Windows.Forms.PictureBox();
            this.t1p1 = new System.Windows.Forms.PictureBox();
            this.bt_Submit = new System.Windows.Forms.Button();
            this.tb_Colors = new System.Windows.Forms.TextBox();
            this.tb_Terminal = new System.Windows.Forms.TextBox();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.t1p2 = new System.Windows.Forms.PictureBox();
            this.tb_Clicks = new System.Windows.Forms.TextBox();
            this.bt_Hint = new System.Windows.Forms.PictureBox();
            this.lb_t1p1 = new System.Windows.Forms.Label();
            this.lb_Hint = new System.Windows.Forms.Label();
            this.tb_instructions = new System.Windows.Forms.TextBox();
            this.lb_instructions = new System.Windows.Forms.Label();
            this.tb_Results = new System.Windows.Forms.TextBox();
            this.lb_clicks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t1p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1p6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1p7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1p8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2p6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2p7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2p8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBlue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBrown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteGreen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteOrange1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Hint)).BeginInit();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(123, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Terminal 1 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(469, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Terminal 2";
            // 
            // t1p3
            // 
            this.t1p3.AccessibleName = "t1p3";
            this.t1p3.Location = new System.Drawing.Point(112, 212);
            this.t1p3.Name = "t1p3";
            this.t1p3.Size = new System.Drawing.Size(25, 217);
            this.t1p3.TabIndex = 4;
            this.t1p3.TabStop = false;
            this.t1p3.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.t1p3.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            // 
            // t1p4
            // 
            this.t1p4.Location = new System.Drawing.Point(148, 212);
            this.t1p4.Name = "t1p4";
            this.t1p4.Size = new System.Drawing.Size(25, 217);
            this.t1p4.TabIndex = 5;
            this.t1p4.TabStop = false;
            this.t1p4.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.t1p4.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            // 
            // t1p5
            // 
            this.t1p5.Location = new System.Drawing.Point(184, 212);
            this.t1p5.Name = "t1p5";
            this.t1p5.Size = new System.Drawing.Size(25, 217);
            this.t1p5.TabIndex = 6;
            this.t1p5.TabStop = false;
            this.t1p5.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.t1p5.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            // 
            // t1p6
            // 
            this.t1p6.Location = new System.Drawing.Point(221, 212);
            this.t1p6.Name = "t1p6";
            this.t1p6.Size = new System.Drawing.Size(25, 217);
            this.t1p6.TabIndex = 7;
            this.t1p6.TabStop = false;
            this.t1p6.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.t1p6.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            // 
            // t1p7
            // 
            this.t1p7.Location = new System.Drawing.Point(256, 212);
            this.t1p7.Name = "t1p7";
            this.t1p7.Size = new System.Drawing.Size(25, 217);
            this.t1p7.TabIndex = 8;
            this.t1p7.TabStop = false;
            this.t1p7.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.t1p7.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            // 
            // t1p8
            // 
            this.t1p8.Location = new System.Drawing.Point(293, 212);
            this.t1p8.Name = "t1p8";
            this.t1p8.Size = new System.Drawing.Size(25, 217);
            this.t1p8.TabIndex = 9;
            this.t1p8.TabStop = false;
            this.t1p8.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.t1p8.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            // 
            // t2p1
            // 
            this.t2p1.Location = new System.Drawing.Point(380, 212);
            this.t2p1.Name = "t2p1";
            this.t2p1.Size = new System.Drawing.Size(25, 217);
            this.t2p1.TabIndex = 10;
            this.t2p1.TabStop = false;
            this.t2p1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.t2p1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            // 
            // t2p2
            // 
            this.t2p2.Location = new System.Drawing.Point(415, 212);
            this.t2p2.Name = "t2p2";
            this.t2p2.Size = new System.Drawing.Size(25, 217);
            this.t2p2.TabIndex = 11;
            this.t2p2.TabStop = false;
            this.t2p2.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.t2p2.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            // 
            // t2p3
            // 
            this.t2p3.Location = new System.Drawing.Point(453, 212);
            this.t2p3.Name = "t2p3";
            this.t2p3.Size = new System.Drawing.Size(25, 217);
            this.t2p3.TabIndex = 12;
            this.t2p3.TabStop = false;
            this.t2p3.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.t2p3.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            // 
            // t2p4
            // 
            this.t2p4.Location = new System.Drawing.Point(489, 212);
            this.t2p4.Name = "t2p4";
            this.t2p4.Size = new System.Drawing.Size(25, 217);
            this.t2p4.TabIndex = 13;
            this.t2p4.TabStop = false;
            this.t2p4.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.t2p4.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            // 
            // t2p5
            // 
            this.t2p5.Location = new System.Drawing.Point(524, 212);
            this.t2p5.Name = "t2p5";
            this.t2p5.Size = new System.Drawing.Size(25, 217);
            this.t2p5.TabIndex = 14;
            this.t2p5.TabStop = false;
            this.t2p5.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.t2p5.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            // 
            // t2p6
            // 
            this.t2p6.Location = new System.Drawing.Point(560, 212);
            this.t2p6.Name = "t2p6";
            this.t2p6.Size = new System.Drawing.Size(25, 217);
            this.t2p6.TabIndex = 15;
            this.t2p6.TabStop = false;
            this.t2p6.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.t2p6.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            // 
            // t2p7
            // 
            this.t2p7.Location = new System.Drawing.Point(595, 212);
            this.t2p7.Name = "t2p7";
            this.t2p7.Size = new System.Drawing.Size(25, 217);
            this.t2p7.TabIndex = 16;
            this.t2p7.TabStop = false;
            this.t2p7.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.t2p7.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            // 
            // t2p8
            // 
            this.t2p8.Location = new System.Drawing.Point(632, 212);
            this.t2p8.Name = "t2p8";
            this.t2p8.Size = new System.Drawing.Size(25, 217);
            this.t2p8.TabIndex = 17;
            this.t2p8.TabStop = false;
            this.t2p8.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.t2p8.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            // 
            // blue1
            // 
            this.blue1.Image = global::TrueSchoolProyect.Properties.Resources.blue1;
            this.blue1.Location = new System.Drawing.Point(221, 507);
            this.blue1.Name = "blue1";
            this.blue1.Size = new System.Drawing.Size(25, 35);
            this.blue1.TabIndex = 18;
            this.blue1.TabStop = false;
            this.blue1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragDrop_MouseDown);
            // 
            // brown1
            // 
            this.brown1.Image = global::TrueSchoolProyect.Properties.Resources.brown1;
            this.brown1.Location = new System.Drawing.Point(257, 507);
            this.brown1.Name = "brown1";
            this.brown1.Size = new System.Drawing.Size(25, 35);
            this.brown1.TabIndex = 20;
            this.brown1.TabStop = false;
            this.brown1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragDrop_MouseDown);
            // 
            // green1
            // 
            this.green1.Image = global::TrueSchoolProyect.Properties.Resources.green1;
            this.green1.Location = new System.Drawing.Point(292, 507);
            this.green1.Name = "green1";
            this.green1.Size = new System.Drawing.Size(25, 35);
            this.green1.TabIndex = 22;
            this.green1.TabStop = false;
            this.green1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragDrop_MouseDown);
            // 
            // orange1
            // 
            this.orange1.Image = global::TrueSchoolProyect.Properties.Resources.orange1;
            this.orange1.Location = new System.Drawing.Point(328, 507);
            this.orange1.Name = "orange1";
            this.orange1.Size = new System.Drawing.Size(25, 35);
            this.orange1.TabIndex = 24;
            this.orange1.TabStop = false;
            this.orange1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragDrop_MouseDown);
            // 
            // whiteBlue1
            // 
            this.whiteBlue1.Image = global::TrueSchoolProyect.Properties.Resources.whiteBlue1;
            this.whiteBlue1.Location = new System.Drawing.Point(364, 507);
            this.whiteBlue1.Name = "whiteBlue1";
            this.whiteBlue1.Size = new System.Drawing.Size(25, 35);
            this.whiteBlue1.TabIndex = 26;
            this.whiteBlue1.TabStop = false;
            this.whiteBlue1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragDrop_MouseDown);
            // 
            // whiteBrown1
            // 
            this.whiteBrown1.Image = global::TrueSchoolProyect.Properties.Resources.whiteBrown1;
            this.whiteBrown1.Location = new System.Drawing.Point(401, 507);
            this.whiteBrown1.Name = "whiteBrown1";
            this.whiteBrown1.Size = new System.Drawing.Size(25, 35);
            this.whiteBrown1.TabIndex = 28;
            this.whiteBrown1.TabStop = false;
            this.whiteBrown1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragDrop_MouseDown);
            // 
            // whiteGreen1
            // 
            this.whiteGreen1.Image = global::TrueSchoolProyect.Properties.Resources.whiteGreen1;
            this.whiteGreen1.Location = new System.Drawing.Point(436, 507);
            this.whiteGreen1.Name = "whiteGreen1";
            this.whiteGreen1.Size = new System.Drawing.Size(25, 35);
            this.whiteGreen1.TabIndex = 30;
            this.whiteGreen1.TabStop = false;
            this.whiteGreen1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragDrop_MouseDown);
            // 
            // whiteOrange1
            // 
            this.whiteOrange1.Image = global::TrueSchoolProyect.Properties.Resources.whiteOrange1;
            this.whiteOrange1.Location = new System.Drawing.Point(473, 507);
            this.whiteOrange1.Name = "whiteOrange1";
            this.whiteOrange1.Size = new System.Drawing.Size(25, 35);
            this.whiteOrange1.TabIndex = 32;
            this.whiteOrange1.TabStop = false;
            this.whiteOrange1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragDrop_MouseDown);
            // 
            // t1p1
            // 
            this.t1p1.Location = new System.Drawing.Point(41, 212);
            this.t1p1.Name = "t1p1";
            this.t1p1.Size = new System.Drawing.Size(25, 217);
            this.t1p1.TabIndex = 34;
            this.t1p1.TabStop = false;
            this.t1p1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.t1p1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            // 
            // bt_Submit
            // 
            this.bt_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Submit.Location = new System.Drawing.Point(221, 467);
            this.bt_Submit.Name = "bt_Submit";
            this.bt_Submit.Size = new System.Drawing.Size(132, 20);
            this.bt_Submit.TabIndex = 35;
            this.bt_Submit.Text = "Submit";
            this.bt_Submit.UseVisualStyleBackColor = true;
            this.bt_Submit.Click += new System.EventHandler(this.bt_Submit_Click);
            // 
            // tb_Colors
            // 
            this.tb_Colors.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Colors.HideSelection = false;
            this.tb_Colors.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_Colors.Location = new System.Drawing.Point(560, 12);
            this.tb_Colors.Multiline = true;
            this.tb_Colors.Name = "tb_Colors";
            this.tb_Colors.Size = new System.Drawing.Size(100, 20);
            this.tb_Colors.TabIndex = 36;
            this.tb_Colors.Text = "COLORS!";
            // 
            // tb_Terminal
            // 
            this.tb_Terminal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Terminal.Location = new System.Drawing.Point(560, 39);
            this.tb_Terminal.Name = "tb_Terminal";
            this.tb_Terminal.Size = new System.Drawing.Size(100, 20);
            this.tb_Terminal.TabIndex = 37;
            this.tb_Terminal.TabStop = false;
            this.tb_Terminal.Text = "TERMINAL LOC";
            // 
            // bt_Reset
            // 
            this.bt_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Reset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Reset.Location = new System.Drawing.Point(366, 467);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(132, 20);
            this.bt_Reset.TabIndex = 38;
            this.bt_Reset.Text = "Reset";
            this.bt_Reset.UseVisualStyleBackColor = true;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // t1p2
            // 
            this.t1p2.Location = new System.Drawing.Point(77, 212);
            this.t1p2.Name = "t1p2";
            this.t1p2.Size = new System.Drawing.Size(25, 217);
            this.t1p2.TabIndex = 39;
            this.t1p2.TabStop = false;
            this.t1p2.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragDrop);
            this.t1p2.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDrop_DragEnter);
            // 
            // tb_Clicks
            // 
            this.tb_Clicks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Clicks.HideSelection = false;
            this.tb_Clicks.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_Clicks.Location = new System.Drawing.Point(560, 65);
            this.tb_Clicks.Multiline = true;
            this.tb_Clicks.Name = "tb_Clicks";
            this.tb_Clicks.Size = new System.Drawing.Size(100, 20);
            this.tb_Clicks.TabIndex = 40;
            this.tb_Clicks.Text = "CLICKS!";
            // 
            // bt_Hint
            // 
            this.bt_Hint.Image = global::TrueSchoolProyect.Properties.Resources.bt_Hint;
            this.bt_Hint.Location = new System.Drawing.Point(585, 467);
            this.bt_Hint.Name = "bt_Hint";
            this.bt_Hint.Size = new System.Drawing.Size(72, 75);
            this.bt_Hint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_Hint.TabIndex = 41;
            this.bt_Hint.TabStop = false;
            this.bt_Hint.Click += new System.EventHandler(this.bt_Hint_Click);
            // 
            // lb_t1p1
            // 
            this.lb_t1p1.AutoSize = true;
            this.lb_t1p1.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_t1p1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lb_t1p1.Location = new System.Drawing.Point(253, 92);
            this.lb_t1p1.Name = "lb_t1p1";
            this.lb_t1p1.Size = new System.Drawing.Size(47, 23);
            this.lb_t1p1.TabIndex = 43;
            this.lb_t1p1.Text = "Hint";
            this.lb_t1p1.Visible = false;
            // 
            // lb_Hint
            // 
            this.lb_Hint.AutoSize = true;
            this.lb_Hint.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_Hint.Location = new System.Drawing.Point(57, 54);
            this.lb_Hint.Name = "lb_Hint";
            this.lb_Hint.Size = new System.Drawing.Size(528, 21);
            this.lb_Hint.TabIndex = 44;
            this.lb_Hint.Text = "Hover over each cell of the terminal and the hint will be revealed...";
            this.lb_Hint.Visible = false;
            // 
            // tb_instructions
            // 
            this.tb_instructions.ForeColor = System.Drawing.Color.Black;
            this.tb_instructions.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_instructions.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_instructions.Location = new System.Drawing.Point(12, 30);
            this.tb_instructions.Multiline = true;
            this.tb_instructions.Name = "tb_instructions";
            this.tb_instructions.Size = new System.Drawing.Size(664, 89);
            this.tb_instructions.TabIndex = 45;
            // 
            // lb_instructions
            // 
            this.tb_instructions.ForeColor = System.Drawing.Color.Black;
            this.lb_instructions.AutoSize = true;
            this.lb_instructions.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_instructions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_instructions.Location = new System.Drawing.Point(280, -1);
            this.lb_instructions.Name = "lb_instructions";
            this.lb_instructions.Size = new System.Drawing.Size(125, 23);
            this.lb_instructions.TabIndex = 46;
            this.lb_instructions.Text = "Instructions ";
            // 
            // tb_Results
            // 
            this.tb_Results.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Results.Location = new System.Drawing.Point(127, 122);
            this.tb_Results.Multiline = true;
            this.tb_Results.Name = "tb_Results";
            this.tb_Results.Size = new System.Drawing.Size(467, 36);
            this.tb_Results.TabIndex = 47;
            this.tb_Results.Text = "Test";
            this.tb_Results.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Results.Visible = false;
            // 
            // lb_clicks
            // 
            this.lb_clicks.AutoSize = true;
            this.lb_clicks.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clicks.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_clicks.Location = new System.Drawing.Point(571, 9);
            this.lb_clicks.Name = "lb_clicks";
            this.lb_clicks.Size = new System.Drawing.Size(60, 19);
            this.lb_clicks.TabIndex = 48;
            this.lb_clicks.Text = "CLICKS";
            this.lb_clicks.Visible = false;
            //
            // Form Stuff
            //
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::TrueSchoolProyect.Properties.Resources.Inna_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(688, 563);
            this.Controls.Add(this.lb_clicks);
            this.Controls.Add(this.tb_Results);
            this.Controls.Add(this.lb_instructions);
            this.Controls.Add(this.tb_instructions);
            this.Controls.Add(this.lb_Hint);
            this.Controls.Add(this.lb_t1p1);
            this.Controls.Add(this.bt_Hint);
            this.Controls.Add(this.tb_Clicks);
            this.Controls.Add(this.t1p2);
            this.Controls.Add(this.bt_Reset);
            this.Controls.Add(this.tb_Terminal);
            this.Controls.Add(this.tb_Colors);
            this.Controls.Add(this.bt_Submit);
            this.Controls.Add(this.t1p1);
            this.Controls.Add(this.t2p8);
            this.Controls.Add(this.t2p7);
            this.Controls.Add(this.t2p6);
            this.Controls.Add(this.t2p5);
            this.Controls.Add(this.t2p4);
            this.Controls.Add(this.t2p3);
            this.Controls.Add(this.t2p2);
            this.Controls.Add(this.t2p1);
            this.Controls.Add(this.t1p8);
            this.Controls.Add(this.t1p7);
            this.Controls.Add(this.t1p6);
            this.Controls.Add(this.t1p5);
            this.Controls.Add(this.t1p4);
            this.Controls.Add(this.t1p3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blue1);
            this.Controls.Add(this.brown1);
            this.Controls.Add(this.green1);
            this.Controls.Add(this.orange1);
            this.Controls.Add(this.whiteBlue1);
            this.Controls.Add(this.whiteBrown1);
            this.Controls.Add(this.whiteGreen1);
            this.Controls.Add(this.whiteOrange1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaximizeBox = false;
            //this.Name = "Form1";
            //this.Text = "Escape From Cyber Space";
            //this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t1p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1p6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1p7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1p8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2p6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2p7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2p8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBlue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBrown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteGreen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteOrange1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Hint)).EndInit();
            //
            EnableDrop();
        }
        public void ClearCAT5()
        {
            label1.Dispose();
            label2.Dispose();
            t1p1.Dispose();
            t1p2.Dispose();
            t1p3.Dispose();
            t1p4.Dispose();
            t1p5.Dispose();
            t1p6.Dispose();
            t1p7.Dispose();
            t1p8.Dispose();
            t2p1.Dispose();
            t2p2.Dispose();
            t2p3.Dispose();
            t2p4.Dispose();
            t2p5.Dispose();
            t2p6.Dispose();
            t2p7.Dispose();
            t2p8.Dispose();
            blue1.Dispose();
            brown1.Dispose();
            green1.Dispose();
            orange1.Dispose();
            whiteBlue1.Dispose();
            whiteBrown1.Dispose();
            whiteGreen1.Dispose();
            whiteOrange1.Dispose();
            bt_Submit.Dispose();
            bt_Reset.Dispose();
            tb_Colors.Dispose();
            tb_Terminal.Dispose();
            tb_Clicks.Dispose();
            bt_Hint.Dispose();
            lb_t1p1.Dispose();
            lb_Hint.Dispose();
            tb_instructions.Dispose();
            lb_instructions.Dispose();
            tb_Results.Dispose();
            lb_clicks.Dispose();

        }
        public void BuildDesktop()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ClientSize = new System.Drawing.Size(953, 524);
            this.Taskbar = new System.Windows.Forms.PictureBox();
            this.startborder = new System.Windows.Forms.PictureBox();
            this.TaskbarStart = new System.Windows.Forms.Button();
            this.Enemybt = new System.Windows.Forms.Button();
            this.instructions1 = new System.Windows.Forms.Label();
            this.healthzone = new System.Windows.Forms.PictureBox();
            this.instructions2 = new System.Windows.Forms.Label();
            this.Enemy = new System.Windows.Forms.TextBox();
            this.You = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folder1 = new System.Windows.Forms.PictureBox();
            this.folder2 = new System.Windows.Forms.PictureBox();
            this.folder3 = new System.Windows.Forms.PictureBox();
            this.folder4 = new System.Windows.Forms.PictureBox();
            this.folder5 = new System.Windows.Forms.PictureBox();
            this.folder6 = new System.Windows.Forms.PictureBox();
            this.folder7 = new System.Windows.Forms.PictureBox();
            this.folder8 = new System.Windows.Forms.PictureBox();
            this.Virushealth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Taskbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startborder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthzone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folder3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folder4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folder5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folder6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folder7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folder8)).BeginInit();
            this.SuspendLayout();
            // 
            // Taskbar
            // 
            this.Taskbar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Taskbar.BackgroundImage = global::TrueSchoolProyect.Properties.Resources.TaskbarBackgroundImage;
            this.Taskbar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Taskbar.Location = new System.Drawing.Point(-8, 491);
            this.Taskbar.Name = "Taskbar";
            this.Taskbar.Size = new System.Drawing.Size(1095, 52);
            this.Taskbar.TabIndex = 0;
            this.Taskbar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.startborder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startborder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.startborder.Location = new System.Drawing.Point(-8, 491);
            this.startborder.Name = "pictureBox1";
            this.startborder.Size = new System.Drawing.Size(149, 41);
            this.startborder.TabIndex = 1;
            this.startborder.TabStop = false;
            // 
            // TaskbarStart
            // 
            this.TaskbarStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TaskbarStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TaskbarStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TaskbarStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskbarStart.Location = new System.Drawing.Point(4, 491);
            this.TaskbarStart.Name = "TaskbarStart";
            this.TaskbarStart.Size = new System.Drawing.Size(128, 40);
            this.TaskbarStart.TabIndex = 2;
            this.TaskbarStart.Text = "START";
            this.TaskbarStart.UseVisualStyleBackColor = false;
            // 
            // Enemybt
            // 
            this.Enemybt.BackColor = System.Drawing.Color.Transparent;
            this.Enemybt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Enemybt.Image = global::TrueSchoolProyect.Properties.Resources.Enemybt;
            this.Enemybt.Location = new System.Drawing.Point(607, -78);
            this.Enemybt.Name = "Enemybt";
            this.Enemybt.Size = new System.Drawing.Size(347, 839);
            this.Enemybt.TabIndex = 4;
            this.Enemybt.Text = "VIRUS";
            this.Enemybt.UseVisualStyleBackColor = false;
            this.Enemybt.Click += new System.EventHandler(this.Enemybt_Click);
            // 
            // label1
            // 
            this.instructions1.AutoSize = true;
            this.instructions1.ForeColor = System.Drawing.Color.Black;
            this.instructions1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions1.Location = new System.Drawing.Point(12, 172);
            this.instructions1.Name = "instructions1";
            this.instructions1.Size = new System.Drawing.Size(174, 105);
            this.instructions1.TabIndex = 5;
            this.instructions1.Text = "Welcome to Room #1! \r\nThis is your desktop and\r\na virus has hold you captive.\r\nIn" +
    " order to escape and move\r\non you must eliminate him\r\nbefore he eliminates you.\r" +
    "\n\r\n";
            this.instructions1.Click += new System.EventHandler(this.instructions1_Click);
            // 
            // pictureBox3
            // 
            this.healthzone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.healthzone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.healthzone.Location = new System.Drawing.Point(-8, 156);
            this.healthzone.Name = "healthzone";
            this.healthzone.Size = new System.Drawing.Size(301, 336);
            this.healthzone.TabIndex = 6;
            this.healthzone.TabStop = false;
            // 
            // label2
            // 
            this.instructions2.AutoSize = true;
            this.instructions2.ForeColor = System.Drawing.Color.Black;
            this.instructions2.Font = new System.Drawing.Font("Cambria Math", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions2.Location = new System.Drawing.Point(14, 277);
            this.instructions2.Name = "instructions2";
            this.instructions2.Size = new System.Drawing.Size(172, 122);
            this.instructions2.TabIndex = 16;
            this.instructions2.Text = "Hint: You can check your folder\r\n files to find possible health.";
            this.instructions2.Click += new System.EventHandler(this.instructions2_Click);
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Enemy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enemy.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enemy.ForeColor = System.Drawing.Color.Red;
            this.Enemy.Location = new System.Drawing.Point(671, 491);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(208, 40);
            this.Enemy.TabIndex = 17;
            this.Enemy.Text = "100";
            this.Enemy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // You
            // 
            this.You.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.You.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.You.Location = new System.Drawing.Point(84, 432);
            this.You.Name = "You";
            this.You.Size = new System.Drawing.Size(100, 40);
            this.You.TabIndex = 18;
            this.You.Text = "100";
            this.You.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.You.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(94, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "Your Health";
            // 
            // folder1
            // 
            this.folder1.Image = global::TrueSchoolProyect.Properties.Resources.folder;
            this.folder1.Location = new System.Drawing.Point(15, 27);
            this.folder1.Name = "folder1";
            this.folder1.Size = new System.Drawing.Size(51, 50);
            this.folder1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.folder1.TabIndex = 20;
            this.folder1.TabStop = false;
            this.folder1.Click += new System.EventHandler(this.folder1_Click);
            // 
            // folder2
            // 
            this.folder2.Image = global::TrueSchoolProyect.Properties.Resources.folder;
            this.folder2.Location = new System.Drawing.Point(81, 27);
            this.folder2.Name = "folder2";
            this.folder2.Size = new System.Drawing.Size(51, 50);
            this.folder2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.folder2.TabIndex = 21;
            this.folder2.TabStop = false;
            this.folder2.Click += new System.EventHandler(this.folder2_Click);
            // 
            // folder3
            // 
            this.folder3.Image = global::TrueSchoolProyect.Properties.Resources.folder;
            this.folder3.Location = new System.Drawing.Point(148, 27);
            this.folder3.Name = "folder3";
            this.folder3.Size = new System.Drawing.Size(51, 50);
            this.folder3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.folder3.TabIndex = 22;
            this.folder3.TabStop = false;
            this.folder3.Click += new System.EventHandler(this.folder3_Click);
            // 
            // folder4
            // 
            this.folder4.Image = global::TrueSchoolProyect.Properties.Resources.folder;
            this.folder4.Location = new System.Drawing.Point(215, 27);
            this.folder4.Name = "folder4";
            this.folder4.Size = new System.Drawing.Size(51, 50);
            this.folder4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.folder4.TabIndex = 23;
            this.folder4.TabStop = false;
            this.folder4.Click += new System.EventHandler(this.folder4_Click);
            // 
            // folder5
            // 
            this.folder5.Image = global::TrueSchoolProyect.Properties.Resources.folder;
            this.folder5.Location = new System.Drawing.Point(284, 27);
            this.folder5.Name = "folder5";
            this.folder5.Size = new System.Drawing.Size(51, 50);
            this.folder5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.folder5.TabIndex = 24;
            this.folder5.TabStop = false;
            this.folder5.Click += new System.EventHandler(this.folder5_Click);
            // 
            // folder6
            // 
            this.folder6.Image = global::TrueSchoolProyect.Properties.Resources.folder;
            this.folder6.Location = new System.Drawing.Point(352, 27);
            this.folder6.Name = "folder6";
            this.folder6.Size = new System.Drawing.Size(51, 50);
            this.folder6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.folder6.TabIndex = 25;
            this.folder6.TabStop = false;
            this.folder6.Click += new System.EventHandler(this.folder6_Click);
            // 
            // folder7
            // 
            this.folder7.Image = global::TrueSchoolProyect.Properties.Resources.folder;
            this.folder7.Location = new System.Drawing.Point(421, 27);
            this.folder7.Name = "folder7";
            this.folder7.Size = new System.Drawing.Size(51, 50);
            this.folder7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.folder7.TabIndex = 26;
            this.folder7.TabStop = false;
            this.folder7.Click += new System.EventHandler(this.folder7_Click);
            // 
            // folder8
            // 
            this.folder8.Image = global::TrueSchoolProyect.Properties.Resources.folder;
            this.folder8.Location = new System.Drawing.Point(488, 27);
            this.folder8.Name = "folder8";
            this.folder8.Size = new System.Drawing.Size(51, 50);
            this.folder8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.folder8.TabIndex = 27;
            this.folder8.TabStop = false;
            this.folder8.Click += new System.EventHandler(this.folder8_Click);
            // 
            // Virushealth
            // 
            this.Virushealth.AutoSize = true;
            this.Virushealth.ForeColor = System.Drawing.Color.DarkRed;
            this.Virushealth.Location = new System.Drawing.Point(871, 510);
            this.Virushealth.Name = "Virushealth";
            this.Virushealth.Size = new System.Drawing.Size(83, 14);
            this.Virushealth.TabIndex = 28;
            this.Virushealth.Text = "Enemy Health";
            //
            // Desktop
            //
             this.Controls.Add(this.Virushealth);
            this.Controls.Add(this.folder8);
            this.Controls.Add(this.folder7);
            this.Controls.Add(this.folder6);
            this.Controls.Add(this.folder5);
            this.Controls.Add(this.folder4);
            this.Controls.Add(this.folder3);
            this.Controls.Add(this.folder2);
            this.Controls.Add(this.folder1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.You);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.instructions2);
            this.Controls.Add(this.instructions1);
            this.Controls.Add(this.TaskbarStart);
            this.Controls.Add(this.startborder);
            this.Controls.Add(this.Taskbar);
            this.Controls.Add(this.healthzone);
            this.Controls.Add(this.Enemybt);
            this.BackColor = System.Drawing.Color.White;

            OnBuild();
        }
        public void ClearDesktopZone()
        {
            this.Taskbar.Dispose();
            this.startborder.Dispose();
            this.TaskbarStart.Dispose();
            this.Enemybt.Dispose();
            this.instructions1.Dispose();
            this.healthzone.Dispose();
            this.instructions2.Dispose();
            this.Enemy.Dispose();
            this.You.Dispose();
            this.label3.Dispose();
            this.folder1.Dispose();
            this.folder2.Dispose();
            this.folder3.Dispose();
            this.folder4.Dispose();
            this.folder5.Dispose();
            this.folder6.Dispose();
            this.folder7.Dispose();
            this.folder8.Dispose();
            this.Virushealth.Dispose();
        }
        public void BuildSearch()
        {
            this.SecurityKeyTB = new System.Windows.Forms.Label();
            this.FireWallTb = new System.Windows.Forms.Label();
            this.ComputerChipsTB = new System.Windows.Forms.Label();
            this.HeadphoneJackTB = new System.Windows.Forms.Label();
            this.LibraryFileTB = new System.Windows.Forms.Label();
            this.BatteryTB = new System.Windows.Forms.Label();
            this.MalwearTB = new System.Windows.Forms.Label();
            this.TheWebTB = new System.Windows.Forms.Label();
            this.WordDocTB = new System.Windows.Forms.Label();
            this.TheCloudTB = new System.Windows.Forms.Label();
            this.BrokenLinkTB = new System.Windows.Forms.Label();
            this.WordDocBT = new System.Windows.Forms.PictureBox();
            this.VirusPb = new System.Windows.Forms.PictureBox();
            this.Fire_WallBT = new System.Windows.Forms.PictureBox();
            this.CloudBT = new System.Windows.Forms.PictureBox();
            this.VirusPb1 = new System.Windows.Forms.PictureBox();
            this.VirusPb2 = new System.Windows.Forms.PictureBox();
            this.VirusPb3 = new System.Windows.Forms.PictureBox();
            this.VirusPb4 = new System.Windows.Forms.PictureBox();
            this.VirusPb5 = new System.Windows.Forms.PictureBox();
            this.VirusPb6 = new System.Windows.Forms.PictureBox();
            this.VirusPb7 = new System.Windows.Forms.PictureBox();
            this.VirusPb8 = new System.Windows.Forms.PictureBox();
            this.SecurityKeyBT = new System.Windows.Forms.PictureBox();
            this.LibraryFileBt = new System.Windows.Forms.PictureBox();
            this.BrokenLinkBT = new System.Windows.Forms.PictureBox();
            this.ComputerChipBT = new System.Windows.Forms.PictureBox();
            this.BatteryBT = new System.Windows.Forms.PictureBox();
            this.TheWeb_BT = new System.Windows.Forms.PictureBox();
            this.MalWearBT1 = new System.Windows.Forms.PictureBox();
            this.HeadphoneJackBT = new System.Windows.Forms.PictureBox();
            this.Virus9 = new System.Windows.Forms.PictureBox();
            this.Worm1 = new System.Windows.Forms.PictureBox();
            this.worm2 = new System.Windows.Forms.PictureBox();
            this.Worm3 = new System.Windows.Forms.PictureBox();
            this.worm3b = new System.Windows.Forms.PictureBox();
            this.Worm4 = new System.Windows.Forms.PictureBox();
            this.Worm5b = new System.Windows.Forms.PictureBox();
            this.Worm5d = new System.Windows.Forms.PictureBox();
            this.Worm5c = new System.Windows.Forms.PictureBox();
            this.Worm5 = new System.Windows.Forms.PictureBox();
            this.Worm6 = new System.Windows.Forms.PictureBox();
            this.Worm8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WordDocBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fire_WallBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloudBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecurityKeyBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryFileBt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrokenLinkBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerChipBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheWeb_BT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MalWearBT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadphoneJackBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Virus9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worm2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worm3b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm5b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm5d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm5c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm8)).BeginInit();
            this.SuspendLayout();
            // 
            // SecurityKeyTB
            // 
            this.SecurityKeyTB.AutoSize = true;
            this.SecurityKeyTB.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SecurityKeyTB.Location = new System.Drawing.Point(1054, 362);
            this.SecurityKeyTB.Name = "SecurityKeyTB";
            this.SecurityKeyTB.Size = new System.Drawing.Size(101, 21);
            this.SecurityKeyTB.TabIndex = 1;
            this.SecurityKeyTB.Text = "Security Key";
            this.SecurityKeyTB.UseWaitCursor = true;
            // 
            // FireWallTb
            // 
            this.FireWallTb.AutoSize = true;
            this.FireWallTb.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FireWallTb.Location = new System.Drawing.Point(1052, 316);
            this.FireWallTb.Name = "FireWallTb";
            this.FireWallTb.Size = new System.Drawing.Size(73, 21);
            this.FireWallTb.TabIndex = 0;
            this.FireWallTb.Text = "Firewall";
            this.FireWallTb.UseWaitCursor = true;
            // 
            // ComputerChipsTB
            // 
            this.ComputerChipsTB.AutoSize = true;
            this.ComputerChipsTB.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ComputerChipsTB.Location = new System.Drawing.Point(1053, 339);
            this.ComputerChipsTB.Name = "ComputerChipsTB";
            this.ComputerChipsTB.Size = new System.Drawing.Size(125, 21);
            this.ComputerChipsTB.TabIndex = 1;
            this.ComputerChipsTB.Text = "Computer Chips";
            this.ComputerChipsTB.UseWaitCursor = true;
            // 
            // HeadphoneJackTB
            // 
            this.HeadphoneJackTB.AutoSize = true;
            this.HeadphoneJackTB.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.HeadphoneJackTB.Location = new System.Drawing.Point(1055, 517);
            this.HeadphoneJackTB.Name = "HeadphoneJackTB";
            this.HeadphoneJackTB.Size = new System.Drawing.Size(129, 21);
            this.HeadphoneJackTB.TabIndex = 0;
            this.HeadphoneJackTB.Text = "Headphone Jack";
            this.HeadphoneJackTB.UseWaitCursor = true;
            // 
            // LibraryFileTB
            // 
            this.LibraryFileTB.AutoSize = true;
            this.LibraryFileTB.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.LibraryFileTB.Location = new System.Drawing.Point(1055, 384);
            this.LibraryFileTB.Name = "LibraryFileTB";
            this.LibraryFileTB.Size = new System.Drawing.Size(101, 21);
            this.LibraryFileTB.TabIndex = 0;
            this.LibraryFileTB.Text = "Library File";
            this.LibraryFileTB.UseWaitCursor = true;
            // 
            // BatteryTB
            // 
            this.BatteryTB.AutoSize = true;
            this.BatteryTB.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BatteryTB.Location = new System.Drawing.Point(1055, 472);
            this.BatteryTB.Name = "BatteryTB";
            this.BatteryTB.Size = new System.Drawing.Size(65, 21);
            this.BatteryTB.TabIndex = 1;
            this.BatteryTB.Text = "Battery";
            this.BatteryTB.UseWaitCursor = true;
            // 
            // MalwearTB
            // 
            this.MalwearTB.AutoSize = true;
            this.MalwearTB.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.MalwearTB.Location = new System.Drawing.Point(1055, 428);
            this.MalwearTB.Name = "MalwearTB";
            this.MalwearTB.Size = new System.Drawing.Size(73, 21);
            this.MalwearTB.TabIndex = 1;
            this.MalwearTB.Text = "Malwear";
            this.MalwearTB.UseWaitCursor = true;
            // 
            // TheWebTB
            // 
            this.TheWebTB.AutoSize = true;
            this.TheWebTB.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TheWebTB.Location = new System.Drawing.Point(1055, 539);
            this.TheWebTB.Name = "TheWebTB";
            this.TheWebTB.Size = new System.Drawing.Size(75, 21);
            this.TheWebTB.TabIndex = 2;
            this.TheWebTB.Text = "The Web";
            this.TheWebTB.UseWaitCursor = true;
            // 
            // WordDocTB
            // 
            this.WordDocTB.AutoSize = true;
            this.WordDocTB.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.WordDocTB.Location = new System.Drawing.Point(1055, 494);
            this.WordDocTB.Name = "WordDocTB";
            this.WordDocTB.Size = new System.Drawing.Size(83, 21);
            this.WordDocTB.TabIndex = 0;
            this.WordDocTB.Text = "Word Doc";
            this.WordDocTB.UseWaitCursor = true;
            // 
            // TheCloudTB
            // 
            this.TheCloudTB.AutoSize = true;
            this.TheCloudTB.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TheCloudTB.Location = new System.Drawing.Point(1055, 450);
            this.TheCloudTB.Name = "TheCloudTB";
            this.TheCloudTB.Size = new System.Drawing.Size(84, 21);
            this.TheCloudTB.TabIndex = 1;
            this.TheCloudTB.Text = "The Cloud";
            this.TheCloudTB.UseWaitCursor = true;
            // 
            // BrokenLinkTB
            // 
            this.BrokenLinkTB.AutoSize = true;
            this.BrokenLinkTB.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BrokenLinkTB.Location = new System.Drawing.Point(1055, 406);
            this.BrokenLinkTB.Name = "BrokenLinkTB";
            this.BrokenLinkTB.Size = new System.Drawing.Size(105, 21);
            this.BrokenLinkTB.TabIndex = 1;
            this.BrokenLinkTB.Text = "Broken Link";
            this.BrokenLinkTB.UseWaitCursor = true;
            // 
            // WordDocBT 
            // 
            this.WordDocBT.BackColor = System.Drawing.Color.Transparent;
            this.WordDocBT.BackgroundImage = global::TrueSchoolProyect.Properties.Resources.Doc;
            this.WordDocBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WordDocBT.Location = new System.Drawing.Point(70, 294);
            this.WordDocBT.Name = "WordDocBT";
            this.WordDocBT.Size = new System.Drawing.Size(121, 111);
            this.WordDocBT.TabIndex = 3;
            this.WordDocBT.TabStop = false;
            this.WordDocBT.UseWaitCursor = true;
            this.WordDocBT.Click += new System.EventHandler(this.WordDocBT_Click);
            // 
            // VirusPb
            // 
            this.VirusPb.BackColor = System.Drawing.Color.Transparent;
            this.VirusPb.Location = new System.Drawing.Point(424, 339);
            this.VirusPb.Name = "VirusPb";
            this.VirusPb.Size = new System.Drawing.Size(169, 88);
            this.VirusPb.TabIndex = 4;
            this.VirusPb.TabStop = false;
            this.VirusPb.UseWaitCursor = true;
            this.VirusPb.Click += new System.EventHandler(this.VirusPb_Click);
            // 
            // Fire_WallBT
            // 
            this.Fire_WallBT.BackColor = System.Drawing.Color.Transparent;
            this.Fire_WallBT.BackgroundImage = global::TrueSchoolProyect.Properties.Resources.Fire_Wall;
            this.Fire_WallBT.Location = new System.Drawing.Point(427, 231);
            this.Fire_WallBT.Name = "Fire_WallBT";
            this.Fire_WallBT.Size = new System.Drawing.Size(88, 95);
            this.Fire_WallBT.TabIndex = 5;
            this.Fire_WallBT.TabStop = false;
            this.Fire_WallBT.UseWaitCursor = true;
            this.Fire_WallBT.Click += new System.EventHandler(this.Fire_WallBT_Click);
            // 
            // CloudBT
            // 
            this.CloudBT.BackColor = System.Drawing.Color.Transparent;
            this.CloudBT.BackgroundImage = global::TrueSchoolProyect.Properties.Resources.Cloud;
            this.CloudBT.Location = new System.Drawing.Point(34, 124);
            this.CloudBT.Name = "CloudBT";
            this.CloudBT.Size = new System.Drawing.Size(215, 119);
            this.CloudBT.TabIndex = 6;
            this.CloudBT.TabStop = false;
            this.CloudBT.UseWaitCursor = true;
            this.CloudBT.Click += new System.EventHandler(this.CloudBT_Click);
            // 
            // VirusPb1
            // 
            this.VirusPb1.BackColor = System.Drawing.Color.Transparent;
            this.VirusPb1.Location = new System.Drawing.Point(499, 183);
            this.VirusPb1.Name = "VirusPb1";
            this.VirusPb1.Size = new System.Drawing.Size(32, 27);
            this.VirusPb1.TabIndex = 7;
            this.VirusPb1.TabStop = false;
            this.VirusPb1.UseWaitCursor = true;
            this.VirusPb1.Click += new System.EventHandler(this.VirusPb1_Click);
            // 
            // VirusPb2
            // 
            this.VirusPb2.BackColor = System.Drawing.Color.Transparent;
            this.VirusPb2.Location = new System.Drawing.Point(649, 423);
            this.VirusPb2.Name = "VirusPb2";
            this.VirusPb2.Size = new System.Drawing.Size(32, 27);
            this.VirusPb2.TabIndex = 8;
            this.VirusPb2.TabStop = false;
            this.VirusPb2.UseWaitCursor = true;
            this.VirusPb2.Click += new System.EventHandler(this.VirusPb2_Click);
            // 
            // VirusPb3
            // 
            this.VirusPb3.BackColor = System.Drawing.Color.Transparent;
            this.VirusPb3.Location = new System.Drawing.Point(522, 55);
            this.VirusPb3.Name = "VirusPb3";
            this.VirusPb3.Size = new System.Drawing.Size(37, 28);
            this.VirusPb3.TabIndex = 9;
            this.VirusPb3.TabStop = false;
            this.VirusPb3.UseWaitCursor = true;
            this.VirusPb3.Click += new System.EventHandler(this.VirusPb3_Click);
            // 
            // VirusPb4
            // 
            this.VirusPb4.BackColor = System.Drawing.Color.Transparent;
            this.VirusPb4.Location = new System.Drawing.Point(28, 146);
            this.VirusPb4.Name = "VirusPb4";
            this.VirusPb4.Size = new System.Drawing.Size(32, 27);
            this.VirusPb4.TabIndex = 10;
            this.VirusPb4.TabStop = false;
            this.VirusPb4.UseWaitCursor = true;
            this.VirusPb4.Click += new System.EventHandler(this.VirusPb4_Click);
            // 
            // VirusPb5
            // 
            this.VirusPb5.BackColor = System.Drawing.Color.Transparent;
            this.VirusPb5.Location = new System.Drawing.Point(9, 178);
            this.VirusPb5.Name = "VirusPb5";
            this.VirusPb5.Size = new System.Drawing.Size(25, 20);
            this.VirusPb5.TabIndex = 11;
            this.VirusPb5.TabStop = false;
            this.VirusPb5.UseWaitCursor = true;
            this.VirusPb5.Click += new System.EventHandler(this.VirusPb5_Click);
            // 
            // VirusPb6
            // 
            this.VirusPb6.BackColor = System.Drawing.Color.Transparent;
            this.VirusPb6.Location = new System.Drawing.Point(230, 493);
            this.VirusPb6.Name = "VirusPb6";
            this.VirusPb6.Size = new System.Drawing.Size(32, 27);
            this.VirusPb6.TabIndex = 12;
            this.VirusPb6.TabStop = false;
            this.VirusPb6.UseWaitCursor = true;
            this.VirusPb6.Click += new System.EventHandler(this.VirusPb6_Click);
            // 
            // VirusPb7
            // 
            this.VirusPb7.BackColor = System.Drawing.Color.Transparent;
            this.VirusPb7.Location = new System.Drawing.Point(717, 510);
            this.VirusPb7.Name = "VirusPb7";
            this.VirusPb7.Size = new System.Drawing.Size(49, 34);
            this.VirusPb7.TabIndex = 13;
            this.VirusPb7.TabStop = false;
            this.VirusPb7.UseWaitCursor = true;
            this.VirusPb7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // VirusPb8
            // 
            this.VirusPb8.BackColor = System.Drawing.Color.Transparent;
            this.VirusPb8.Location = new System.Drawing.Point(987, 451);
            this.VirusPb8.Name = "VirusPb8";
            this.VirusPb8.Size = new System.Drawing.Size(32, 27);
            this.VirusPb8.TabIndex = 14;
            this.VirusPb8.TabStop = false;
            this.VirusPb8.UseWaitCursor = true;
            this.VirusPb8.Click += new System.EventHandler(this.VirusPb8_Click);
            // 
            // SecurityKeyBT
            // 
            this.SecurityKeyBT.BackColor = System.Drawing.Color.Transparent;
            this.SecurityKeyBT.BackgroundImage = global::TrueSchoolProyect.Properties.Resources.Key;
            this.SecurityKeyBT.Location = new System.Drawing.Point(320, 106);
            this.SecurityKeyBT.Name = "SecurityKeyBT";
            this.SecurityKeyBT.Size = new System.Drawing.Size(42, 42);
            this.SecurityKeyBT.TabIndex = 15;
            this.SecurityKeyBT.TabStop = false;
            this.SecurityKeyBT.UseWaitCursor = true;
            this.SecurityKeyBT.Click += new System.EventHandler(this.SecurityKeyBT_Click);
            // 
            // LibraryFileBt
            // 
            this.LibraryFileBt.BackColor = System.Drawing.Color.Transparent;
            this.LibraryFileBt.BackgroundImage = global::TrueSchoolProyect.Properties.Resources.File;
            this.LibraryFileBt.Location = new System.Drawing.Point(303, 305);
            this.LibraryFileBt.Name = "LibraryFileBt";
            this.LibraryFileBt.Size = new System.Drawing.Size(53, 15);
            this.LibraryFileBt.TabIndex = 16;
            this.LibraryFileBt.TabStop = false;
            this.LibraryFileBt.UseWaitCursor = true;
            this.LibraryFileBt.Click += new System.EventHandler(this.LibraryFileBt_Click);
            // 
            // BrokenLinkBT
            // 
            this.BrokenLinkBT.BackColor = System.Drawing.Color.Transparent;
            this.BrokenLinkBT.Image = global::TrueSchoolProyect.Properties.Resources.Link;
            this.BrokenLinkBT.Location = new System.Drawing.Point(628, 109);
            this.BrokenLinkBT.Name = "BrokenLinkBT";
            this.BrokenLinkBT.Size = new System.Drawing.Size(49, 50);
            this.BrokenLinkBT.TabIndex = 17;
            this.BrokenLinkBT.TabStop = false;
            this.BrokenLinkBT.UseWaitCursor = true;
            this.BrokenLinkBT.Click += new System.EventHandler(this.BrokenLinkBT_Click);
            // 
            // ComputerChipBT
            // 
            this.ComputerChipBT.BackColor = System.Drawing.Color.Transparent;
            this.ComputerChipBT.Image = global::TrueSchoolProyect.Properties.Resources.Chips;
            this.ComputerChipBT.Location = new System.Drawing.Point(58, 527);
            this.ComputerChipBT.Name = "ComputerChipBT";
            this.ComputerChipBT.Size = new System.Drawing.Size(111, 55);
            this.ComputerChipBT.TabIndex = 18;
            this.ComputerChipBT.TabStop = false;
            this.ComputerChipBT.UseWaitCursor = true;
            this.ComputerChipBT.Click += new System.EventHandler(this.ComputerChipBT_Click);
            // 
            // BatteryBT
            // 
            this.BatteryBT.BackColor = System.Drawing.Color.Transparent;
            this.BatteryBT.Image = global::TrueSchoolProyect.Properties.Resources.Battery;
            this.BatteryBT.Location = new System.Drawing.Point(423, 494);
            this.BatteryBT.Name = "BatteryBT";
            this.BatteryBT.Size = new System.Drawing.Size(36, 21);
            this.BatteryBT.TabIndex = 19;
            this.BatteryBT.TabStop = false;
            this.BatteryBT.UseWaitCursor = true;
            this.BatteryBT.Click += new System.EventHandler(this.BatteryBT_Click);
            // 
            // TheWeb_BT
            // 
            this.TheWeb_BT.BackColor = System.Drawing.Color.Transparent;
            this.TheWeb_BT.Image = global::TrueSchoolProyect.Properties.Resources.Web;
            this.TheWeb_BT.Location = new System.Drawing.Point(868, 0);
            this.TheWeb_BT.Name = "TheWeb_BT";
            this.TheWeb_BT.Size = new System.Drawing.Size(168, 113);
            this.TheWeb_BT.TabIndex = 20;
            this.TheWeb_BT.TabStop = false;
            this.TheWeb_BT.UseWaitCursor = true;
            this.TheWeb_BT.Click += new System.EventHandler(this.TheWeb_BT_Click);
            // 
            // MalWearBT1
            // 
            this.MalWearBT1.BackColor = System.Drawing.Color.Transparent;
            this.MalWearBT1.Image = global::TrueSchoolProyect.Properties.Resources.Mal_Wear;
            this.MalWearBT1.Location = new System.Drawing.Point(623, 285);
            this.MalWearBT1.Name = "MalWearBT1";
            this.MalWearBT1.Size = new System.Drawing.Size(142, 120);
            this.MalWearBT1.TabIndex = 21;
            this.MalWearBT1.TabStop = false;
            this.MalWearBT1.UseWaitCursor = true;
            this.MalWearBT1.Click += new System.EventHandler(this.MalWearBT1_Click);
            // 
            // HeadphoneJackBT
            // 
            this.HeadphoneJackBT.BackColor = System.Drawing.Color.Transparent;
            this.HeadphoneJackBT.Image = global::TrueSchoolProyect.Properties.Resources.Jack;
            this.HeadphoneJackBT.Location = new System.Drawing.Point(277, 374);
            this.HeadphoneJackBT.Name = "HeadphoneJackBT";
            this.HeadphoneJackBT.Size = new System.Drawing.Size(32, 47);
            this.HeadphoneJackBT.TabIndex = 22;
            this.HeadphoneJackBT.TabStop = false;
            this.HeadphoneJackBT.UseWaitCursor = true;
            this.HeadphoneJackBT.Click += new System.EventHandler(this.HeadphoneJackBT_Click);
            // 
            // Virus9
            // 
            this.Virus9.BackColor = System.Drawing.Color.Transparent;
            this.Virus9.Location = new System.Drawing.Point(544, 504);
            this.Virus9.Name = "Virus9";
            this.Virus9.Size = new System.Drawing.Size(88, 34);
            this.Virus9.TabIndex = 23;
            this.Virus9.TabStop = false;
            this.Virus9.UseWaitCursor = true;
            this.Virus9.Click += new System.EventHandler(this.Virus9_Click);
            // 
            // Worm1
            // 
            this.Worm1.BackColor = System.Drawing.Color.Transparent;
            this.Worm1.Location = new System.Drawing.Point(277, 326);
            this.Worm1.Name = "Worm1";
            this.Worm1.Size = new System.Drawing.Size(43, 40);
            this.Worm1.TabIndex = 24;
            this.Worm1.TabStop = false;
            this.Worm1.UseWaitCursor = true;
            this.Worm1.Click += new System.EventHandler(this.Worm1_Click);
            // 
            // worm2
            // 
            this.worm2.BackColor = System.Drawing.Color.Transparent;
            this.worm2.Location = new System.Drawing.Point(277, 231);
            this.worm2.Name = "worm2";
            this.worm2.Size = new System.Drawing.Size(32, 27);
            this.worm2.TabIndex = 25;
            this.worm2.TabStop = false;
            this.worm2.UseWaitCursor = true;
            this.worm2.Click += new System.EventHandler(this.worm2_Click);
            // 
            // Worm3
            // 
            this.Worm3.BackColor = System.Drawing.Color.Transparent;
            this.Worm3.Location = new System.Drawing.Point(34, 121);
            this.Worm3.Name = "Worm3";
            this.Worm3.Size = new System.Drawing.Size(108, 27);
            this.Worm3.TabIndex = 26;
            this.Worm3.TabStop = false;
            this.Worm3.UseWaitCursor = true;
            this.Worm3.Click += new System.EventHandler(this.worm3_Click);
            // 
            // worm3b
            // 
            this.worm3b.BackColor = System.Drawing.Color.Transparent;
            this.worm3b.Location = new System.Drawing.Point(34, 146);
            this.worm3b.Name = "worm3b";
            this.worm3b.Size = new System.Drawing.Size(42, 52);
            this.worm3b.TabIndex = 27;
            this.worm3b.TabStop = false;
            this.worm3b.UseWaitCursor = true;
            this.worm3b.Click += new System.EventHandler(this.worm4b_Click);
            // 
            // Worm4
            // 
            this.Worm4.BackColor = System.Drawing.Color.Transparent;
            this.Worm4.Location = new System.Drawing.Point(777, 121);
            this.Worm4.Name = "Worm4";
            this.Worm4.Size = new System.Drawing.Size(19, 27);
            this.Worm4.TabIndex = 28;
            this.Worm4.TabStop = false;
            this.Worm4.UseWaitCursor = true;
            this.Worm4.Click += new System.EventHandler(this.Worm4_Click);
            // 
            // Worm5b
            // 
            this.Worm5b.BackColor = System.Drawing.Color.Transparent;
            this.Worm5b.Location = new System.Drawing.Point(868, 12);
            this.Worm5b.Name = "Worm5b";
            this.Worm5b.Size = new System.Drawing.Size(38, 101);
            this.Worm5b.TabIndex = 29;
            this.Worm5b.TabStop = false;
            this.Worm5b.UseWaitCursor = true;
            this.Worm5b.Click += new System.EventHandler(this.Worm5b_Click);
            // 
            // Worm5d
            // 
            this.Worm5d.BackColor = System.Drawing.Color.Transparent;
            this.Worm5d.Location = new System.Drawing.Point(902, 86);
            this.Worm5d.Name = "Worm5d";
            this.Worm5d.Size = new System.Drawing.Size(108, 27);
            this.Worm5d.TabIndex = 30;
            this.Worm5d.TabStop = false;
            this.Worm5d.UseWaitCursor = true;
            this.Worm5d.Click += new System.EventHandler(this.Worm5d_Click);
            // 
            // Worm5c
            // 
            this.Worm5c.BackColor = System.Drawing.Color.Transparent;
            this.Worm5c.Location = new System.Drawing.Point(906, 68);
            this.Worm5c.Name = "Worm5c";
            this.Worm5c.Size = new System.Drawing.Size(99, 27);
            this.Worm5c.TabIndex = 31;
            this.Worm5c.TabStop = false;
            this.Worm5c.UseWaitCursor = true;
            this.Worm5c.Click += new System.EventHandler(this.Worm5c_Click);
            // 
            // Worm5
            // 
            this.Worm5.BackColor = System.Drawing.Color.Transparent;
            this.Worm5.Location = new System.Drawing.Point(892, 30);
            this.Worm5.Name = "Worm5";
            this.Worm5.Size = new System.Drawing.Size(48, 50);
            this.Worm5.TabIndex = 32;
            this.Worm5.TabStop = false;
            this.Worm5.UseWaitCursor = true;
            this.Worm5.Click += new System.EventHandler(this.worm5_Click);
            // 
            // Worm6
            // 
            this.Worm6.BackColor = System.Drawing.Color.Transparent;
            this.Worm6.Location = new System.Drawing.Point(614, 208);
            this.Worm6.Name = "Worm6";
            this.Worm6.Size = new System.Drawing.Size(108, 69);
            this.Worm6.TabIndex = 33;
            this.Worm6.TabStop = false;
            this.Worm6.UseWaitCursor = true;
            this.Worm6.Click += new System.EventHandler(this.Worm6_Click);
            // 
            // Worm8
            // 
            this.Worm8.BackColor = System.Drawing.Color.Transparent;
            this.Worm8.Location = new System.Drawing.Point(953, 316);
            this.Worm8.Name = "Worm8";
            this.Worm8.Size = new System.Drawing.Size(95, 51);
            this.Worm8.TabIndex = 34;
            this.Worm8.TabStop = false;
            this.Worm8.UseWaitCursor = true;
            this.Worm8.Click += new System.EventHandler(this.Worm8_Click);
            // 
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::TrueSchoolProyect.Properties.Resources.New_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1245, 582);
            this.Controls.Add(this.Worm8);
            this.Controls.Add(this.Worm6);
            this.Controls.Add(this.Worm5);
            this.Controls.Add(this.Worm5c);
            this.Controls.Add(this.Worm5d);
            this.Controls.Add(this.Worm5b);
            this.Controls.Add(this.Worm4);
            this.Controls.Add(this.VirusPb4);
            this.Controls.Add(this.worm3b);
            this.Controls.Add(this.Worm3);
            this.Controls.Add(this.worm2);
            this.Controls.Add(this.Worm1);
            this.Controls.Add(this.Virus9);
            this.Controls.Add(this.HeadphoneJackBT);
            this.Controls.Add(this.MalWearBT1);
            this.Controls.Add(this.TheWeb_BT);
            this.Controls.Add(this.BatteryBT);
            this.Controls.Add(this.ComputerChipBT);
            this.Controls.Add(this.BrokenLinkBT);
            this.Controls.Add(this.LibraryFileBt);
            this.Controls.Add(this.SecurityKeyBT);
            this.Controls.Add(this.VirusPb8);
            this.Controls.Add(this.VirusPb7);
            this.Controls.Add(this.VirusPb6);
            this.Controls.Add(this.VirusPb5);
            this.Controls.Add(this.VirusPb3);
            this.Controls.Add(this.VirusPb2);
            this.Controls.Add(this.VirusPb1);
            this.Controls.Add(this.CloudBT);
            this.Controls.Add(this.Fire_WallBT);
            this.Controls.Add(this.VirusPb);
            this.Controls.Add(this.WordDocBT);
            this.Controls.Add(this.TheWebTB);
            this.Controls.Add(this.BrokenLinkTB);
            this.Controls.Add(this.MalwearTB);
            this.Controls.Add(this.ComputerChipsTB);
            this.Controls.Add(this.TheCloudTB);
            this.Controls.Add(this.BatteryTB);
            this.Controls.Add(this.SecurityKeyTB);
            this.Controls.Add(this.LibraryFileTB);
            this.Controls.Add(this.FireWallTb);
            this.Controls.Add(this.WordDocTB);
            this.Controls.Add(this.HeadphoneJackTB);
            ((System.ComponentModel.ISupportInitialize)(this.WordDocBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fire_WallBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloudBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VirusPb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecurityKeyBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryFileBt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrokenLinkBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerChipBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheWeb_BT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MalWearBT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadphoneJackBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Virus9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worm2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worm3b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm5b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm5d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm5c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm8)).EndInit();
        }
        public void ClearSearch()
        {
        SecurityKeyTB.Dispose();
        FireWallTb.Dispose();
        ComputerChipsTB.Dispose();
        HeadphoneJackTB.Dispose();
        LibraryFileTB.Dispose();
        BatteryTB.Dispose();
        MalwearTB.Dispose();
        TheWebTB.Dispose();
        WordDocTB.Dispose();
        TheCloudTB.Dispose();
        BrokenLinkTB.Dispose();
        WordDocBT.Dispose();
        VirusPb.Dispose();
        Fire_WallBT.Dispose();
        CloudBT.Dispose();
        VirusPb1.Dispose();
        VirusPb2.Dispose();
        VirusPb3.Dispose();
        VirusPb4.Dispose();
        VirusPb5.Dispose();
        VirusPb6.Dispose();
        VirusPb7.Dispose();
        VirusPb8.Dispose();
        SecurityKeyBT.Dispose();
        LibraryFileBt.Dispose();
        BrokenLinkBT.Dispose();
        ComputerChipBT.Dispose();
        BatteryBT.Dispose();
        TheWeb_BT.Dispose();
        MalWearBT1.Dispose();
        HeadphoneJackBT.Dispose();
        Virus9.Dispose();
        Worm1.Dispose();
        worm2.Dispose();
        Worm3.Dispose();
        worm3b.Dispose();
        Worm4.Dispose();
        Worm5b.Dispose();
        Worm5d.Dispose();
        Worm5c.Dispose();
        Worm5.Dispose();
        Worm6.Dispose();
        Worm8.Dispose();
        }
        public void BuildRecords()
        {
            this.MenuButton = new System.Windows.Forms.PictureBox();
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
            this.label27 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            // 
            // MenuButton
            // 
            this.MenuButton.Image = global::TrueSchoolProyect.Properties.Resources.MenuButton;
            this.MenuButton.Location = new System.Drawing.Point(506, 320);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(320, 120);
            this.MenuButton.TabIndex = 0;
            this.MenuButton.TabStop = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Team 4evermore (T4) Final Project";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(695, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Programmers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(686, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Bryce Johnson";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(652, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Inna Kravchunovska";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(641, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Stephen Langenkamp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(698, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Miguel Perez";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Room 1 (Desktop) Designer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Room 2 (Search) Designer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 416);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Room 3 (CAT5) Designer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(212, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Menus (Main,Records) Designer";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(371, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "Team Leader";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Lime;
            this.label15.Location = new System.Drawing.Point(62, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Stephen Langenkamp";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(344, 369);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 17);
            this.label16.TabIndex = 13;
            this.label16.Text = "Stephen Langenkamp";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Lime;
            this.label17.Location = new System.Drawing.Point(371, 320);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 17);
            this.label17.TabIndex = 14;
            this.label17.Text = "Miguel Perez";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Lime;
            this.label18.Location = new System.Drawing.Point(362, 277);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 17);
            this.label18.TabIndex = 15;
            this.label18.Text = "Bryce Johnson";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Lime;
            this.label19.Location = new System.Drawing.Point(344, 416);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(136, 17);
            this.label19.TabIndex = 16;
            this.label19.Text = "Inna Kravchunovska";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(357, 93);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 17);
            this.label20.TabIndex = 17;
            this.label20.Text = "Quality Assurance";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Lime;
            this.label21.Location = new System.Drawing.Point(362, 124);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 17);
            this.label21.TabIndex = 18;
            this.label21.Text = "Bryce Johnson";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Lime;
            this.label22.Location = new System.Drawing.Point(344, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(147, 17);
            this.label22.TabIndex = 19;
            this.label22.Text = "Stephen Langenkamp";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(110, 93);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 17);
            this.label23.TabIndex = 20;
            this.label23.Text = "Artist";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(96, 169);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 17);
            this.label24.TabIndex = 21;
            this.label24.Text = "Fine Tuning";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(344, 169);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(138, 17);
            this.label25.TabIndex = 22;
            this.label25.Text = "Storyboard Direction";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Lime;
            this.label26.Location = new System.Drawing.Point(371, 201);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 17);
            this.label26.TabIndex = 23;
            this.label26.Text = "Miguel Perez";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Lime;
            this.label27.Location = new System.Drawing.Point(73, 201);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(136, 17);
            this.label27.TabIndex = 24;
            this.label27.Text = "Inna Kravchunovska";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label27);
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
            this.Controls.Add(this.MenuButton);
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
        }
        public void ClearRecords()
        {
        MenuButton.Dispose();
        label4.Dispose();
        label5.Dispose();
        label6.Dispose();
        label7.Dispose();
        label8.Dispose();
        label9.Dispose();
        label10.Dispose();
        label11.Dispose();
        label12.Dispose();
        label13.Dispose();
        label14.Dispose();
        label15.Dispose();
        label16.Dispose();
        label17.Dispose();
        label18.Dispose();
        label19.Dispose();
        label20.Dispose();
        label21.Dispose();
        label22.Dispose();
        label23.Dispose();
        label24.Dispose();
        label25.Dispose();
        label26.Dispose();
        label27.Dispose();
        }
        public void BuildIntro()
        {
            this.NameRegister = new System.Windows.Forms.TextBox();
            this.NameConfirm = new System.Windows.Forms.Button();
            this.GameLoadButton = new System.Windows.Forms.Button();
            // 
            // NameRegister
            // 
            this.NameRegister.ForeColor = System.Drawing.Color.DarkGreen;
            this.NameRegister.Location = new System.Drawing.Point(171, 305);
            this.NameRegister.Name = "NameRegister";
            this.NameRegister.Size = new System.Drawing.Size(328, 22);
            this.NameRegister.TabIndex = 0;
            // 
            // NameConfirm
            // 
            this.NameConfirm.ForeColor = System.Drawing.Color.DarkGreen;
            this.NameConfirm.Location = new System.Drawing.Point(505, 290);
            this.NameConfirm.Name = "NameConfirm";
            this.NameConfirm.Size = new System.Drawing.Size(96, 52);
            this.NameConfirm.TabIndex = 1;
            this.NameConfirm.Text = "Is My Name";
            this.NameConfirm.UseVisualStyleBackColor = true;
            this.NameConfirm.Click += new System.EventHandler(this.NameConfirm_Click);
            // 
            // GameLoadButton
            // 
            this.GameLoadButton.Enabled = false;
            this.GameLoadButton.Visible = false;
            this.GameLoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameLoadButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.GameLoadButton.Location = new System.Drawing.Point(142, 117);
            this.GameLoadButton.Name = "GameLoadButton";
            this.GameLoadButton.Size = new System.Drawing.Size(513, 225);
            this.GameLoadButton.TabIndex = 2;
            this.GameLoadButton.Text = "Get Ready to Fight!";
            this.GameLoadButton.UseVisualStyleBackColor = true;
            this.GameLoadButton.Click += new System.EventHandler(this.GameLoadButton_Click);
            // 
            // Form1
            // 
            this.Controls.Add(this.GameLoadButton);
            this.Controls.Add(this.NameConfirm);
            this.Controls.Add(this.NameRegister);
        }
        public void ClearIntro()
        {
        NameRegister.Dispose();
        NameConfirm.Dispose();
        GameLoadButton.Dispose();
        }
        #endregion

        #region Menu Zone
        private System.Windows.Forms.PictureBox Play_Button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox AttackButton;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.TextBox HealthCounter;
        private System.Windows.Forms.PictureBox HealthPotButton;
        private System.Windows.Forms.PictureBox TurnRightBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        #endregion

        #region Records Zone
        private System.Windows.Forms.PictureBox MenuButton;
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
        private System.Windows.Forms.Label label27;
        #endregion

        #region Inna Zone

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox t1p3;
        private System.Windows.Forms.PictureBox t1p4;
        private System.Windows.Forms.PictureBox t1p5;
        private System.Windows.Forms.PictureBox t1p6;
        private System.Windows.Forms.PictureBox t1p7;
        private System.Windows.Forms.PictureBox t1p8;
        private System.Windows.Forms.PictureBox t2p1;
        private System.Windows.Forms.PictureBox t2p2;
        private System.Windows.Forms.PictureBox t2p3;
        private System.Windows.Forms.PictureBox t2p4;
        private System.Windows.Forms.PictureBox t2p5;
        private System.Windows.Forms.PictureBox t2p6;
        private System.Windows.Forms.PictureBox t2p7;
        private System.Windows.Forms.PictureBox t2p8;
        private System.Windows.Forms.PictureBox blue1;
        private System.Windows.Forms.PictureBox brown1;
        private System.Windows.Forms.PictureBox green1;
        private System.Windows.Forms.PictureBox orange1;
        private System.Windows.Forms.PictureBox whiteBlue1;
        private System.Windows.Forms.PictureBox whiteBrown1;
        private System.Windows.Forms.PictureBox whiteGreen1;
        private System.Windows.Forms.PictureBox whiteOrange1;
        private System.Windows.Forms.PictureBox t1p1;
        private System.Windows.Forms.Button bt_Submit;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.PictureBox t1p2;
        public System.Windows.Forms.TextBox tb_Colors;
        public System.Windows.Forms.TextBox tb_Terminal;
        public System.Windows.Forms.TextBox tb_Clicks;
        //Hint Zone
        private System.Windows.Forms.PictureBox bt_Hint;
        private System.Windows.Forms.Label lb_t1p1;
        private System.Windows.Forms.Label lb_Hint;
        private System.Windows.Forms.TextBox tb_instructions;
        private System.Windows.Forms.Label lb_instructions;
        private System.Windows.Forms.TextBox tb_Results;
        private System.Windows.Forms.Label lb_clicks;

        #endregion

        #region Stephen Zone
        private System.Windows.Forms.Label SecurityKeyTB;
        private System.Windows.Forms.Label FireWallTb;
        private System.Windows.Forms.Label ComputerChipsTB;
        private System.Windows.Forms.Label HeadphoneJackTB;
        private System.Windows.Forms.Label LibraryFileTB;
        private System.Windows.Forms.Label BatteryTB;
        private System.Windows.Forms.Label MalwearTB;
        private System.Windows.Forms.Label TheWebTB;
        private System.Windows.Forms.Label WordDocTB;
        private System.Windows.Forms.Label TheCloudTB;
        private System.Windows.Forms.Label BrokenLinkTB;
        private System.Windows.Forms.PictureBox WordDocBT;
        private System.Windows.Forms.PictureBox VirusPb;
        private System.Windows.Forms.PictureBox Fire_WallBT;
        private System.Windows.Forms.PictureBox CloudBT;
        private System.Windows.Forms.PictureBox VirusPb1;
        private System.Windows.Forms.PictureBox VirusPb2;
        private System.Windows.Forms.PictureBox VirusPb3;
        private System.Windows.Forms.PictureBox VirusPb4;
        private System.Windows.Forms.PictureBox VirusPb5;
        private System.Windows.Forms.PictureBox VirusPb6;
        private System.Windows.Forms.PictureBox VirusPb7;
        private System.Windows.Forms.PictureBox VirusPb8;
        private System.Windows.Forms.PictureBox SecurityKeyBT;
        private System.Windows.Forms.PictureBox LibraryFileBt;
        private System.Windows.Forms.PictureBox BrokenLinkBT;
        private System.Windows.Forms.PictureBox ComputerChipBT;
        private System.Windows.Forms.PictureBox BatteryBT;
        private System.Windows.Forms.PictureBox TheWeb_BT;
        private System.Windows.Forms.PictureBox MalWearBT1;
        private System.Windows.Forms.PictureBox HeadphoneJackBT;
        private System.Windows.Forms.PictureBox Virus9;
        private System.Windows.Forms.PictureBox Worm1;
        private System.Windows.Forms.PictureBox worm2;
        private System.Windows.Forms.PictureBox Worm3;
        private System.Windows.Forms.PictureBox worm3b;
        private System.Windows.Forms.PictureBox Worm4;
        private System.Windows.Forms.PictureBox Worm5b;
        private System.Windows.Forms.PictureBox Worm5d;
        private System.Windows.Forms.PictureBox Worm5c;
        private System.Windows.Forms.PictureBox Worm5;
        private System.Windows.Forms.PictureBox Worm6;
        private System.Windows.Forms.PictureBox Worm8;
        #endregion

        #region Miguel Zone

        private System.Windows.Forms.PictureBox Taskbar;
        private System.Windows.Forms.PictureBox startborder;
        private System.Windows.Forms.Button TaskbarStart;
        private System.Windows.Forms.Button Enemybt;
        private System.Windows.Forms.Label instructions1;
        private System.Windows.Forms.PictureBox healthzone;
        private System.Windows.Forms.Label instructions2;
        private System.Windows.Forms.TextBox Enemy;
        private System.Windows.Forms.TextBox You;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox folder1;
        private System.Windows.Forms.PictureBox folder2;
        private System.Windows.Forms.PictureBox folder3;
        private System.Windows.Forms.PictureBox folder4;
        private System.Windows.Forms.PictureBox folder5;
        private System.Windows.Forms.PictureBox folder6;
        private System.Windows.Forms.PictureBox folder7;
        private System.Windows.Forms.PictureBox folder8;
        private System.Windows.Forms.Label Virushealth;
        #endregion
        
        #region Intro Zone
        private System.Windows.Forms.TextBox NameRegister;
        private System.Windows.Forms.Button NameConfirm;
        private System.Windows.Forms.Button GameLoadButton;
        #endregion
        
    }
}

