namespace ThreadsAndDelegates
{
    partial class DirectorySearcherForm
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.directorySearcher = new ThreadsAndDelegates.DirectorySearcher();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(28, 22);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(85, 39);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(134, 32);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(224, 20);
            this.searchText.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(28, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 173);
            this.listBox1.TabIndex = 2;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(28, 272);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(0, 13);
            this.SearchLabel.TabIndex = 3;
            // 
            // directorySearcher
            // 
            this.directorySearcher.Location = new System.Drawing.Point(211, 272);
            this.directorySearcher.Name = "directorySearcher";
            this.directorySearcher.SearchCriteria = null;
            this.directorySearcher.Size = new System.Drawing.Size(75, 23);
            this.directorySearcher.TabIndex = 4;
            this.directorySearcher.Text = "directorySearcher1";
            // 
            // DirectorySearcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 312);
            this.Controls.Add(this.directorySearcher);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.SearchButton);
            this.Name = "DirectorySearcherForm";
            this.Text = "DirectorySearcherForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label SearchLabel;
        private DirectorySearcher directorySearcher;
    }
}