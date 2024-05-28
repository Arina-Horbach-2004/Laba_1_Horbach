namespace Library
{
    partial class Lab_1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            maintrackbar1 = new TrackBar();
            maintrackbar2 = new TrackBar();
            minLabel = new Label();
            maxLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)maintrackbar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maintrackbar2).BeginInit();
            SuspendLayout();
            // 
            // maintrackbar1
            // 
            maintrackbar1.Dock = DockStyle.Top;
            maintrackbar1.Location = new Point(0, 0);
            maintrackbar1.Name = "maintrackbar1";
            maintrackbar1.Size = new Size(800, 56);
            maintrackbar1.TabIndex = 0;
            maintrackbar1.Scroll += minTrackBar_Scroll;
            // 
            // maintrackbar2
            // 
            maintrackbar2.Location = new Point(0, 315);
            maintrackbar2.Name = "maintrackbar2";
            maintrackbar2.Size = new Size(800, 56);
            maintrackbar2.TabIndex = 1;
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            minLabel.Location = new Point(358, 59);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(67, 26);
            minLabel.TabIndex = 2;
            minLabel.Text = "label1";
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            maxLabel.Location = new Point(358, 394);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(67, 26);
            maxLabel.TabIndex = 3;
            maxLabel.Text = "label1";
            // 
            // Lab_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(maxLabel);
            Controls.Add(minLabel);
            Controls.Add(maintrackbar2);
            Controls.Add(maintrackbar1);
            Name = "Lab_1";
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)maintrackbar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)maintrackbar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar maintrackbar1;
        private TrackBar maintrackbar2;
        private Label minLabel;
        private Label maxLabel;
    }
}
