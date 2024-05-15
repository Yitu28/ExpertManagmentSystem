using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Enums
{
    // Gender Category with Enumerable List
    public enum Genders
    {
        ሴት,
        ወንድ
    }
    // Types Of Decision with Enumerable List
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
