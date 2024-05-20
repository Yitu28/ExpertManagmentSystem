using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Enums
{
    // Gender Category with Enumerable List
    public enum Genders
    {
        ሴት,
        ወንድ
    }

    // 
    public enum PreqTypeofDecision
    {
        [Display(Name = "ክስ ይመስረት")]
        ክስ_ይመስረት,
        [Display(Name = "የማየት ስልጣን ላለው አካል ይተላለፍ")]
        የማየት_ስልጣን_ላለው_አካል_ይተላለፍ,
        [Display(Name = "ከክስ በፊት በድርድር ፣ በስምምነት የተቋጨ")]
        ከክስ_በፊት_በድርድር_በስምምነት_የተቋጨ,
        [Display(Name = "የክስ / ይግባኝ አይቀርብም ውሳኔ የተሰጠው")]
        የክስ_ይግባኝ_አይቀርብም_ውሳኔ_የተሰጠው,
        [Display(Name = "ተጨማሪ ማስረጃ የተጠየቀበት ")]
        ተጨማሪ_ማስረጃ_የተጠየቀበት,
        [Display(Name = "በዐቃቤ ህግ እጅ ሳይሰራ በምርመራ ላይ ያለ ")]
        በዐቃቤ_ህግ_እጅ_ሳይሰራ_በምርመራ_ላይ_ያለ
    }
    // Types Of Decision with Enumerable
    //
    public enum TypeofDecision
    {
        [Display(Name = "አሸናፊ")]
        አሸናፊ,
        [Display(Name = "ተሸናፊ")]
        ተሸናፊ,
        [Display(Name = "ወደ እስር ቤት")]
        ወደ_እስር_ቤት,
        [Display(Name = "ስልጣን ላለው")]
        ስልጣን_ላለው
    }
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

    public enum DecisionStatus
    {
        [Display(Name = "አሸናፊ")]
        አሸናፊ,
        [Display(Name = "ተሸናፊ")]
        ተሸናፊ,
        [Display(Name = "ወደ ስር ቤት")]
        ወደ_ስር_ቤት,
        [Display(Name = "ስልጣን ላለው አካል")]
        ስልጣን_ላለው_አካል
    }
}
