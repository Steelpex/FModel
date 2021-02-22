namespace FModel
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pictureboite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboite)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboite
            // 
            this.pictureboite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pictureboite.Location = new System.Drawing.Point(-2, -1);
            this.pictureboite.Margin = new System.Windows.Forms.Padding(2);
            this.pictureboite.Name = "pictureboite";
            this.pictureboite.Size = new System.Drawing.Size(504, 508);
            this.pictureboite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboite.TabIndex = 1;
            this.pictureboite.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 506);
            this.Controls.Add(this.pictureboite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Preview";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureboite;
    }
}