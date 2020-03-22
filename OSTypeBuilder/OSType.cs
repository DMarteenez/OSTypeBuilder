using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSTypeBuilder
{
    class OSType
    {
        /// <summary>OS type</summary>
        public string type;
        /// <summary>OS features</summary>
        public List<string> features;

        /// <summary>Prints OS type and features to console</summary>
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
