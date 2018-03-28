namespace EazyCapabilitiesExample.Models.Jobs
{
    class Cleaner : PersonsStage
    {
        public override int Salary => base.Salary * 100 + 9000;

        public override string StageName => "Уборщик";

        public override string ImagePath =>"Images/cleaner.jpg";
    }
}
