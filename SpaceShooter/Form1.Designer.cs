namespace SpaceShooter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mMoveBgTimer = new System.Windows.Forms.Timer(this.components);
            this.mPlayer = new System.Windows.Forms.PictureBox();
            this.mLeftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.mRightMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.mDownMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.mUpMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.mMoveMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.mMoveEnemyTimer = new System.Windows.Forms.Timer(this.components);
            this.mEnemyMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.mGRLabel = new System.Windows.Forms.Label();
            this.mReplayButton = new System.Windows.Forms.Button();
            this.mExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // mMoveBgTimer
            // 
            this.mMoveBgTimer.Enabled = true;
            this.mMoveBgTimer.Interval = 10;
            this.mMoveBgTimer.Tick += new System.EventHandler(this.mMoveBgTimer_Tick);
            // 
            // mPlayer
            // 
            this.mPlayer.BackColor = System.Drawing.Color.Transparent;
            this.mPlayer.Image = ((System.Drawing.Image)(resources.GetObject("mPlayer.Image")));
            this.mPlayer.Location = new System.Drawing.Point(260, 400);
            this.mPlayer.Name = "mPlayer";
            this.mPlayer.Size = new System.Drawing.Size(50, 50);
            this.mPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mPlayer.TabIndex = 0;
            this.mPlayer.TabStop = false;
            // 
            // mLeftMoveTimer
            // 
            this.mLeftMoveTimer.Interval = 5;
            this.mLeftMoveTimer.Tick += new System.EventHandler(this.mLeftMoveTimer_Tick);
            // 
            // mRightMoveTimer
            // 
            this.mRightMoveTimer.Interval = 5;
            this.mRightMoveTimer.Tick += new System.EventHandler(this.mRightMoveTimer_Tick);
            // 
            // mDownMoveTimer
            // 
            this.mDownMoveTimer.Interval = 5;
            this.mDownMoveTimer.Tick += new System.EventHandler(this.mDownMoveTimer_Tick);
            // 
            // mUpMoveTimer
            // 
            this.mUpMoveTimer.Interval = 5;
            this.mUpMoveTimer.Tick += new System.EventHandler(this.mUpMoveTimer_Tick);
            // 
            // mMoveMunitionTimer
            // 
            this.mMoveMunitionTimer.Enabled = true;
            this.mMoveMunitionTimer.Interval = 20;
            this.mMoveMunitionTimer.Tick += new System.EventHandler(this.mMoveMunitionTimer_Tick);
            // 
            // mMoveEnemyTimer
            // 
            this.mMoveEnemyTimer.Enabled = true;
            this.mMoveEnemyTimer.Tick += new System.EventHandler(this.mMoveEnemyTimer_Tick);
            // 
            // mEnemyMunitionTimer
            // 
            this.mEnemyMunitionTimer.Enabled = true;
            this.mEnemyMunitionTimer.Interval = 20;
            this.mEnemyMunitionTimer.Tick += new System.EventHandler(this.mEnemyMunitionTimer_Tick);
            // 
            // mGRLabel
            // 
            this.mGRLabel.BackColor = System.Drawing.Color.Transparent;
            this.mGRLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mGRLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.mGRLabel.Location = new System.Drawing.Point(133, 47);
            this.mGRLabel.Name = "mGRLabel";
            this.mGRLabel.Size = new System.Drawing.Size(320, 85);
            this.mGRLabel.TabIndex = 1;
            this.mGRLabel.Text = "label1";
            this.mGRLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mGRLabel.Visible = false;
            // 
            // mReplayButton
            // 
            this.mReplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mReplayButton.Location = new System.Drawing.Point(174, 232);
            this.mReplayButton.Name = "mReplayButton";
            this.mReplayButton.Size = new System.Drawing.Size(222, 41);
            this.mReplayButton.TabIndex = 2;
            this.mReplayButton.Text = "Replay";
            this.mReplayButton.UseVisualStyleBackColor = true;
            this.mReplayButton.Visible = false;
            this.mReplayButton.Click += new System.EventHandler(this.mReplayButton_Click);
            // 
            // mExitButton
            // 
            this.mExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mExitButton.Location = new System.Drawing.Point(174, 302);
            this.mExitButton.Name = "mExitButton";
            this.mExitButton.Size = new System.Drawing.Size(222, 41);
            this.mExitButton.TabIndex = 3;
            this.mExitButton.Text = "Exit";
            this.mExitButton.UseVisualStyleBackColor = true;
            this.mExitButton.Visible = false;
            this.mExitButton.Click += new System.EventHandler(this.mExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.mExitButton);
            this.Controls.Add(this.mReplayButton);
            this.Controls.Add(this.mGRLabel);
            this.Controls.Add(this.mPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Space Shooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer mMoveBgTimer;
        private System.Windows.Forms.PictureBox mPlayer;
        private System.Windows.Forms.Timer mLeftMoveTimer;
        private System.Windows.Forms.Timer mRightMoveTimer;
        private System.Windows.Forms.Timer mDownMoveTimer;
        private System.Windows.Forms.Timer mUpMoveTimer;
        private System.Windows.Forms.Timer mMoveMunitionTimer;
        private System.Windows.Forms.Timer mMoveEnemyTimer;
        private System.Windows.Forms.Timer mEnemyMunitionTimer;
        private System.Windows.Forms.Label mGRLabel;
        private System.Windows.Forms.Button mReplayButton;
        private System.Windows.Forms.Button mExitButton;
    }
}

