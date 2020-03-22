using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSTypeBuilder
{
    class OSType
    {
        public string type;
        public List<string> features;

        public void showInfo()
        {
            Console.WriteLine("OS Type: " + type);
            Console.WriteLine("Features:");
            foreach (string s in features)
            {
                Console.WriteLine("> " + s);
            }
        }
    }
}
