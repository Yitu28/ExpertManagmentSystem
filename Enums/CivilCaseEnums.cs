using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Enums
{
    // Gender Category with Enumerable List
    public enum Genders
    {
        ሴት,
        ወንድ
    }
    
    // Customer Category
    public enum CustomerCategory
    {
        [Display(Name = "የመንግስት")]
        የመንግስት,
        [Display(Name = "ነፃ የህግ ድጋፍ")]
        ነፃ
    }

    // Case Types  የጉዳይ አይነት
    public enum CaseTypes
    {
        [Display(Name = "ግዥ")]
        ግዥ,
        [Display(Name = "ኮንስትራክሽን")]
        ኮንስትራክሽን,
        [Display(Name = "የኦዲት ጉድለት")]
        የኦዲት_ጉድለት,
        [Display(Name = "የገጠር መሬት")]
        የገጠር_መሬት,
        [Display(Name = "ሁከት")]
        ሁከት,
        [Display(Name = "የከተማ ቦታ ክርክር")]
        የከተማ_ቦታ_ክርክር,
        [Display(Name = "መሬት ማስለቀቅና የካሳ አከፋፈል")]
        መሬት_ማስለቀቅና_የካሳ_አከፋፈል,
        [Display(Name = "የጉዳት ካሳ")]
        የጉዳት_ካሳ,

        [Display(Name = "የስራ ክርክር")]
        የስራ_ክርክር,
        [Display(Name = "ገንዘብ")]
        ገንዘብ,
        [Display(Name = "ሌሎች")]
        ሌሎች
    }

    // Presecuritor Decision Types 
    public enum CCPDecissionTypes
    {
        [Display(Name = "ክስ የተመሰረተበት")]
        ክስ_የተመሰረተበት,
        [Display(Name = "የማየት ስልጣን ላለው አካል የተላለፈ")]
        የየማየት_ስልጣን_ላለው_አካል_የተላለፈ,
        [Display(Name = "በድርድር / በስምምነት የተቋጨ / ከክስ በፊት")]
        ከክስ_በፊት_በድርድር_በስምምነት_የተቋጨ,
        [Display(Name = "የክስ / ይግባኝ አይቀርብም ውሳኔ የተሰጠው")]
        የክስ_ይግባኝ_አይቀርብም_ውሳኔ_የተሰጠው,
        [Display(Name = "ተጨማሪ ማስረጃ የተጠየቀበት")]
        ተጨማሪ_ማስረጃ_የተጠየቀበት,
        [Display(Name = "በዐቃቤ ህግ እጅ ሳይሰራ በምርመራ ላይ ያለ ")]
        በዐቃቤ_ህግ_እጅ_ሳይሰራ_በምርመራ_ላይ_ያለ
    }
    // Types Of Court Decision with Enumerable
    public enum TypeofDecision
    {
        [Display(Name = "አሸናፊ")]
        አሸናፊ,
        [Display(Name = "ተሸናፊ")]
        ተሸናፊ,
        [Display(Name = "ወደ እስር ቤት")]
        ወደ_እስር_ቤት,
        [Display(Name = "ስልጣን ላለው ፍርድ ቤት እንዲያየው")]
        ስልጣንላለው_ፍርድ_ቤት_እንዲያየው,

        [Display(Name = "በፍሬ ጉዳይ ላይ በሥር ፍርድ ቤት እንዲያየው የተወሰ")]
        በፍሬ_ጉዳይ_ላይ_በሥር_ፍርድ_ቤት_እንዲያየው_የተወሰ,
        [Display(Name = "በድርድር የተቋጨ ከክስ በኋላ")]
        በድርድር_የተቋጨ_ከክስ_በኋላ,
        [Display(Name = "በዐቃቤ ሕግ ጠያቂነት ክሱ የተነሳ")]
        በዐቃቤ_ሕግ_ጠያቂነት_ክሱ_የተነሳ,
        [Display(Name = "በፍርድ ቤት ቀጠሮ የዞረ")]
        በፍርድ_ቤት_በቀጠሮ_የዞረ,
        [Display(Name = "ሌሎች የፍርድ ቤት ውሳኔዎች")]
        ሌሎች_የፍርድ_ቤት_ውሳኔዎች
    }
     //
    public enum SupportType
    {
        [Display(Name = "ህፃን")]
        ህፃን,
        [Display(Name = "አካል ጉዳተኛ")]
        አካል_ጉዳተኛ,
        [Display(Name = "ደሀ")]
        ደሀ,
        [Display(Name = "አረጋዉያን")]
        አረጋውያን,
        [Display(Name = "በሽተኛ")]
        በሽተኛ
    }
    
    public enum AgeRange
    {
        [Display(Name = "ከ 18 ዓመት በታች ")]
        Under_18,
        [Display(Name = "ከ 18 እስከ 29 ")]
        Between_18_and_29,
        [Display(Name = "ከ 29 ዓመት በላይ ")]
        Above_29
    }
    // ነፃ የህግ ድጋፍ አይነቶች ምድብ 
    public enum FreelCategory
    {
        ይግባኝአመልካች, ይግባኝመልስ, ሰበርአመልካች, ሰበርተጠሪ, ቀጥታክስአመልካች, ቀጥታክስመልስ
    }

    
}
