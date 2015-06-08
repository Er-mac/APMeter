namespace APMeter
{
    partial class SettingsForm
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
            this.folderBrowserDialogGame = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxPathToGame = new System.Windows.Forms.TextBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.checkBoxShowTop = new System.Windows.Forms.CheckBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderBrowserDialogGame
            // 
            this.folderBrowserDialogGame.ShowNewFolderButton = false;
            // 
            // textBoxPathToGame
            // 
            this.textBoxPathToGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.textBoxPathToGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPathToGame.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPathToGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxPathToGame.Location = new System.Drawing.Point(122, 14);
            this.textBoxPathToGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPathToGame.Name = "textBoxPathToGame";
            this.textBoxPathToGame.ReadOnly = true;
            this.textBoxPathToGame.Size = new System.Drawing.Size(169, 23);
            this.textBoxPathToGame.TabIndex = 3;
            this.textBoxPathToGame.TabStop = false;
            // 
            // buttonCount
            // 
            this.buttonCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.buttonCount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.buttonCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCount.Location = new System.Drawing.Point(14, 13);
            this.buttonCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(100, 25);
            this.buttonCount.TabIndex = 4;
            this.buttonCount.TabStop = false;
            this.buttonCount.Text = "Путь к игре...";
            this.buttonCount.UseVisualStyleBackColor = false;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // checkBoxShowTop
            // 
            this.checkBoxShowTop.AutoSize = true;
            this.checkBoxShowTop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxShowTop.Location = new System.Drawing.Point(14, 50);
            this.checkBoxShowTop.Name = "checkBoxShowTop";
            this.checkBoxShowTop.Size = new System.Drawing.Size(239, 20);
            this.checkBoxShowTop.TabIndex = 5;
            this.checkBoxShowTop.Text = "Показывать поверх остальных окон";
            this.checkBoxShowTop.UseVisualStyleBackColor = true;
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelVersion.Location = new System.Drawing.Point(-1, 73);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(305, 18);
            this.labelVersion.TabIndex = 6;
            this.labelVersion.Text = "ver.";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(303, 91);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.checkBoxShowTop);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.textBoxPathToGame);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SettingsForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogGame;
        private System.Windows.Forms.TextBox textBoxPathToGame;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.CheckBox checkBoxShowTop;
        private System.Windows.Forms.Label labelVersion;
    }
}