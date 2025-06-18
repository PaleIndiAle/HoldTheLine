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
            ((System.ComponentModel.ISupportInitialize)(this.BackBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatthieuBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdwinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LochlanBox)).BeginInit();
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
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
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
    }
}
