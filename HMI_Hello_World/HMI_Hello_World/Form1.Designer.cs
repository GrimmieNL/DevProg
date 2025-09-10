namespace HMI_Hello_World
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
            this.HMIGroupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // HMIGroupBox
            // 
            this.HMIGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HMIGroupBox.Location = new System.Drawing.Point(12, 12);
            this.HMIGroupBox.Name = "HMIGroupBox";
            this.HMIGroupBox.Size = new System.Drawing.Size(776, 426);
            this.HMIGroupBox.TabIndex = 0;
            this.HMIGroupBox.TabStop = false;
            this.HMIGroupBox.Text = "HMI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HMIGroupBox);
            this.Name = "Form1";
            this.Text = "Hello World";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox HMIGroupBox;
    }
}

