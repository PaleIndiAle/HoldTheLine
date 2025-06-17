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
            this.BackBox = new System.Windows.Forms.PictureBox();
            this.FrontBox = new System.Windows.Forms.PictureBox();
            this.playerBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
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
            // playerBox
            // 
            this.playerBox.Location = new System.Drawing.Point(0, 316);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(150, 200);
            this.playerBox.TabIndex = 2;
            this.playerBox.TabStop = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.FrontBox);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.BackBox);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(820, 820);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.BackBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackBox;
        private System.Windows.Forms.PictureBox FrontBox;
        private System.Windows.Forms.PictureBox playerBox;
    }
}
