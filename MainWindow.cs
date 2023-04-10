using VisualizadorDeCameras.Model;
using VisualizadorDeCameras.Util;

namespace VisualizadorDeCameras
{
    public partial class MainWindow : Form
    {
        List<Camera> cameras;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            cameras ??= DeserializeJson.GetCameras();

            ImageContainerFlowLayout.Controls.Clear();

            foreach (Camera cam in cameras)
            {
                ImageContainer image = new ImageContainer(cam.Url, cam.Number);
                image.Click += Image_Click;
                ImageContainerFlowLayout.Controls.Add(image);
            }
        }

        private void Image_Click(object? sender, EventArgs e)
        {
            var selectedCamera = sender as ImageContainer;


            if (selectedCamera != null)
            {
                Form popUp = new Form 
                {
                    Text = selectedCamera.Name,
                };
                popUp.Controls.Add(selectedCamera.image);
                popUp.ShowDialog();
            }
        }
    }
}