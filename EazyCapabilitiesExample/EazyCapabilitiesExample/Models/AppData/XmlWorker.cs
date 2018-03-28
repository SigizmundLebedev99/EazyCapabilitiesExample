using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EazyCapabilitiesExample.Models;
using EazyCapabilitiesExample.Models.Jobs;
using System.Configuration;

namespace EazyCapabilitiesExample.Models.AppData
{
    static class XmlWorker
    {
        public static IEnumerable<Employee> GetEmployeesFromXml()
        {
            XDocument xdoc = XDocument.Load(ConfigurationManager.AppSettings["wayToFirstFile"]);
            foreach(XElement e in xdoc.Root.Elements())
            {
                Employee emp = new Employee(e.Element("Position").Value);
                emp.Firstname = e.Element("Firstname").Value;
                emp.Lastname = e.Element("Lastname").Value;
                emp.Patronymic = e.Element("Patronymic").Value;
                emp.Birthday = DateTime.Parse(e.Element("Birthday").Value);
                emp.Phone = e.Element("Phone").Value;
                emp.ImagePath = e.Element("ImagePath").Value;
                emp.WorkAge = int.Parse(e.Element("WorkAge").Value);
                yield return emp;
            }
        }

        public static void SaveEmployesInfo(IEnumerable<Employee> employes)
        {
            XDocument xdoc = new XDocument(new XElement("Company"));
            foreach(var e in employes)
            {
                xdoc.Root.Add(new XElement
                    ("Employee",
                    new XElement("Firstname", e.Firstname),
                    new XElement("Lastname", e.Lastname),
                    new XElement("Patronymic", e.Patronymic),
                    new XElement("Birthday", e.Birthday),
                    new XElement("Phone", e.Phone),
                    new XElement("ImagePath", e.ImagePath),
                    new XElement("WorkAge", e.WorkAge),
                    new XElement("Position", e.Position.StageName)
                    )
                    );
                xdoc.Save(ConfigurationManager.AppSettings["wayToFirstFile"]);
            }
        }
    }
}
//<Employee>
//    <Firstname>Вова</Firstname>
//    <Lastname>Сидоров</Lastname>
//    <Patronymic>Алексеевич</Patronymic>
//    <Phone>89711082011</Phone>
//    <Age>23</Age>
//    <ImagePath></ImagePath>
//    <WorkAge>1</WorkAge>
//    <Position>Клерк</Position>
//  </Employee>