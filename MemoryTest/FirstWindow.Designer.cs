namespace MemoryGame
{
    partial class FirstWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstWindow));
            this.playMultiplayerBtn = new System.Windows.Forms.Button();
            this.exitBtnFirstWindow = new System.Windows.Forms.Button();
            this.showFaceCardsTimer = new System.Windows.Forms.Timer(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.rulesBtn = new System.Windows.Forms.Button();
            this.multiplayertoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PlaySinglePlayerBtn = new System.Windows.Forms.Button();
            this.HowToPlaytoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CountdownTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // playMultiplayerBtn
            // 
            this.playMultiplayerBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playMultiplayerBtn.Location = new System.Drawing.Point(129, 338);
            this.playMultiplayerBtn.Name = "playMultiplayerBtn";
            this.playMultiplayerBtn.Size = new System.Drawing.Size(119, 28);
            this.playMultiplayerBtn.TabIndex = 0;
            this.playMultiplayerBtn.Text = "Play Multiplayer";
            this.multiplayertoolTip.SetToolTip(this.playMultiplayerBtn, "2 Players Game");
            this.playMultiplayerBtn.UseVisualStyleBackColor = true;
            this.playMultiplayerBtn.Click += new System.EventHandler(this.MultiplayerButton_Click);
            // 
            // exitBtnFirstWindow
            // 
            this.exitBtnFirstWindow.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtnFirstWindow.Location = new System.Drawing.Point(129, 431);
            this.exitBtnFirstWindow.Name = "exitBtnFirstWindow";
            this.exitBtnFirstWindow.Size = new System.Drawing.Size(119, 25);
            this.exitBtnFirstWindow.TabIndex = 2;
            this.exitBtnFirstWindow.Text = "Exit";
            this.exitBtnFirstWindow.UseVisualStyleBackColor = true;
            this.exitBtnFirstWindow.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // showFaceCardsTimer
            // 
            this.showFaceCardsTimer.Tick += new System.EventHandler(this.perioada_Tick);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(70, 54);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(257, 219);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // rulesBtn
            // 
            this.rulesBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesBtn.Location = new System.Drawing.Point(129, 376);
            this.rulesBtn.Name = "rulesBtn";
            this.rulesBtn.Size = new System.Drawing.Size(119, 26);
            this.rulesBtn.TabIndex = 4;
            this.rulesBtn.Text = "How To Play";
            this.HowToPlaytoolTip.SetToolTip(this.rulesBtn, "The Rules Of The Game");
            this.rulesBtn.UseVisualStyleBackColor = true;
            this.rulesBtn.Click += new System.EventHandler(this.rulesBtn_Click);
            // 
            // PlaySinglePlayerBtn
            // 
            this.PlaySinglePlayerBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaySinglePlayerBtn.Location = new System.Drawing.Point(129, 294);
            this.PlaySinglePlayerBtn.Name = "PlaySinglePlayerBtn";
            this.PlaySinglePlayerBtn.Size = new System.Drawing.Size(119, 29);
            this.PlaySinglePlayerBtn.TabIndex = 5;
            this.PlaySinglePlayerBtn.Text = "Play";
            this.multiplayertoolTip.SetToolTip(this.PlaySinglePlayerBtn, "1 Player Game");
            this.PlaySinglePlayerBtn.UseVisualStyleBackColor = true;
            this.PlaySinglePlayerBtn.Click += new System.EventHandler(this.SinglePlayerButton_Click);
            // 
            // CountdownTimer
            // 
            this.CountdownTimer.Interval = 1000;
            this.CountdownTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FirstWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(389, 480);
            this.Controls.Add(this.PlaySinglePlayerBtn);
            this.Controls.Add(this.rulesBtn);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.exitBtnFirstWindow);
            this.Controls.Add(this.playMultiplayerBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playMultiplayerBtn;
        private System.Windows.Forms.Button exitBtnFirstWindow;
        public System.Windows.Forms.Timer showFaceCardsTimer;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button rulesBtn;
        private System.Windows.Forms.ToolTip multiplayertoolTip;
        private System.Windows.Forms.ToolTip HowToPlaytoolTip;
        private System.Windows.Forms.Button PlaySinglePlayerBtn;
        private System.Windows.Forms.Timer CountdownTimer;
    }
}

