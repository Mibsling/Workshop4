using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Package
    {
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public string PkgStartDate { get; set; }
        public string PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public string PkgBasePrice { get; set; }
        public string PkgAgencyCommision { get; set; }

    }
}
