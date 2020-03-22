using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSTypeBuilder
{
    class Builder
    {
        private OSType os;

        private void AddHomeFeature()
        {
            os.features.Add("Turns on and off");
        }
        private void AddProFeature()
        {
            os.features.Add("Lags no more than once a day");
        }
        private void AddEntFeature()
        {
            os.features.Add("Automatic updates deactivated");
        }

        public OSType Build(string _type)
        {
            os = new OSType();
            os.type = _type;
            os.features = new List<string>();

            switch (os.type)
            {
                case "Home":
                    AddHomeFeature();
                    break;
                case "Professional":
                    AddHomeFeature();
                    AddProFeature();
                    break;
                case "Enterprise":
                    AddHomeFeature();
                    AddProFeature();
                    AddEntFeature();
                    break;
                default:
                    throw new Exception(message: "Wrong OS type.");
            }
            return os;
        }
    }
}
