namespace VisualizadorDeCameras
{
    partial class MainWindow
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
            RequestBtn = new Button();
            ImageContainerFlowLayout = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // RequestBtn
            // 
            RequestBtn.Location = new Point(347, 400);
            RequestBtn.Name = "RequestBtn";
            RequestBtn.Size = new Size(75, 23);
            RequestBtn.TabIndex = 0;
            RequestBtn.Text = "Atualizar";
            RequestBtn.UseVisualStyleBackColor = true;
            RequestBtn.Click += RequestBtn_Click;
            // 
            // ImageContainerFlowLayout
            // 
            ImageContainerFlowLayout.AutoScroll = true;
            ImageContainerFlowLayout.Location = new Point(12, 12);
            ImageContainerFlowLayout.Name = "ImageContainerFlowLayout";
            ImageContainerFlowLayout.Size = new Size(776, 382);
            ImageContainerFlowLayout.TabIndex = 1;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ImageContainerFlowLayout);
            Controls.Add(RequestBtn);
            Name = "MainWindow";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button RequestBtn;
        private FlowLayoutPanel ImageContainerFlowLayout;
    }
}