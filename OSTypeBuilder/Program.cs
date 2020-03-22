using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSTypeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder bld = new Builder();

            Console.WriteLine("Enter OS type: ");
            Console.WriteLine("(Use 'h' for Home, 'p' for Professional, 'e' for Enterprise or enter full type name)");

            string type = Console.ReadLine();

            switch (type)
            {
                case "h":
                    type = "Home";
                    break;
                case "p":
                    type = "Professional";
                    break;
                case "e":
                    type = "Enterprise";
                    break;
            }

            Console.WriteLine();

            try
            {
                OSType os = bld.Build(type);

                os.showInfo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                if(e.InnerException != null)
                {
                    Console.WriteLine(e.InnerException.Message);
                }
            }
            

            Console.ReadKey();
        }
    }
}
