﻿namespace SortingAlgorithms
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
            this.renderBox = new System.Windows.Forms.PictureBox();
            this.shuffleLabel = new SortingAlgorithms.ActiveLabel();
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // runWorker
            // 
            this.runWorker.WorkerReportsProgress = true;
            this.runWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RunWorker_DoWork);
            this.runWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.RunWorker_ProgressChanged);
            // 
            // renderBox
            // 
            this.renderBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.renderBox.Location = new System.Drawing.Point(12, 12);
            this.renderBox.Name = "renderBox";
            this.renderBox.Size = new System.Drawing.Size(600, 200);
            this.renderBox.TabIndex = 0;
            this.renderBox.TabStop = false;
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
            // SortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shuffleLabel);
            this.Controls.Add(this.renderBox);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "SortingForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker runWorker;
        private System.Windows.Forms.PictureBox renderBox;
        private ActiveLabel shuffleLabel;
    }
}

