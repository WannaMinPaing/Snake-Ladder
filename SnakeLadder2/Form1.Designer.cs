namespace SnakeLadder2
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
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.Playerone = new System.Windows.Forms.RichTextBox();
            this.Playertwo = new System.Windows.Forms.RichTextBox();
            this.lbPlayerone = new System.Windows.Forms.Label();
            this.lbPlayertwo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.moreplay = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.RadioButton();
            this.four = new System.Windows.Forms.RadioButton();
            this.comfirm = new System.Windows.Forms.Button();
            this.lbPlayerfour = new System.Windows.Forms.Label();
            this.lbPlayerthree = new System.Windows.Forms.Label();
            this.Playerfour = new System.Windows.Forms.RichTextBox();
            this.Playerthree = new System.Windows.Forms.RichTextBox();
            this.cancal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Gold;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Zawgyi-One", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(47, 486);
            this.start.Margin = new System.Windows.Forms.Padding(2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(59, 24);
            this.start.TabIndex = 0;
            this.start.Text = "Play";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Playerone
            // 
            this.Playerone.BackColor = System.Drawing.Color.OliveDrab;
            this.Playerone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Playerone.Location = new System.Drawing.Point(635, 40);
            this.Playerone.Margin = new System.Windows.Forms.Padding(2);
            this.Playerone.Name = "Playerone";
            this.Playerone.Size = new System.Drawing.Size(132, 27);
            this.Playerone.TabIndex = 1;
            this.Playerone.Text = "";
            // 
            // Playertwo
            // 
            this.Playertwo.BackColor = System.Drawing.Color.OliveDrab;
            this.Playertwo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Playertwo.Location = new System.Drawing.Point(635, 110);
            this.Playertwo.Margin = new System.Windows.Forms.Padding(2);
            this.Playertwo.Name = "Playertwo";
            this.Playertwo.Size = new System.Drawing.Size(132, 27);
            this.Playertwo.TabIndex = 2;
            this.Playertwo.Text = "";
            // 
            // lbPlayerone
            // 
            this.lbPlayerone.AutoSize = true;
            this.lbPlayerone.BackColor = System.Drawing.Color.ForestGreen;
            this.lbPlayerone.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerone.Location = new System.Drawing.Point(568, 20);
            this.lbPlayerone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPlayerone.Name = "lbPlayerone";
            this.lbPlayerone.Size = new System.Drawing.Size(71, 18);
            this.lbPlayerone.TabIndex = 3;
            this.lbPlayerone.Text = "Player One";
            this.lbPlayerone.Click += new System.EventHandler(this.lbPlayerone_Click);
            // 
            // lbPlayertwo
            // 
            this.lbPlayertwo.AutoSize = true;
            this.lbPlayertwo.BackColor = System.Drawing.Color.ForestGreen;
            this.lbPlayertwo.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayertwo.Location = new System.Drawing.Point(568, 90);
            this.lbPlayertwo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPlayertwo.Name = "lbPlayertwo";
            this.lbPlayertwo.Size = new System.Drawing.Size(71, 18);
            this.lbPlayertwo.TabIndex = 4;
            this.lbPlayertwo.Text = "Player Two";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SnakeLadder2.Properties.Resources.big_hower_5;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 279);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(839, 40);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 129);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Zawgyi-One", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(877, 183);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Roll Dice";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 9;
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.Gold;
            this.Help.Font = new System.Drawing.Font("Zawgyi-One", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.Location = new System.Drawing.Point(47, 523);
            this.Help.Margin = new System.Windows.Forms.Padding(2);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(59, 27);
            this.Help.TabIndex = 11;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.Gold;
            this.about.Font = new System.Drawing.Font("Zawgyi-One", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.Location = new System.Drawing.Point(47, 564);
            this.about.Margin = new System.Windows.Forms.Padding(2);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(59, 27);
            this.about.TabIndex = 12;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Gold;
            this.exit.Font = new System.Drawing.Font("Zawgyi-One", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(47, 605);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(59, 29);
            this.exit.TabIndex = 13;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // moreplay
            // 
            this.moreplay.Font = new System.Drawing.Font("Zawgyi-One", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreplay.Location = new System.Drawing.Point(1012, 40);
            this.moreplay.Margin = new System.Windows.Forms.Padding(2);
            this.moreplay.Name = "moreplay";
            this.moreplay.Size = new System.Drawing.Size(140, 23);
            this.moreplay.TabIndex = 14;
            this.moreplay.Text = "TWO MORE PLAY";
            this.moreplay.UseVisualStyleBackColor = true;
            this.moreplay.Click += new System.EventHandler(this.moreplay_Click);
            // 
            // three
            // 
            this.three.AutoSize = true;
            this.three.BackColor = System.Drawing.Color.Silver;
            this.three.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(1012, 67);
            this.three.Margin = new System.Windows.Forms.Padding(2);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(65, 22);
            this.three.TabIndex = 15;
            this.three.TabStop = true;
            this.three.Text = "3 player";
            this.three.UseVisualStyleBackColor = false;
            this.three.CheckedChanged += new System.EventHandler(this.three_CheckedChanged);
            // 
            // four
            // 
            this.four.AutoSize = true;
            this.four.BackColor = System.Drawing.Color.Silver;
            this.four.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(1012, 93);
            this.four.Margin = new System.Windows.Forms.Padding(2);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(65, 22);
            this.four.TabIndex = 16;
            this.four.TabStop = true;
            this.four.Text = "4 player";
            this.four.UseVisualStyleBackColor = false;
            // 
            // comfirm
            // 
            this.comfirm.BackColor = System.Drawing.Color.Silver;
            this.comfirm.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comfirm.Location = new System.Drawing.Point(1012, 131);
            this.comfirm.Margin = new System.Windows.Forms.Padding(2);
            this.comfirm.Name = "comfirm";
            this.comfirm.Size = new System.Drawing.Size(56, 28);
            this.comfirm.TabIndex = 17;
            this.comfirm.Text = "Comfirm";
            this.comfirm.UseVisualStyleBackColor = false;
            this.comfirm.Click += new System.EventHandler(this.comfirm_Click);
            // 
            // lbPlayerfour
            // 
            this.lbPlayerfour.AutoSize = true;
            this.lbPlayerfour.BackColor = System.Drawing.Color.ForestGreen;
            this.lbPlayerfour.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerfour.Location = new System.Drawing.Point(565, 233);
            this.lbPlayerfour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPlayerfour.Name = "lbPlayerfour";
            this.lbPlayerfour.Size = new System.Drawing.Size(74, 18);
            this.lbPlayerfour.TabIndex = 21;
            this.lbPlayerfour.Text = "Player Four";
            // 
            // lbPlayerthree
            // 
            this.lbPlayerthree.AutoSize = true;
            this.lbPlayerthree.BackColor = System.Drawing.Color.ForestGreen;
            this.lbPlayerthree.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerthree.Location = new System.Drawing.Point(565, 165);
            this.lbPlayerthree.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPlayerthree.Name = "lbPlayerthree";
            this.lbPlayerthree.Size = new System.Drawing.Size(81, 18);
            this.lbPlayerthree.TabIndex = 20;
            this.lbPlayerthree.Text = "Player Three";
            this.lbPlayerthree.Click += new System.EventHandler(this.lbPlayerthree_Click);
            // 
            // Playerfour
            // 
            this.Playerfour.BackColor = System.Drawing.Color.OliveDrab;
            this.Playerfour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Playerfour.Location = new System.Drawing.Point(635, 253);
            this.Playerfour.Margin = new System.Windows.Forms.Padding(2);
            this.Playerfour.Name = "Playerfour";
            this.Playerfour.Size = new System.Drawing.Size(132, 27);
            this.Playerfour.TabIndex = 19;
            this.Playerfour.Text = "";
            // 
            // Playerthree
            // 
            this.Playerthree.BackColor = System.Drawing.Color.OliveDrab;
            this.Playerthree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Playerthree.Location = new System.Drawing.Point(635, 185);
            this.Playerthree.Margin = new System.Windows.Forms.Padding(2);
            this.Playerthree.Name = "Playerthree";
            this.Playerthree.Size = new System.Drawing.Size(132, 27);
            this.Playerthree.TabIndex = 18;
            this.Playerthree.Text = "";
            // 
            // cancal
            // 
            this.cancal.BackColor = System.Drawing.Color.Silver;
            this.cancal.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancal.Location = new System.Drawing.Point(1085, 131);
            this.cancal.Margin = new System.Windows.Forms.Padding(2);
            this.cancal.Name = "cancal";
            this.cancal.Size = new System.Drawing.Size(56, 28);
            this.cancal.TabIndex = 22;
            this.cancal.Text = "cancal";
            this.cancal.UseVisualStyleBackColor = false;
            this.cancal.Click += new System.EventHandler(this.cancal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 404);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 436);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 23;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(47, 649);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 27);
            this.button2.TabIndex = 25;
            this.button2.Text = "Language";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(140, 616);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 27);
            this.button3.TabIndex = 26;
            this.button3.Text = "English";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(140, 666);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 27);
            this.button4.TabIndex = 27;
            this.button4.Text = "ျမန္မာ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1215, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(14, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OliveDrab;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(219, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Player One\'s add your name and roll dice for First or Second.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeLadder2.Properties.Resources.wp2409705;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1271, 694);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancal);
            this.Controls.Add(this.lbPlayerfour);
            this.Controls.Add(this.lbPlayerthree);
            this.Controls.Add(this.Playerfour);
            this.Controls.Add(this.Playerthree);
            this.Controls.Add(this.comfirm);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.moreplay);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.about);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbPlayertwo);
            this.Controls.Add(this.lbPlayerone);
            this.Controls.Add(this.Playertwo);
            this.Controls.Add(this.Playerone);
            this.Controls.Add(this.start);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SnakeAndLadder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.RichTextBox Playerone;
        private System.Windows.Forms.RichTextBox Playertwo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Playerfour;
        private System.Windows.Forms.RichTextBox Playerthree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button start;
        public System.Windows.Forms.Label lbPlayerone;
        public System.Windows.Forms.Label lbPlayertwo;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button Help;
        public System.Windows.Forms.Button about;
        public System.Windows.Forms.Button exit;
        public System.Windows.Forms.Button moreplay;
        public System.Windows.Forms.RadioButton three;
        public System.Windows.Forms.RadioButton four;
        public System.Windows.Forms.Button comfirm;
        public System.Windows.Forms.Label lbPlayerfour;
        public System.Windows.Forms.Label lbPlayerthree;
        public System.Windows.Forms.Button cancal;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label3;
    }
}

