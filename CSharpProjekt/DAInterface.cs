using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CSharpProjekt.JsonReceiver;

namespace CSharpProjekt
{
    //Class used for communication with DeviantArt as well as for downloading the images.
    sealed class DAInterface
    {
        //We are doing all communications with this class, on other words it may become quite big.
        //In short, we only want one instance of it to not waste ressources

        private static DAInterface instance;

        private DAInterface()
        {
        }

        public static DAInterface Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAInterface();
                }
                return instance;
            }
        }

        private WebClient webclient = new WebClient();

        private JsonAccessToken accToken;

        /// <summary>
        /// authenticates this app using client_id and client_secret at deviantart, so we may get stuff from their api
        /// </summary>
        private bool authenticate()
        {
            HttpWebRequest request = WebRequest.CreateHttp("https://www.deviantart.com/oauth2/token?client_id=" + "" + "&client_secret=" + "" + "&grant_type=client_credentials");
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            Stream inStr = response.GetResponseStream();
            StreamReader strRead = new StreamReader(inStr);
            string str = strRead.ReadToEnd();
            accToken = JsonConvert.DeserializeObject<JsonAccessToken>(str);
            //if either the status is null or it says "error", go in there.
            if (accToken.status != null ? accToken.status == "error" : true)
            {
                return false;
            }
            return true;
            //TODO: deserialize str from json to JsonAccessToken, handle errors
        }

        //currently using Downloads as tempfile folder. 
        //We should consider using AppData\Local\da_app\ (dir da_app will be made at installation)
        //C:%HOMEPATH%\AppData\Local\da_app
        private string tempdir = @"C:%HOMEPATH%\Downloads\";

        /// <summary>
        /// download the image located at dai.img_url
        /// </summary>
        /// <param name="dai">DAImage class containing core information about a deviation</param>
        public void downloadImage(DAImage dai)
        {
            webclient.DownloadFile(dai.img_url, tempdir + dai.d_ID + dai.filetype);
        }
    }
}
