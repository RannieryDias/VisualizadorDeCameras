using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorDeCameras
{
    internal class Requests
    {
        public List<Camera> cameraList { get;}

        public Requests()
        {
            cameraList =  GetCameras();
        }

        internal List<Camera> GetCameras()
        {
            List<Camera> list = new List<Camera>();

            using (var streamReader = new StreamReader(@"./json/cameras.json"))
            {
                var jsonContent = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<Camera>>(jsonContent);
            }
            
            return list;
        }
    }
}
