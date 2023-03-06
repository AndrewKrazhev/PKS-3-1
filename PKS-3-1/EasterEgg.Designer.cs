namespace PKS_3_1
{
    partial class EasterEgg
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
            this.SuspendLayout();
            // 
            // EasterEgg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PKS_3_1.Properties.Resources._2023_02_28_10_14_50;
            this.ClientSize = new System.Drawing.Size(395, 495);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EasterEgg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasterEgg";
            this.Load += new System.EventHandler(this.EasterEgg_Load);
            this.DoubleClick += new System.EventHandler(this.EasterEgg_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion
    }
}