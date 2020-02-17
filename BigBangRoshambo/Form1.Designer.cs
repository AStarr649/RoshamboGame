namespace BigBangRoshambo
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.rdoHard = new System.Windows.Forms.RadioButton();
            this.rdoEasy = new System.Windows.Forms.RadioButton();
            this.picRock = new System.Windows.Forms.PictureBox();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.picScissor = new System.Windows.Forms.PictureBox();
            this.picLizard = new System.Windows.Forms.PictureBox();
            this.picSpock = new System.Windows.Forms.PictureBox();
            this.rdoRock = new System.Windows.Forms.RadioButton();
            this.rdoPaper = new System.Windows.Forms.RadioButton();
            this.rdoScissor = new System.Windows.Forms.RadioButton();
            this.rdoLizard = new System.Windows.Forms.RadioButton();
            this.rdoSpock = new System.Windows.Forms.RadioButton();
            this.btnFight = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLoses = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.picVSThrow = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVSThrow)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 152);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBegin);
            this.groupBox1.Controls.Add(this.rdoHard);
            this.groupBox1.Controls.Add(this.rdoEasy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Difficulty";
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(7, 71);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(104, 23);
            this.btnBegin.TabIndex = 2;
            this.btnBegin.Text = "&Begin!";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // rdoHard
            // 
            this.rdoHard.AutoSize = true;
            this.rdoHard.Location = new System.Drawing.Point(7, 44);
            this.rdoHard.Name = "rdoHard";
            this.rdoHard.Size = new System.Drawing.Size(65, 19);
            this.rdoHard.TabIndex = 1;
            this.rdoHard.TabStop = true;
            this.rdoHard.Text = "Difficult";
            this.rdoHard.UseVisualStyleBackColor = true;
            this.rdoHard.CheckedChanged += new System.EventHandler(this.rdoHard_CheckedChanged);
            // 
            // rdoEasy
            // 
            this.rdoEasy.AutoSize = true;
            this.rdoEasy.Location = new System.Drawing.Point(7, 20);
            this.rdoEasy.Name = "rdoEasy";
            this.rdoEasy.Size = new System.Drawing.Size(51, 19);
            this.rdoEasy.TabIndex = 0;
            this.rdoEasy.TabStop = true;
            this.rdoEasy.Text = "Easy";
            this.rdoEasy.UseVisualStyleBackColor = true;
            this.rdoEasy.CheckedChanged += new System.EventHandler(this.rdoEasy_CheckedChanged);
            // 
            // picRock
            // 
            this.picRock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRock.BackgroundImage")));
            this.picRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRock.Location = new System.Drawing.Point(27, 18);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(75, 75);
            this.picRock.TabIndex = 2;
            this.picRock.TabStop = false;
            // 
            // picPaper
            // 
            this.picPaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPaper.BackgroundImage")));
            this.picPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPaper.Location = new System.Drawing.Point(27, 99);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(75, 75);
            this.picPaper.TabIndex = 3;
            this.picPaper.TabStop = false;
            // 
            // picScissor
            // 
            this.picScissor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picScissor.BackgroundImage")));
            this.picScissor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picScissor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picScissor.Location = new System.Drawing.Point(27, 180);
            this.picScissor.Name = "picScissor";
            this.picScissor.Size = new System.Drawing.Size(75, 75);
            this.picScissor.TabIndex = 4;
            this.picScissor.TabStop = false;
            // 
            // picLizard
            // 
            this.picLizard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLizard.BackgroundImage")));
            this.picLizard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLizard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLizard.Location = new System.Drawing.Point(27, 261);
            this.picLizard.Name = "picLizard";
            this.picLizard.Size = new System.Drawing.Size(75, 75);
            this.picLizard.TabIndex = 5;
            this.picLizard.TabStop = false;
            this.picLizard.Visible = false;
            // 
            // picSpock
            // 
            this.picSpock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSpock.BackgroundImage")));
            this.picSpock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSpock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSpock.Location = new System.Drawing.Point(27, 342);
            this.picSpock.Name = "picSpock";
            this.picSpock.Size = new System.Drawing.Size(75, 75);
            this.picSpock.TabIndex = 6;
            this.picSpock.TabStop = false;
            this.picSpock.Visible = false;
            // 
            // rdoRock
            // 
            this.rdoRock.AutoSize = true;
            this.rdoRock.Location = new System.Drawing.Point(7, 52);
            this.rdoRock.Name = "rdoRock";
            this.rdoRock.Size = new System.Drawing.Size(14, 13);
            this.rdoRock.TabIndex = 7;
            this.rdoRock.TabStop = true;
            this.rdoRock.UseVisualStyleBackColor = true;
            this.rdoRock.Visible = false;
            this.rdoRock.CheckedChanged += new System.EventHandler(this.rdoRock_CheckedChanged);
            // 
            // rdoPaper
            // 
            this.rdoPaper.AutoSize = true;
            this.rdoPaper.Location = new System.Drawing.Point(7, 134);
            this.rdoPaper.Name = "rdoPaper";
            this.rdoPaper.Size = new System.Drawing.Size(14, 13);
            this.rdoPaper.TabIndex = 8;
            this.rdoPaper.TabStop = true;
            this.rdoPaper.UseVisualStyleBackColor = true;
            this.rdoPaper.Visible = false;
            this.rdoPaper.CheckedChanged += new System.EventHandler(this.rdoPaper_CheckedChanged);
            // 
            // rdoScissor
            // 
            this.rdoScissor.AutoSize = true;
            this.rdoScissor.Location = new System.Drawing.Point(7, 219);
            this.rdoScissor.Name = "rdoScissor";
            this.rdoScissor.Size = new System.Drawing.Size(14, 13);
            this.rdoScissor.TabIndex = 9;
            this.rdoScissor.TabStop = true;
            this.rdoScissor.UseVisualStyleBackColor = true;
            this.rdoScissor.Visible = false;
            this.rdoScissor.CheckedChanged += new System.EventHandler(this.rdoScissor_CheckedChanged);
            // 
            // rdoLizard
            // 
            this.rdoLizard.AutoSize = true;
            this.rdoLizard.Location = new System.Drawing.Point(7, 297);
            this.rdoLizard.Name = "rdoLizard";
            this.rdoLizard.Size = new System.Drawing.Size(14, 13);
            this.rdoLizard.TabIndex = 10;
            this.rdoLizard.TabStop = true;
            this.rdoLizard.UseVisualStyleBackColor = true;
            this.rdoLizard.Visible = false;
            this.rdoLizard.CheckedChanged += new System.EventHandler(this.rdoLizard_CheckedChanged);
            // 
            // rdoSpock
            // 
            this.rdoSpock.AutoSize = true;
            this.rdoSpock.Location = new System.Drawing.Point(7, 380);
            this.rdoSpock.Name = "rdoSpock";
            this.rdoSpock.Size = new System.Drawing.Size(14, 13);
            this.rdoSpock.TabIndex = 11;
            this.rdoSpock.TabStop = true;
            this.rdoSpock.UseVisualStyleBackColor = true;
            this.rdoSpock.Visible = false;
            this.rdoSpock.CheckedChanged += new System.EventHandler(this.rdoSpock_CheckedChanged);
            // 
            // btnFight
            // 
            this.btnFight.Enabled = false;
            this.btnFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFight.Location = new System.Drawing.Point(291, 180);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(156, 23);
            this.btnFight.TabIndex = 12;
            this.btnFight.Text = "&Attack!";
            this.btnFight.UseVisualStyleBackColor = true;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(372, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Wins:";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(94, 126);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(2, 17);
            this.lblWins.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Losses:";
            // 
            // lblLoses
            // 
            this.lblLoses.AutoSize = true;
            this.lblLoses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoses.Location = new System.Drawing.Point(94, 151);
            this.lblLoses.Name = "lblLoses";
            this.lblLoses.Size = new System.Drawing.Size(2, 17);
            this.lblLoses.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ties:";
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTies.Location = new System.Drawing.Point(94, 175);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(2, 17);
            this.lblTies.TabIndex = 19;
            // 
            // lblOpponent
            // 
            this.lblOpponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponent.Location = new System.Drawing.Point(274, 325);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(189, 104);
            this.lblOpponent.TabIndex = 20;
            this.lblOpponent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picVSThrow
            // 
            this.picVSThrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVSThrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVSThrow.Location = new System.Drawing.Point(329, 239);
            this.picVSThrow.Name = "picVSThrow";
            this.picVSThrow.Size = new System.Drawing.Size(75, 75);
            this.picVSThrow.TabIndex = 21;
            this.picVSThrow.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picRock);
            this.groupBox2.Controls.Add(this.picPaper);
            this.groupBox2.Controls.Add(this.picScissor);
            this.groupBox2.Controls.Add(this.rdoRock);
            this.groupBox2.Controls.Add(this.rdoPaper);
            this.groupBox2.Controls.Add(this.rdoScissor);
            this.groupBox2.Controls.Add(this.picLizard);
            this.groupBox2.Controls.Add(this.rdoLizard);
            this.groupBox2.Controls.Add(this.picSpock);
            this.groupBox2.Controls.Add(this.rdoSpock);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(144, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 425);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(12, 204);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(117, 122);
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(291, 209);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 24;
            this.btnChange.Text = "&Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 445);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.picVSThrow);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.lblTies);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLoses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFight);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Big Bang Roshambo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLizard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVSThrow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.RadioButton rdoHard;
        private System.Windows.Forms.RadioButton rdoEasy;
        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.PictureBox picScissor;
        private System.Windows.Forms.PictureBox picLizard;
        private System.Windows.Forms.PictureBox picSpock;
        private System.Windows.Forms.RadioButton rdoRock;
        private System.Windows.Forms.RadioButton rdoPaper;
        private System.Windows.Forms.RadioButton rdoScissor;
        private System.Windows.Forms.RadioButton rdoLizard;
        private System.Windows.Forms.RadioButton rdoSpock;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLoses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTies;
        private System.Windows.Forms.Label lblOpponent;
        private System.Windows.Forms.PictureBox picVSThrow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnChange;
    }
}

