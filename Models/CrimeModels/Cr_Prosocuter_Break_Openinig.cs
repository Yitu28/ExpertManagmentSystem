namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_Prosocuter_Break_Openinig
    {
        public int Cr_Prosocuter_Break_OpeninigId { get; set; }
        public DateTime Openinig_Date { get; set; }
        public int Prosocuter_No { get; set; }
        public int Court_No { get; set; }
        public string Applicant { get; set; }
        public string Respondant { get; set; }
        public string Crime_Type { get; set; }
        public DateTime Date_of_Appointment { get; set; }
        public string Zone { get; set; }
        public string Worked_Proffesional { get; set; }
        public DateTime Date_of_Administration { get; set; }
        public TimeOnly Time { get; set; }
        public DateTime Date_of_returen { get; set; }
        public TimeOnly Returen_Time { get; set; }
        public string Prosocuter_Comment { get; set; }

    }
}
