namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_Decided_Prosecuter_Appeal
    {
        public int Cr_Decided_Prosecuter_AppealId { get; set; }
        public DateTime Opening_Date { get; set; }
        public int Prosocuter_No { get; set; }
        public int Court_No { get; set; }
        public string Applicant { get; set; }
        public string Respondant { get; set; }
        public string Crime_Type { get; set; }
        public string Court_Desitions { get; set; }
        public string Prosocuter_Focus { get; set; }
        public string Other { get; set; }
        public string Experts_to_Prosecuter { get; set; }
        public string Experts_to_Court { get; set; }
        public int Amount_Of_appeal_Male { get; set; }
        public int Amount_Of_appeal_Female { get; set; }
        public string Event_Status { get; set; }
        public string To_Federal { get; set; }

    }
}
