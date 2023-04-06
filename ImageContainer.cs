namespace VisualizadorDeCameras
{
    public partial class ImageContainer : UserControl
    {
        public string Url { get; }
        public int Id { get; set; }
        public ImageContainer(string url, int id)
        {
            Url = url;
            Id = id;
            InitializeComponent();
        }

        private void ImageContainer_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void ImageContainer_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Highlight;

        }

        private void ImageContainer_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Window;

        }
    }
}
