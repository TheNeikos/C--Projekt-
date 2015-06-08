using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjekt.JsonReceiver
{
    /// <summary>
    /// This class is used to store information about a single Deviation which we'll get through the API
    /// </summary>
    public class JsonDeviation
    {
        public string deviationid;
        public string printid;
        public string url;
        public string title;
        public string category;
        public string category_path;
        public bool is_downloadable;
        public bool is_mature;
        public bool is_favourited;
        public bool is_deleted;
        public Author author;
        public Stats stats;
        public long published_time;
        public bool allows_comments;
        public Content content;
        public Thumbnail[] thumbs;
    }

    //all following classes are helper classes for JsonDeviation

    public class Author
    {
        public string userid;
        public string username;
        public string usericon;
        public string type;
    }

    public class Stats
    {
        public int comments;
        public int favourites;
    }

    public class Content
    {
        public string src;
        public int filesize;
        public int height;
        public int width;
        public bool transparency;
    }

    public class Thumbnail
    {
        public string src;
        public int height;
        public int width;
        public bool transparency;
    }
}
