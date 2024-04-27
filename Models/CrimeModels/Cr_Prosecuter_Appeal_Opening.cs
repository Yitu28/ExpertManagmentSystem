namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_Prosecuter_Appeal_Opening
    {
        public int Cr_Prosecuter_Appeal_OpeningId { get; set; }
        public DateOnly Opening_Date { get; set; }
        public int Prosecuter_No { get; set; }
        public int Court_No { get; set; }
        public string Applicant { get; set; }
        public string Respondant { get; set; }
        public string Crime_Type { get; set; }
        public DateOnly Date_of_Appientment { get; set; }
        public string Zone { get; set; }
        public string Worked_Proffissional { get; set; }
        public DateOnly Date_of_Administration { get; set; }
        public TimeOnly Time { get; set; }
        public DateOnly Date_of_Returen { get; set; }
        public TimeOnly Returen_Time { get; set; }
        public string Prosecuter_Comments { get; set; }

    }
}
