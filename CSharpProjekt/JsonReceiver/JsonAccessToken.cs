using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjekt.JsonReceiver
{
    class JsonAccessToken
    {
        public int expires_in;
        //API Doc states indirectly that in this case, "error" will not be written into status
        public string status;
        public string access_token;
        public string token_type;
        //reason for error (if one happens)
        public string error;

    }
}
