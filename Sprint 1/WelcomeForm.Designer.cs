namespace Sprint_1
{
    partial class welcomeForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.stayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.welcomeLabel.Location = new System.Drawing.Point(104, 83);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(627, 32);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome To Food Pantry Notification System";
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // stayLabel
            // 
            this.stayLabel.AutoEllipsis = true;
            this.stayLabel.AutoSize = true;
            this.stayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stayLabel.Location = new System.Drawing.Point(248, 255);
            this.stayLabel.Name = "stayLabel";
            this.stayLabel.Size = new System.Drawing.Size(200, 37);
            this.stayLabel.TabIndex = 2;
            this.stayLabel.Text = "Stay Tuned!";
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stayLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "welcomeForm";
            this.Text = "welcome Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label stayLabel;
    }
}