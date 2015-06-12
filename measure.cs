using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenseMeasureImporter
{
    public class measure
    {
        public bool useMeasure { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string tags { get; set; }
        public string definition { get; set; }
        public string validationMessage { get; set; }

        public measure()
        {
            useMeasure = true;
            title = "";
            description = "";
            tags = "";
            definition = "";
        }
    }
}
