namespace SortingAlgorithms
{
    partial class SortingForm
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
            this.runWorker = new System.ComponentModel.BackgroundWorker();
            this.renderBox = new System.Windows.Forms.Label();
            this.shuffleLabel = new DarkControls.ActiveLabel();
            this.sortLabel = new DarkControls.ActiveLabel();
            this.SuspendLayout();
            // 
            // runWorker
            // 
            this.runWorker.WorkerReportsProgress = true;
            this.runWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RunWorker_DoWork);
            this.runWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.RunWorker_ProgressChanged);
            this.runWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.RunWorker_RunWorkerCompleted);
            // 
            // renderBox
            // 
            this.renderBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.renderBox.Location = new System.Drawing.Point(12, 12);
            this.renderBox.Name = "renderBox";
            this.renderBox.Size = new System.Drawing.Size(600, 276);
            this.renderBox.TabIndex = 2;
            this.renderBox.Visible = false;
            // 
            // shuffleLabel
            // 
            this.shuffleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shuffleLabel.Location = new System.Drawing.Point(368, 298);
            this.shuffleLabel.Name = "shuffleLabel";
            this.shuffleLabel.Size = new System.Drawing.Size(75, 23);
            this.shuffleLabel.TabIndex = 1;
            this.shuffleLabel.Text = "Shuffle";
            this.shuffleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shuffleLabel.Click += new System.EventHandler(this.ShuffleLabel_Click);
            // 
            // sortLabel
            // 
            this.sortLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sortLabel.Location = new System.Drawing.Point(287, 298);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(75, 23);
            this.sortLabel.TabIndex = 3;
            this.sortLabel.Text = "Sort";
            this.sortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sortLabel.Click += new System.EventHandler(this.SortLabel_Click);
            // 
            // SortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.shuffleLabel);
            this.Controls.Add(this.renderBox);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "SortingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker runWorker;
        private DarkControls.ActiveLabel shuffleLabel;
        private System.Windows.Forms.Label renderBox;
        private DarkControls.ActiveLabel sortLabel;
    }
}

