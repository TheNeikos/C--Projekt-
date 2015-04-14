using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpProjekt
{
    //core information about a picture
    class DAImage
    {
        //deviation ID
        public string d_ID;
        public string title;
        public string category;
        public string author;
        //weburl of the image
        public string img_url;
        //filetype with the . (.jpg, .bmp, .gif, ...)
        public string filetype;
        public int height;
        public int width;
        public string thumbnail_url;
    }
}
