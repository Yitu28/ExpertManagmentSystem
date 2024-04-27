namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_Direct_Chare_Decission
    {
        public int Cr_Direct_Chare_Decissionid { get; set; }
        public DateOnly Opening_Date { get; set; }
        public int Police_Record_No { get; set; }
        public int Prosecuter_Record_No { get; set; }
        public int Court_Record_No { get; set; }
        public string Defendant_Name { get; set; }
        public string Defendant_Sex { get; set; }
        public string Defendant_Age { get; set; }
        public string Type_of_Crime { get; set; }
        public string Zone { get; set; }
        public string Worda { get; set; }
        public string Kebele { get; set; }
        public string Administration_Exper { get; set; }
        public string Yemisikir_Amount { get; set; }
        public string Egzibit { get; set; }
        public string Prosecuter_Desition { get; set; }


    }
}
