using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjekt
{
    //Class used for communication with DeviantArt as well as Download the images.
    class DAInterface
    {
        private WebClient webclient = new WebClient();
        //currently using Downloads as tempfile folder. 
        //We should consider using AppData\Local\da_app\ (dir da_app will be made at installation)
        //C:%HOMEPATH%\AppData\Local\da_app
        private string tempdir = @"C:%HOMEPATH%\Downloads\";
        public void downloadImage(DAImage dai)
        {
            webclient.DownloadFile(dai.img_url, tempdir + dai.d_ID + dai.filetype);
        }
    }
}
