namespace SearchForWeek15B
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
            this.textListBox = new System.Windows.Forms.ListBox();
            this.matchedListBox = new System.Windows.Forms.ListBox();
            this.ptrLbl = new System.Windows.Forms.Label();
            this.ptrnTextBox = new System.Windows.Forms.TextBox();
            this.srcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textListBox
            // 
            this.textListBox.FormattingEnabled = true;
            this.textListBox.Location = new System.Drawing.Point(13, 13);
            this.textListBox.Name = "textListBox";
            this.textListBox.Size = new System.Drawing.Size(111, 199);
            this.textListBox.TabIndex = 0;
            // 
            // matchedListBox
            // 
            this.matchedListBox.FormattingEnabled = true;
            this.matchedListBox.Location = new System.Drawing.Point(142, 13);
            this.matchedListBox.Name = "matchedListBox";
            this.matchedListBox.Size = new System.Drawing.Size(130, 199);
            this.matchedListBox.TabIndex = 1;
            // 
            // ptrLbl
            // 
            this.ptrLbl.AutoSize = true;
            this.ptrLbl.Location = new System.Drawing.Point(13, 236);
            this.ptrLbl.Name = "ptrLbl";
            this.ptrLbl.Size = new System.Drawing.Size(41, 13);
            this.ptrLbl.TabIndex = 2;
            this.ptrLbl.Text = "Pattern";
            // 
            // ptrnTextBox
            // 
            this.ptrnTextBox.Location = new System.Drawing.Point(54, 233);
            this.ptrnTextBox.Name = "ptrnTextBox";
            this.ptrnTextBox.Size = new System.Drawing.Size(100, 20);
            this.ptrnTextBox.TabIndex = 3;
            // 
            // srcButton
            // 
            this.srcButton.Location = new System.Drawing.Point(197, 226);
            this.srcButton.Name = "srcButton";
            this.srcButton.Size = new System.Drawing.Size(75, 23);
            this.srcButton.TabIndex = 4;
            this.srcButton.Text = "Search";
            this.srcButton.UseVisualStyleBackColor = true;
            this.srcButton.Click += new System.EventHandler(this.srcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.srcButton);
            this.Controls.Add(this.ptrnTextBox);
            this.Controls.Add(this.ptrLbl);
            this.Controls.Add(this.matchedListBox);
            this.Controls.Add(this.textListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox textListBox;
        private System.Windows.Forms.ListBox matchedListBox;
        private System.Windows.Forms.Label ptrLbl;
        private System.Windows.Forms.TextBox ptrnTextBox;
        private System.Windows.Forms.Button srcButton;
    }
}

