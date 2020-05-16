namespace Music_Playlist
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button2 = new System.Windows.Forms.Button();
            this.ListOfSongs = new System.Windows.Forms.ListBox();
            this.addS = new System.Windows.Forms.Button();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.rmvS = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(673, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListOfSongs
            // 
            this.ListOfSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListOfSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfSongs.ForeColor = System.Drawing.Color.Aqua;
            this.ListOfSongs.FormattingEnabled = true;
            this.ListOfSongs.ItemHeight = 20;
            this.ListOfSongs.Location = new System.Drawing.Point(12, 23);
            this.ListOfSongs.Name = "ListOfSongs";
            this.ListOfSongs.Size = new System.Drawing.Size(159, 324);
            this.ListOfSongs.TabIndex = 4;
            this.ListOfSongs.SelectedIndexChanged += new System.EventHandler(this.ListOfSongs_SelectedIndexChanged);
            // 
            // addS
            // 
            this.addS.BackColor = System.Drawing.Color.Black;
            this.addS.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addS.ForeColor = System.Drawing.Color.Aqua;
            this.addS.Location = new System.Drawing.Point(33, 353);
            this.addS.Name = "addS";
            this.addS.Size = new System.Drawing.Size(93, 31);
            this.addS.TabIndex = 5;
            this.addS.Text = "ADD SONG";
            this.addS.UseVisualStyleBackColor = false;
            this.addS.Click += new System.EventHandler(this.addS_Click);
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(197, 45);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(463, 303);
            this.WindowsMediaPlayer.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(348, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "SONGS INFO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rmvS
            // 
            this.rmvS.BackColor = System.Drawing.Color.Red;
            this.rmvS.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmvS.ForeColor = System.Drawing.Color.Aqua;
            this.rmvS.Location = new System.Drawing.Point(33, 390);
            this.rmvS.Name = "rmvS";
            this.rmvS.Size = new System.Drawing.Size(93, 31);
            this.rmvS.TabIndex = 8;
            this.rmvS.Text = "REMOVE";
            this.rmvS.UseVisualStyleBackColor = false;
            this.rmvS.Click += new System.EventHandler(this.rmvS_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Aqua;
            this.button3.Location = new System.Drawing.Point(197, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "SHUFFLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(498, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 27);
            this.button4.TabIndex = 10;
            this.button4.Text = "FAVORITES *";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rmvS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Controls.Add(this.addS);
            this.Controls.Add(this.ListOfSongs);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ListOfSongs;
        private System.Windows.Forms.Button addS;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button rmvS;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}