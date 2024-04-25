
using ExpertManagmentSystem.Models;
using ExpertManagmentSystem.OrganizationalStructures;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Data
{
    public class ApplicationUser:IdentityUser
    {
        public string? Full_Name { get; set; }
        public Guid UserParentId { get; set; }
        public Guid UserDepartmentId { get; set; }
        public DepartmentCategory DepartmentCategory { get; set; }




    }
}
