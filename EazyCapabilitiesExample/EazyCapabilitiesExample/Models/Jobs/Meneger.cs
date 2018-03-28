using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyCapabilitiesExample.Models.Jobs
{
    class Meneger : PersonsStage
    {
        public override int Salary => base.Salary*500 + 15000;
        public override string StageName => "Менеджер";

        public override string ImagePath => "Images/meneger.jpg";
    }
}
