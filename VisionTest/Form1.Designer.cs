namespace VisionTest
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
            this.pbMainImage = new System.Windows.Forms.PictureBox();
            this.cbCameraList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMainImage
            // 
            this.pbMainImage.Location = new System.Drawing.Point(12, 12);
            this.pbMainImage.Name = "pbMainImage";
            this.pbMainImage.Size = new System.Drawing.Size(452, 459);
            this.pbMainImage.TabIndex = 0;
            this.pbMainImage.TabStop = false;
            // 
            // cbCameraList
            // 
            this.cbCameraList.FormattingEnabled = true;
            this.cbCameraList.Location = new System.Drawing.Point(778, 12);
            this.cbCameraList.Name = "cbCameraList";
            this.cbCameraList.Size = new System.Drawing.Size(201, 21);
            this.cbCameraList.TabIndex = 1;
            this.cbCameraList.SelectedIndexChanged += new System.EventHandler(this.cbCameraList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 485);
            this.Controls.Add(this.cbCameraList);
            this.Controls.Add(this.pbMainImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainImage;
        private System.Windows.Forms.ComboBox cbCameraList;
    }
}

