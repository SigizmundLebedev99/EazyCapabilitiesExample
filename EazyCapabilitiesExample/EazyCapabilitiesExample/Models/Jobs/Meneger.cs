namespace EazyCapabilitiesExample.Models.Jobs
{
    class Meneger : PersonsStage
    {
        public override int Salary => base.Salary*500 + 15000;
        public override string StageName => "Менеджер";

        public override string ImagePath => "Images/meneger.jpg";
    }
}
