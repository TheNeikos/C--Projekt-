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

        public DAImage(
            string _d_ID,
            string _title,
            string _category,
            string _author,
            string _img_url,
            string _filetype,
            int _height,
            int _width,
            string _thumbnail_url)
        {
            d_ID = _d_ID;
            title = _title;
            category = _category;
            author = _author;
            img_url = _img_url;
            filetype = _filetype;
            height = _height;
            width = _width;
            thumbnail_url = _thumbnail_url;
        }
    }
}
