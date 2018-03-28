using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyCapabilitiesExample.Models.Jobs
{
    class Clerk : PersonsStage
    {
        public override int Salary => base.Salary * 300 + 10000;

        public override string StageName => "Клерк";

        public override string ImagePath => "Images/clerk.jpg";
    }
}
