namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_Judical_Break_Appeal
    {
        public int Cr_Judical_Break_AppealId { get; set; }
        public DateTime Openig_date { get; set; }
        public int Prosecuter_No { get; set; }
        public int Court_No { get; set; }
        public string Applicant { get; set; }
        public string Respondant { get; set; }
        public string Crime_Type { get; set; }
        public DateTime Date_of_Appientment { get; set; }
        public string Zone { get; set; }
        public string Worked_Professional { get; set; }
        public string Date_of_Administration { get; set; }
        public TimeOnly Time { get; set; }
        public DateOnly Date_of_Returen { get; set; }
        public TimeOnly Returen_Time { get; set; }
        public string Prosecuter_Comments { get; set; }




    }
}
