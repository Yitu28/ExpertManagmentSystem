namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_Direct_Charge_Opening
    {
        public int Cr_Direct_Charge_OpeningId { get; set; }
        public DateTime Opening_Date { get; set; }
        public int Police_Record_No { get; set; }
        public int Prosocuter_Record_No { get; set; }
        public int Court_record_No { get; set; }
        public string Defendant_Name { get; set; }
        public string Defendant_Sex { get; set; }
        public string Type_of_Crime { get; set; }
        public string zone { get; set; }
        public string Worda { get; set; }
        public string Kebele { get; set; }
        public string Addmision_Expert { get; set; }
        public string Expert_Signature { get; set; }
        public DateTime Date_Of_Administration { get; set; }
        public TimeOnly Time_Of_Administration { get; set; }
        public DateTime Date_Of_Returen_and_Mode { get; set; }
        public TimeOnly Time_Of_Returen_and_Mode { get; set; }
        public string Comments { get; set; }




    }
}
