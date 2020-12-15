
namespace FlappyBird
{
    partial class form1
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
            this.Flappy = new System.Windows.Forms.PictureBox();
            this.PipeDown = new System.Windows.Forms.PictureBox();
            this.Pipe = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreboard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Flappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Flappy
            // 
            this.Flappy.Image = global::FlappyBird.Properties.Resources.bird;
            this.Flappy.Location = new System.Drawing.Point(53, 186);
            this.Flappy.Name = "Flappy";
            this.Flappy.Size = new System.Drawing.Size(50, 38);
            this.Flappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flappy.TabIndex = 3;
            this.Flappy.TabStop = false;
            // 
            // PipeDown
            // 
            this.PipeDown.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.PipeDown.Location = new System.Drawing.Point(444, -1);
            this.PipeDown.Name = "PipeDown";
            this.PipeDown.Size = new System.Drawing.Size(85, 210);
            this.PipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeDown.TabIndex = 2;
            this.PipeDown.TabStop = false;
            // 
            // Pipe
            // 
            this.Pipe.Image = global::FlappyBird.Properties.Resources.pipe;
            this.Pipe.Location = new System.Drawing.Point(444, 358);
            this.Pipe.Name = "Pipe";
            this.Pipe.Size = new System.Drawing.Size(85, 65);
            this.Pipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pipe.TabIndex = 1;
            this.Pipe.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlappyBird.Properties.Resources.ground;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 423);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // scoreboard
            // 
            this.scoreboard.AutoSize = true;
            this.scoreboard.BackColor = System.Drawing.Color.SteelBlue;
            this.scoreboard.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboard.Location = new System.Drawing.Point(1, -1);
            this.scoreboard.Name = "scoreboard";
            this.scoreboard.Size = new System.Drawing.Size(170, 53);
            this.scoreboard.TabIndex = 4;
            this.scoreboard.Text = "Score:  0";
            this.scoreboard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.scoreboard.Click += new System.EventHandler(this.scoreboard_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreboard);
            this.Controls.Add(this.Flappy);
            this.Controls.Add(this.PipeDown);
            this.Controls.Add(this.Pipe);
            this.Controls.Add(this.pictureBox1);
            this.Name = "form1";
            this.Text = "FlappyBird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Flappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Pipe;
        private System.Windows.Forms.PictureBox PipeDown;
        private System.Windows.Forms.PictureBox Flappy;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreboard;
    }
}

