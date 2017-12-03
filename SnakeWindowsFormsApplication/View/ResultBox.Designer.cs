namespace SnakeWindowsFormsApplication.View
{
    partial class ResultBox
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
            this.resultList = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultList
            // 
            this.resultList.FormattingEnabled = true;
            this.resultList.Location = new System.Drawing.Point(12, 12);
            this.resultList.Name = "resultList";
            this.resultList.Size = new System.Drawing.Size(248, 186);
            this.resultList.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(94, 224);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Bezárás";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(CloseButton_Click);
            // 
            // ResultBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 283);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.resultList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eredmény lista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox resultList;
        private System.Windows.Forms.Button closeButton;
    }
}
