using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace EazyCapabilitiesExample.Models.Jobs
{
    abstract class PersonsStage
    { 
        protected Employee employee { get; private set; }
        public virtual int Salary { get { return (employee == null ? 0 : employee.WorkAge); } }
        public abstract string StageName { get; }
        public abstract string ImagePath { get; }

        protected PersonsStage() { }

       

        protected static PersonsStage GetStageByString(string str)
        {
            Type baseType = typeof(PersonsStage);
            Assembly asm = Assembly.GetAssembly(baseType);
            foreach(var t in asm.GetTypes().Where(type => type.BaseType == baseType))
            {
                PersonsStage obj = (PersonsStage)Activator.CreateInstance(t);
                if (obj.StageName == str) return obj;
            }
            return null;
        }


        public static PersonsStage GetStage(string stage, Employee emp)
        {
            PersonsStage ps = GetStageByString(stage);
            ps.employee = emp;
            return ps;
        }

        public static PersonsStage[] GetStages()
        {
            Type baseType = typeof(PersonsStage);
            Assembly asm = Assembly.GetAssembly(baseType);
            var list = asm.GetTypes().Where(type => type.BaseType == baseType).Select(type=>(PersonsStage)Activator.CreateInstance(type));
            return list.ToArray();
        }
    }
}
