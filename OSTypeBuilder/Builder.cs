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

        /// <summary>Adds Home type features to OS feature list</summary>
        private void AddHomeFeature()
        {
            os.features.Add("Turns on and off");
        }

        /// <summary>Adds Professional type features to OS feature list</summary>
        private void AddProFeature()
        {
            os.features.Add("Lags no more than once a day");
        }

        /// <summary>Adds Enterprise type features to OS feature list</summary>
        private void AddEntFeature()
        {
            os.features.Add("Automatic updates deactivated");
        }

        /// <summary>Builds OSType object adding features depending on OS type</summary>
        /// <param name="_type">OS type</param>
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
