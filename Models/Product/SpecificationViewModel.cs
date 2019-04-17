using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eastcoast.Models.Product
{
    public class SpecificationViewModel
    {
        public SpecificationViewModel(string body, string neck, string fingerboard, string contruction, string pickups, string scaleLength, bool isAmp)
        {
            Body = body;
            Neck = neck;
            Fingerboard = fingerboard;
            Contruction = contruction;
            Pickups = pickups;
            ScaleLength = scaleLength;
            IsAmp = isAmp;
        }

        public string Body { get; set; }

        public string Neck { get; set; }

        public string Fingerboard { get; set; }

        public string Contruction { get; set; }

        public string Pickups { get; set; }

        public string ScaleLength { get; set; }

        public bool IsAmp { get; set; }
    }
}