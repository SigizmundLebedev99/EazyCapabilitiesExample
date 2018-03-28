using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyCapabilitiesExample.Models.Jobs
{
    class HeadOfDepartment : PersonsStage
    {
        public override int Salary => base.Salary * 1000 + 20000;

        public override string StageName => "Начальник отдела";

        public override string ImagePath => "Images/boss.jpg";
    }
}
