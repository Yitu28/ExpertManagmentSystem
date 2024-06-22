using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.Models.CivilCaseModels;
using ExpertManagmentSystem.OrganizationalStructures;

namespace ExpertManagmentSystem.ViewModels.CivilCaseViewModels
{
    public class CCReportViewModels
    {
        public SectrorsDepartment? SectrorsDepartment { get; set; }
        public CCFreelServices ? FreeService { get; set; }
        public CCFreeLegServiceFollowup? Followup { get; set; }
        public CCLegaladvices? CCLegaladvices { get; set; }
        public CCPetition? CCPetition { get; set; }
        public CCPDecissionTypes? CCPDecissionTypes { get; set; }
        public FreelCategory? FreelCategory { get; set; }
        public CustomerCategory? CustomerCategory { get; set; }
        public SupportType? SupportType { get; set; }
        public AppointmentType? AppointmentType { get; set; }
        public TypeofDecision? DecisionStatus { get; set; }
        public Petitionrespons? PetitionPrespons { get; set; }
        public Petitionrespons? Petitionrespons { get; set; }
    }
}
