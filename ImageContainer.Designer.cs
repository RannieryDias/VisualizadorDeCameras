namespace VisualizadorDeCameras
{
    partial class ImageContainer
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
            image = new PictureBox();
            imageLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            SuspendLayout();
            // 
            // image
            // 
            image.Anchor = AnchorStyles.Top;
            image.BackColor = SystemColors.Window;
            image.Location = new Point(0, 1);
            image.Name = "image";
            image.LoadAsync(Url);
            image.Size = new Size(150, 125);
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.TabIndex = 0;
            image.TabStop = false;
            image.MouseEnter += ImageContainer_MouseEnter;
            image.MouseLeave += ImageContainer_MouseLeave;
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new Point(59, 129);
            imageLabel.Name = "imageLabel";
            imageLabel.Text = Id.ToString();
            imageLabel.Size = new Size(0, 15);
            imageLabel.TabIndex = 1;
            imageLabel.MouseEnter += ImageContainer_MouseEnter;
            imageLabel.MouseLeave += ImageContainer_MouseLeave;
            // 
            // ImageContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(imageLabel);
            Controls.Add(image);
            Name = "ImageContainer";
            MouseEnter += ImageContainer_MouseEnter;
            MouseLeave += ImageContainer_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox image;
        private Label imageLabel;
    }
}
