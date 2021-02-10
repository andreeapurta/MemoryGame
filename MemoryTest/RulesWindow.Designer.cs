namespace MemoryGame
{
    partial class RulesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesWindow));
            this.exitBtnRulesWindow = new System.Windows.Forms.Button();
            this.rulesTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // exitBtnRulesWindow
            // 
            this.exitBtnRulesWindow.BackColor = System.Drawing.Color.White;
            this.exitBtnRulesWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtnRulesWindow.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtnRulesWindow.ForeColor = System.Drawing.Color.Black;
            this.exitBtnRulesWindow.Location = new System.Drawing.Point(329, 12);
            this.exitBtnRulesWindow.Name = "exitBtnRulesWindow";
            this.exitBtnRulesWindow.Size = new System.Drawing.Size(96, 34);
            this.exitBtnRulesWindow.TabIndex = 0;
            this.exitBtnRulesWindow.Text = "Exit";
            this.exitBtnRulesWindow.UseVisualStyleBackColor = false;
            this.exitBtnRulesWindow.Click += new System.EventHandler(this.exitBtnRulesWindow_Click);
            // 
            // rulesTextBox
            // 
            this.rulesTextBox.BackColor = System.Drawing.Color.White;
            this.rulesTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesTextBox.Location = new System.Drawing.Point(12, 63);
            this.rulesTextBox.Name = "rulesTextBox";
            this.rulesTextBox.ReadOnly = true;
            this.rulesTextBox.Size = new System.Drawing.Size(413, 375);
            this.rulesTextBox.TabIndex = 1;
            this.rulesTextBox.Text = resources.GetString("rulesTextBox.Text");
            this.rulesTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // RulesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.rulesTextBox);
            this.Controls.Add(this.exitBtnRulesWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RulesWindow";
            this.Text = "RulesWindow";
            this.Load += new System.EventHandler(this.RulesWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtnRulesWindow;
        private System.Windows.Forms.RichTextBox rulesTextBox;
    }
}