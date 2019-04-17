using Eastcoast.Models.WhereToBuy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eastcoast.Helpers
{
    public class WhereToBuyHelper
    {
        public static IList<RetailerViewModel> RandomiseOrder(IList<RetailerViewModel> retailers)
        {
            object x = new object();

            if (HttpRuntime.Cache["BrandPosition"] == null)
            {
                lock (x)
                {
                    if (HttpRuntime.Cache["BrandPosition"] == null)
                    {
                        HttpRuntime.Cache["BrandPosition"] = 0;
                    }
                }
            }

            int brandPosition = (int)HttpRuntime.Cache["BrandPosition"];

            lock(x)
            {
                HttpRuntime.Cache["BrandPosition"] = (brandPosition + 1) % 6;
            }

            switch (brandPosition) {
                case 1:
                    return new List<RetailerViewModel>() { retailers[0], retailers[2], retailers[1] };
                case 2:
                    return new List<RetailerViewModel>() { retailers[1], retailers[0], retailers[2] };
                case 3:
                    return new List<RetailerViewModel>() { retailers[1], retailers[2], retailers[0] };
                case 4:
                    return new List<RetailerViewModel>() { retailers[2], retailers[0], retailers[1] };
                case 5:
                    return new List<RetailerViewModel>() { retailers[2], retailers[1], retailers[0] };
                default:
                    return retailers;
            }
        }
    }
}
