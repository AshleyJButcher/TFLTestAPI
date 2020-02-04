using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLTest
{
    public class RoadDescription
    {
        public string type;

        //ERROR Parameters
        public string timestampUtc;
        public string exceptionType;
        public int httpStatusCode = 200;
        public string httpStatus;
        public string relativeUri;
        public string message;

        //Valid Parameters
        public string id;
        public string displayName;
        public string statusSeverity;
        public string statusSeverityDescription;
        public string bounds;
        public string envelope;
        public string url;
    }
}
