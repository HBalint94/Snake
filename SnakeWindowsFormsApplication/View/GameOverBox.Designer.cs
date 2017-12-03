namespace SnakeWindowsFormsApplication.View
{
    partial class GameOverBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.textName = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.scoreTextLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.AutoSize = true;
            this.textName.Location = new System.Drawing.Point(21, 27);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(30, 13);
            this.textName.TabIndex = 0;
            this.textName.Text = "Név:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(98, 92);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // scoreTextLabel
            // 
            this.scoreTextLabel.AutoSize = true;
            this.scoreTextLabel.Location = new System.Drawing.Point(21, 53);
            this.scoreTextLabel.Name = "scoreTextLabel";
            this.scoreTextLabel.Size = new System.Drawing.Size(44, 13);
            this.scoreTextLabel.TabIndex = 4;
            this.scoreTextLabel.Text = "Pontok:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(71, 53);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(13, 13);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "0";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(57, 24);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(190, 20);
            this.nameBox.TabIndex = 6;
            // 
            // GameOverBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 146);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.scoreTextLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.textName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameOverBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Játék vége";
            this.Load += new System.EventHandler(this.GameOverBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textName;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label scoreTextLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox nameBox;
    }
}
