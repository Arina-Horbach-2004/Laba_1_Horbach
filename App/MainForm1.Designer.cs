namespace App
{
    partial class MainForm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            intervaltrack = new Library.Lab_1();
            label1 = new Label();
            SuspendLayout();
            // 
            // intervaltrack
            // 
            intervaltrack.Dock = DockStyle.Fill;
            intervaltrack.Location = new Point(0, 0);
            intervaltrack.MainTrackBar1MaxValue = 100;
            intervaltrack.MainTrackBar1MinValue = 0;
            intervaltrack.MainTrackBar2MaxValue = 100;
            intervaltrack.MainTrackBar2MinValue = 0;
            intervaltrack.Name = "intervaltrack";
            intervaltrack.Size = new Size(800, 450);
            intervaltrack.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(345, 176);
            label1.Name = "label1";
            label1.Size = new Size(67, 26);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // MainForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(intervaltrack);
            Name = "MainForm1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Library.Lab_1 intervaltrack;
        private Label label1;
    }
}
