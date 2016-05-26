namespace ThreadsAndDelegates
{
    partial class BackgroundWorkerDemo
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
            this.StartButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.MyBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(98, 149);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(278, 149);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(98, 91);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(255, 23);
            this.pbStatus.TabIndex = 5;
            // 
            // MyBackgroundWorker
            // 
            this.MyBackgroundWorker.WorkerReportsProgress = true;
            this.MyBackgroundWorker.WorkerSupportsCancellation = true;
            this.MyBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MyBackgroundWorker_DoWork);
            this.MyBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.MyBackgroundWorker_ProgressChanged);
            this.MyBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.MyBackgroundWorker_RunWorkerCompleted);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(95, 37);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 13);
            this.OutputLabel.TabIndex = 6;
            // 
            // BackgroundWorkerDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 261);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StartButton);
            this.Name = "BackgroundWorkerDemo";
            this.Text = "BackgroundWorkerDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ProgressBar pbStatus;
        private System.ComponentModel.BackgroundWorker MyBackgroundWorker;
        private System.Windows.Forms.Label OutputLabel;
    }
}