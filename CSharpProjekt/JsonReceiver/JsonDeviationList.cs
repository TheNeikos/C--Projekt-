using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjekt.JsonReceiver
{
    class JsonDeviationList
    {
        public bool has_more;
        public int next_offset;
        public JsonDeviation[] results;
    }
}
