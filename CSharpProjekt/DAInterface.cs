using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjekt
{
    //Class used for communication with DeviantArt as well as for downloading the images.
    sealed class DAInterface
    {
        //We are doing all communications with this class, on other words it may become quite big.
        //In short, we only want one instance of it to not waste ressources

        private static readonly DAInterface instance = new DAInterface();

        private DAInterface()
        {
        }

        public static DAInterface Instance
        {
            get
            {
                return instance;
            }
        }

        private WebClient webclient = new WebClient();

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
