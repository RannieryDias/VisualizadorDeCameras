namespace VisualizadorDeCameras
{
    public partial class MainWindow : Form
    {
        Requests requests;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void RequestBtn_Click(object sender, EventArgs e)
        {
            List<Camera> cameras;
            if (requests == null)
            {
                requests = new Requests();
                cameras = requests.GetCameras();
            }
            else
            {
                cameras = requests.GetCameras();
            }

            foreach (Camera cam in cameras)
            {
                ImageContainer image = new ImageContainer(cam.Url, cam.Number);
                ImageContainerFlowLayout.Controls.Add(image);
            }
        }
    }
}