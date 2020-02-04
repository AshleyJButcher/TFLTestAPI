using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = APIRequest.GetRoadStatus(args[0]).GetAwaiter().GetResult();
            Console.WriteLine(output);
            if (output.Contains("not a valid road"))
            {
                Environment.Exit(418); //Im a Teapot
            }
        }
    }
}
