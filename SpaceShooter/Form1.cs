using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SpaceShooter
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer mGameBMedia;
        WindowsMediaPlayer mGameSMedia;
        WindowsMediaPlayer mExplosion;

        private PictureBox[] mStars;
        private int mBackgroundSpeed;
        private int mPlayerSpeed;

        private PictureBox[] mMunitions;
        private int mMunitionSpeed;

        private PictureBox[] mEnemies;
        private int mEnemySpeed;

        private PictureBox[] mEnemyMuntions;
        private int mEnemyMunitionSpeed;

        private Random mRandom;

        private int mScore;
        private int mLevel;
        private int mDifficulty;

        private bool mPause;
        private bool mGameIsOver;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mPause = false;
            mGameIsOver = false;
            mScore = 0;
            mLevel = 1;
            mDifficulty = 9;

            mBackgroundSpeed = 4;
            mPlayerSpeed = 4;
            mEnemySpeed = 4;

            mMunitionSpeed = 20;
            mMunitions = new PictureBox[3];

            mEnemyMunitionSpeed = 4;
            mEnemyMuntions = new PictureBox[10];

            Image munition = Image.FromFile(@"asserts\\munition.png");

            Image enemy1 = Image.FromFile("asserts\\E1.png");
            Image enemy2 = Image.FromFile("asserts\\E2.png");
            Image enemy3 = Image.FromFile("asserts\\E3.png");

            Image boss1 = Image.FromFile("asserts\\Boss1.png");
            Image boss2 = Image.FromFile("asserts\\Boss2.png");

            mEnemies = new PictureBox[10];
            mStars = new PictureBox[15];
            mRandom = new Random();

            for(int i = 0; i < mEnemies.Length; ++i)
            {
                mEnemies[i] = new PictureBox();
                mEnemies[i].Size = new Size(40, 40);
                mEnemies[i].Location = new Point((i + 1) * 50, -50);
                mEnemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                mEnemies[i].BorderStyle = BorderStyle.None;
                mEnemies[i].Visible = false;
                Controls.Add(mEnemies[i]);
            }

            mEnemies[0].Image = boss1;
            mEnemies[1].Image = enemy2;
            mEnemies[2].Image = enemy3;
            mEnemies[3].Image = enemy3;
            mEnemies[4].Image = enemy1;
            mEnemies[5].Image = enemy3;
            mEnemies[6].Image = enemy2;
            mEnemies[7].Image = enemy3;
            mEnemies[8].Image = enemy2;
            mEnemies[9].Image = boss2;

            for (int i = 0; i < mMunitions.Length; ++i)
            {
                mMunitions[i] = new PictureBox();
                mMunitions[i].Size = new Size(8, 8);
                mMunitions[i].Image = munition;
                mMunitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                mMunitions[i].BorderStyle = BorderStyle.None;
                Controls.Add(mMunitions[i]);
            }

            for(int i = 0; i < mEnemyMuntions.Length; ++i)
            {
                mEnemyMuntions[i] = new PictureBox();
                mEnemyMuntions[i].Size = new Size(2, 25);
                int x = mRandom.Next(0, 10);
                mEnemyMuntions[i].Location = new Point(mEnemies[x].Location.X, mEnemies[x].Location.Y - 20);
                mEnemyMuntions[i].BackColor = Color.Yellow;
                mEnemyMuntions[i].Visible = false;
                Controls.Add(mEnemyMuntions[i]);
            }

            mGameBMedia = new WindowsMediaPlayer();
            mGameSMedia = new WindowsMediaPlayer();
            mExplosion = new WindowsMediaPlayer();

            mGameBMedia.URL = "songs\\GameSong.mp3";
            mGameSMedia.URL = "songs\\shoot.mp3";
            mExplosion.URL = "songs\\boom.mp3";

            mGameBMedia.settings.setMode("loop", true);
            mGameBMedia.settings.volume = 5;
            mGameSMedia.settings.volume = 1;
            mExplosion.settings.volume = 6;

            for(int i = 0; i < mStars.Length; ++i)
            {
                mStars[i] = new PictureBox();
                mStars[i].BorderStyle = BorderStyle.None;
                mStars[i].Location = new Point(mRandom.Next(20, 500), mRandom.Next(-10, 400));

                if (i % 2 == 1)
                {
                    mStars[i].Size = new Size(2, 2);
                    mStars[i].BackColor = Color.Wheat;
                }
                else
                {
                    mStars[i].Size = new Size(3, 3);
                    mStars[i].BackColor = Color.DarkGray;
                }

                Controls.Add(mStars[i]);
            }
            mGameBMedia.controls.play();
        }

        private void mMoveBgTimer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < mStars.Length / 2; ++i)
            {
                mStars[i].Top += mBackgroundSpeed;

                if (mStars[i].Top >= Height)
                    mStars[i].Top = -mStars[i].Height;
            }

            for(int i = mStars.Length / 2; i < mStars.Length; ++i)
            {
                mStars[i].Top += mBackgroundSpeed - 2;

                if (mStars[i].Top >= Height)
                    mStars[i].Top = -mStars[i].Height;
            }
        }

        private void mLeftMoveTimer_Tick(object sender, EventArgs e)
        {
            if (mPlayer.Left > 10) mPlayer.Left -= mPlayerSpeed; 
        }

        private void mRightMoveTimer_Tick(object sender, EventArgs e)
        {
            if (mPlayer.Right < 580) mPlayer.Left += mPlayerSpeed;
        }

        private void mDownMoveTimer_Tick(object sender, EventArgs e)
        {
            if (mPlayer.Top < 400) mPlayer.Top += mPlayerSpeed;
        }

        private void mUpMoveTimer_Tick(object sender, EventArgs e)
        {
            if (mPlayer.Top > 10) mPlayer.Top -= mPlayerSpeed;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!mPause)
            {
                if (e.KeyCode == Keys.Right)
                    mRightMoveTimer.Start();
                if (e.KeyCode == Keys.Left)
                    mLeftMoveTimer.Start();
                if (e.KeyCode == Keys.Down)
                    mDownMoveTimer.Start();
                if (e.KeyCode == Keys.Up)
                    mUpMoveTimer.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            mRightMoveTimer.Stop();
            mLeftMoveTimer.Stop();
            mDownMoveTimer.Stop();
            mUpMoveTimer.Stop();

            if (e.KeyCode == Keys.Space)
                if (!mGameIsOver)
                {
                    if (mPause)
                    {
                        StartTimers();
                        mGRLabel.Visible = false;
                        mGameBMedia.controls.play();
                        mPause = false;
                    }
                    else
                    {
                        mGRLabel.Location = new Point(this.Width / 2 - 160, 150);
                        mGRLabel.Text = "PAUSED";
                        mGRLabel.Visible = true;
                        mGameBMedia.controls.pause();
                        StopTimers();
                        mPause = true;
                    }
                }
        }

        private void mMoveMunitionTimer_Tick(object sender, EventArgs e)
        {
            mGameSMedia.controls.play();
            for(int i = 0; i < mMunitions.Length; ++i)
            {
                if (mMunitions[i].Top > 0)
                {
                    mMunitions[i].Visible = true;
                    mMunitions[i].Top -= mMunitionSpeed;

                    Collision();
                }
                else
                {
                    mMunitions[i].Visible = false;
                    mMunitions[i].Location = new Point(mPlayer.Location.X + 20, mPlayer.Location.Y - i * 30);
                }
            }
        }

        private void mMoveEnemyTimer_Tick(object sender, EventArgs e)
        {
            MoveEnemies(mEnemies, mEnemySpeed);
        }

        private void MoveEnemies(PictureBox[] array, int speed)
        {
            for(int i = 0; i < array.Length; ++i)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > Height)
                    array[i].Location = new Point((i + 1) * 50, -200);
            }
        }

        private void Collision()
        {
            for(int i = 0; i < mEnemies.Length; ++i)
            {
                for(int j = 0; j < 3; ++j)
                    if (mMunitions[j].Bounds.IntersectsWith(mEnemies[i].Bounds))
                    {
                        mExplosion.controls.play();
                        mEnemies[i].Location = new Point((i + 1) * 50, -100);
                    }
                if (mPlayer.Bounds.IntersectsWith(mEnemies[i].Bounds))
                {
                    mExplosion.settings.volume = 30;
                    mExplosion.controls.play();
                    mPlayer.Visible = false;
                    GameOver("");
                }
            }

        }

        private void GameOver(string str)
        {
            mGRLabel.Text = str;
            mGRLabel.Location = new Point(120, 120);
            mGRLabel.Visible = true;
            mReplayButton.Visible = true;
            mExitButton.Visible = true;

            mGameBMedia.controls.stop();
            StopTimers();
        }

        private void StopTimers()
        {
            mMoveBgTimer.Stop();
            mMoveEnemyTimer.Stop();
            mMoveMunitionTimer.Stop();
            mEnemyMunitionTimer.Stop();
        }

        private void StartTimers()
        {
            mMoveBgTimer.Start();
            mMoveEnemyTimer.Start();
            mMoveMunitionTimer.Start();
            mEnemyMunitionTimer.Start();
        }

        private void mEnemyMunitionTimer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < mEnemyMuntions.Length; ++i)
            {
                if (mEnemyMuntions[i].Top < Height)
                {
                    mEnemyMuntions[i].Visible = true;
                    mEnemyMuntions[i].Top += mEnemyMunitionSpeed;

                    CollisionWithEnemyMunitions();
                }
                else
                {
                    mEnemyMuntions[i].Visible = false;
                    int x = mRandom.Next(0, 10);
                    mEnemyMuntions[i].Location = new Point(mEnemies[x].Location.X + 20, mEnemies[x].Location.Y + 30);
                }
            }
        }

        private void CollisionWithEnemyMunitions()
        {
            for(int i = 0; i < mEnemyMuntions.Length; ++i)
                if (mEnemyMuntions[i].Bounds.IntersectsWith(mPlayer.Bounds))
                {
                    mEnemyMuntions[i].Visible = false;
                    mExplosion.settings.volume = 30;
                    mExplosion.controls.play();
                    mPlayer.Visible = false;
                    GameOver("Game Over");
                }
        }

        private void mReplayButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

        private void mExitButton_Click(object sender, EventArgs e)
        {
            //Environment.Exit(1);
            Application.Exit();
        }
    }
}
