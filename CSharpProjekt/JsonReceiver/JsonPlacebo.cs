using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjekt.JsonReceiver
{
    class JsonPlacebo
    {
        //the only argument I am sure we will get. Other arguments depend on this status
        //for example: status == "error"  -> error, error_description
        public string status;
        //this argument will probably be left empty if placebo succeeds. testing required.
        public string error;
    }
}
