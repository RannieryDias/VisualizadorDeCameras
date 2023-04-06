using Newtonsoft.Json;
using VisualizadorDeCameras.Model;

namespace VisualizadorDeCameras.Util
{
    internal static class DeserializeJson
    {
        static internal List<Camera> GetCameras()
        {
            List<Camera> list = new List<Camera>();

            using (var streamReader = new StreamReader(@"./json/cameras.json"))
            {
                var jsonContent = streamReader.ReadToEnd();
                try
                {
                    list = JsonConvert.DeserializeObject<List<Camera>>(jsonContent);
                }
                catch (Exception)
                {

                    throw new Exception("Could not deserialize JSON object into a list of Cameras");
                }
            }

            return list;
        }
    }
}
