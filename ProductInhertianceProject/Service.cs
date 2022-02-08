using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInhertianceProject {
    public class Service : Product {

        //property
        public string ServiceLevel { get; set; } = "Basic";
        public int NumberOfYears { get; set; } = 1;

        public override string ToPrint() {
            return $"{base.ToPrint()} | {ServiceLevel} | {NumberOfYears} ";
        }

        //Constructors
        public Service(string code, decimal price, string servicelevel, int numberOfYears)
            : base (code, price) {
            ServiceLevel = servicelevel;
            NumberOfYears = numberOfYears;

        }

    }
}
