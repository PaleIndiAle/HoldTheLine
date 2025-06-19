namespace HoldTheLine.Screens
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BackBox = new System.Windows.Forms.PictureBox();
            this.FrontBox = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerBox = new System.Windows.Forms.PictureBox();
            this.MatthieuBox = new System.Windows.Forms.PictureBox();
            this.EdwinBox = new System.Windows.Forms.PictureBox();
            this.LochlanBox = new System.Windows.Forms.PictureBox();
            this.blackBox = new System.Windows.Forms.PictureBox();
            this.CharacterNameLabel = new System.Windows.Forms.Label();
            this.ChatLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BackBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatthieuBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdwinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LochlanBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBox
            // 
            this.BackBox.Location = new System.Drawing.Point(0, 0);
            this.BackBox.Name = "BackBox";
            this.BackBox.Size = new System.Drawing.Size(2000, 820);
            this.BackBox.TabIndex = 0;
            this.BackBox.TabStop = false;
            // 
            // FrontBox
            // 
            this.FrontBox.Location = new System.Drawing.Point(0, 0);
            this.FrontBox.Name = "FrontBox";
            this.FrontBox.Size = new System.Drawing.Size(2000, 820);
            this.FrontBox.TabIndex = 1;
            this.FrontBox.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // playerBox
            // 
            this.playerBox.Location = new System.Drawing.Point(190, 370);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(150, 200);
            this.playerBox.TabIndex = 2;
            this.playerBox.TabStop = false;
            // 
            // MatthieuBox
            // 
            this.MatthieuBox.Location = new System.Drawing.Point(400, 370);
            this.MatthieuBox.Name = "MatthieuBox";
            this.MatthieuBox.Size = new System.Drawing.Size(150, 200);
            this.MatthieuBox.TabIndex = 3;
            this.MatthieuBox.TabStop = false;
            // 
            // EdwinBox
            // 
            this.EdwinBox.Location = new System.Drawing.Point(0, 370);
            this.EdwinBox.Name = "EdwinBox";
            this.EdwinBox.Size = new System.Drawing.Size(150, 200);
            this.EdwinBox.TabIndex = 4;
            this.EdwinBox.TabStop = false;
            // 
            // LochlanBox
            // 
            this.LochlanBox.Location = new System.Drawing.Point(556, 370);
            this.LochlanBox.Name = "LochlanBox";
            this.LochlanBox.Size = new System.Drawing.Size(150, 200);
            this.LochlanBox.TabIndex = 5;
            this.LochlanBox.TabStop = false;
            // 
            // blackBox
            // 
            this.blackBox.Location = new System.Drawing.Point(0, 576);
            this.blackBox.Name = "blackBox";
            this.blackBox.Size = new System.Drawing.Size(820, 244);
            this.blackBox.TabIndex = 6;
            this.blackBox.TabStop = false;
            this.blackBox.Visible = false;
            // 
            // CharacterNameLabel
            // 
            this.CharacterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterNameLabel.Location = new System.Drawing.Point(26, 599);
            this.CharacterNameLabel.Name = "CharacterNameLabel";
            this.CharacterNameLabel.Size = new System.Drawing.Size(314, 40);
            this.CharacterNameLabel.TabIndex = 7;
            this.CharacterNameLabel.Text = "CharacterNameLabel";
            this.CharacterNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CharacterNameLabel.Visible = false;
            // 
            // ChatLabel
            // 
            this.ChatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatLabel.Location = new System.Drawing.Point(26, 653);
            this.ChatLabel.Name = "ChatLabel";
            this.ChatLabel.Size = new System.Drawing.Size(769, 78);
            this.ChatLabel.TabIndex = 8;
            this.ChatLabel.Text = "ChatLabel";
            this.ChatLabel.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(459, 747);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 54);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(249, 747);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 54);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ChatLabel);
            this.Controls.Add(this.CharacterNameLabel);
            this.Controls.Add(this.blackBox);
            this.Controls.Add(this.FrontBox);
            this.Controls.Add(this.EdwinBox);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.MatthieuBox);
            this.Controls.Add(this.LochlanBox);
            this.Controls.Add(this.BackBox);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(820, 820);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.BackBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatthieuBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdwinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LochlanBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackBox;
        private System.Windows.Forms.PictureBox FrontBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox playerBox;
        private System.Windows.Forms.PictureBox MatthieuBox;
        private System.Windows.Forms.PictureBox EdwinBox;
        private System.Windows.Forms.PictureBox LochlanBox;
        private System.Windows.Forms.PictureBox blackBox;
        private System.Windows.Forms.Label CharacterNameLabel;
        private System.Windows.Forms.Label ChatLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
