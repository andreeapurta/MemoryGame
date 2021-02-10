namespace MemoryGame
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnExitMainWindow = new System.Windows.Forms.Button();
            this.player1Color = new System.Windows.Forms.TextBox();
            this.player2Color = new System.Windows.Forms.MaskedTextBox();
            this.scorePlayer1TextBox = new System.Windows.Forms.MaskedTextBox();
            this.scorePlayer1Label = new System.Windows.Forms.Label();
            this.scorePlayer2Label = new System.Windows.Forms.Label();
            this.scorePlayer2TextBox = new System.Windows.Forms.MaskedTextBox();
            this.countdownLbl = new System.Windows.Forms.Label();
            this.player1TurnLbl = new System.Windows.Forms.Label();
            this.player2TurnLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExitMainWindow
            // 
            this.btnExitMainWindow.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitMainWindow.Location = new System.Drawing.Point(1145, 23);
            this.btnExitMainWindow.Name = "btnExitMainWindow";
            this.btnExitMainWindow.Size = new System.Drawing.Size(124, 31);
            this.btnExitMainWindow.TabIndex = 0;
            this.btnExitMainWindow.Text = "Exit";
            this.btnExitMainWindow.UseVisualStyleBackColor = true;
            this.btnExitMainWindow.Click += new System.EventHandler(this.btnExitMainWindow_Click);
            // 
            // player1Color
            // 
            this.player1Color.BackColor = System.Drawing.Color.Blue;
            this.player1Color.Enabled = false;
            this.player1Color.ForeColor = System.Drawing.Color.Red;
            this.player1Color.Location = new System.Drawing.Point(1230, 107);
            this.player1Color.Name = "player1Color";
            this.player1Color.Size = new System.Drawing.Size(39, 20);
            this.player1Color.TabIndex = 1;
            this.player1Color.TextChanged += new System.EventHandler(this.player1Color_Click);
            // 
            // player2Color
            // 
            this.player2Color.BackColor = System.Drawing.Color.Red;
            this.player2Color.Enabled = false;
            this.player2Color.Location = new System.Drawing.Point(1230, 141);
            this.player2Color.Name = "player2Color";
            this.player2Color.Size = new System.Drawing.Size(39, 20);
            this.player2Color.TabIndex = 2;
            this.player2Color.Visible = false;
            this.player2Color.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.player2Color_Click);
            // 
            // scorePlayer1TextBox
            // 
            this.scorePlayer1TextBox.BackColor = System.Drawing.Color.Gray;
            this.scorePlayer1TextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorePlayer1TextBox.ForeColor = System.Drawing.Color.White;
            this.scorePlayer1TextBox.Location = new System.Drawing.Point(1230, 506);
            this.scorePlayer1TextBox.Name = "scorePlayer1TextBox";
            this.scorePlayer1TextBox.Size = new System.Drawing.Size(39, 23);
            this.scorePlayer1TextBox.TabIndex = 2;
            this.scorePlayer1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.scorePlayer1TextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.playerLabel2_Click);
            // 
            // scorePlayer1Label
            // 
            this.scorePlayer1Label.AutoSize = true;
            this.scorePlayer1Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorePlayer1Label.ForeColor = System.Drawing.Color.White;
            this.scorePlayer1Label.Location = new System.Drawing.Point(1066, 506);
            this.scorePlayer1Label.Name = "scorePlayer1Label";
            this.scorePlayer1Label.Size = new System.Drawing.Size(0, 20);
            this.scorePlayer1Label.TabIndex = 3;
            this.scorePlayer1Label.Click += new System.EventHandler(this.playerLabel1_Click);
            // 
            // scorePlayer2Label
            // 
            this.scorePlayer2Label.AutoSize = true;
            this.scorePlayer2Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorePlayer2Label.ForeColor = System.Drawing.Color.White;
            this.scorePlayer2Label.Location = new System.Drawing.Point(1066, 546);
            this.scorePlayer2Label.Name = "scorePlayer2Label";
            this.scorePlayer2Label.Size = new System.Drawing.Size(0, 20);
            this.scorePlayer2Label.TabIndex = 3;
            this.scorePlayer2Label.Click += new System.EventHandler(this.playerLabel1_Click);
            // 
            // scorePlayer2TextBox
            // 
            this.scorePlayer2TextBox.BackColor = System.Drawing.Color.Gray;
            this.scorePlayer2TextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorePlayer2TextBox.ForeColor = System.Drawing.Color.White;
            this.scorePlayer2TextBox.HideSelection = false;
            this.scorePlayer2TextBox.Location = new System.Drawing.Point(1230, 543);
            this.scorePlayer2TextBox.Name = "scorePlayer2TextBox";
            this.scorePlayer2TextBox.Size = new System.Drawing.Size(39, 23);
            this.scorePlayer2TextBox.TabIndex = 2;
            this.scorePlayer2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.scorePlayer2TextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.playerLabel2_Click);
            // 
            // countdownLbl
            // 
            this.countdownLbl.AutoSize = true;
            this.countdownLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.countdownLbl.Location = new System.Drawing.Point(1186, 243);
            this.countdownLbl.Name = "countdownLbl";
            this.countdownLbl.Size = new System.Drawing.Size(51, 20);
            this.countdownLbl.TabIndex = 4;
            this.countdownLbl.Text = "Timer";
            this.countdownLbl.Visible = false;
            this.countdownLbl.Click += new System.EventHandler(this.countdownLbl_Click);
            // 
            // player1TurnLbl
            // 
            this.player1TurnLbl.AutoSize = true;
            this.player1TurnLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1TurnLbl.ForeColor = System.Drawing.Color.White;
            this.player1TurnLbl.Location = new System.Drawing.Point(1096, 107);
            this.player1TurnLbl.MaximumSize = new System.Drawing.Size(125, 25);
            this.player1TurnLbl.Name = "player1TurnLbl";
            this.player1TurnLbl.Size = new System.Drawing.Size(0, 20);
            this.player1TurnLbl.TabIndex = 6;
            this.player1TurnLbl.Click += new System.EventHandler(this.playerLabel1_Click_1);
            // 
            // player2TurnLbl
            // 
            this.player2TurnLbl.AutoSize = true;
            this.player2TurnLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2TurnLbl.ForeColor = System.Drawing.Color.White;
            this.player2TurnLbl.Location = new System.Drawing.Point(1096, 141);
            this.player2TurnLbl.MaximumSize = new System.Drawing.Size(125, 25);
            this.player2TurnLbl.Name = "player2TurnLbl";
            this.player2TurnLbl.Size = new System.Drawing.Size(0, 20);
            this.player2TurnLbl.TabIndex = 6;
            this.player2TurnLbl.Visible = false;
            this.player2TurnLbl.Click += new System.EventHandler(this.playerLabel1_Click_1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1293, 577);
            this.Controls.Add(this.player2TurnLbl);
            this.Controls.Add(this.player1TurnLbl);
            this.Controls.Add(this.countdownLbl);
            this.Controls.Add(this.scorePlayer2Label);
            this.Controls.Add(this.scorePlayer1Label);
            this.Controls.Add(this.scorePlayer2TextBox);
            this.Controls.Add(this.scorePlayer1TextBox);
            this.Controls.Add(this.player2Color);
            this.Controls.Add(this.player1Color);
            this.Controls.Add(this.btnExitMainWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitMainWindow;
        public System.Windows.Forms.TextBox player1Color;
        public System.Windows.Forms.MaskedTextBox player2Color;
        public System.Windows.Forms.MaskedTextBox scorePlayer1TextBox;
        public System.Windows.Forms.MaskedTextBox scorePlayer2TextBox;
        public System.Windows.Forms.Label scorePlayer2Label;
        public System.Windows.Forms.Label scorePlayer1Label;
        public System.Windows.Forms.Label countdownLbl;
        public System.Windows.Forms.Label player1TurnLbl;
        public System.Windows.Forms.Label player2TurnLbl;
    }
}