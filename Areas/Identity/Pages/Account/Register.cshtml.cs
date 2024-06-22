using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models;
using ExpertManagmentSystem.OrganizationalStructures;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;

namespace ExpertManagmentSystem.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        //private readonly IUserStore<ApplicationUser> _userStore;

        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _context;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IUserStore<ApplicationUser> userStore,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _context = context;
        }

        public string? Full_Name { get; set; }
        public Guid UserParentId { get; set; }
        public Guid UserDepartmentId { get; set; }
        public DepartmentCategory DepartmentCategory { get; set; }
        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }
        
    public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
            [Required]
            [StringLength(255,ErrorMessage ="Full Name Not be Null")]
            public string? Full_Name { get; set; }
            public int RegianalOrganizationOfficeDepartmentId { get; set; }
            //public virtual RegianalOrganizationOfficeDepartment? Region { get; set; }
            public int ZoneOrganizationOfficeDepartmentsId { get; set; }
            public int WordaOrganizationOfficeDepartmentsId { get; set; }
            public Guid UserParentId { get; set; }
            public Guid UserDepartmentId { get; set; }
            public DepartmentCategory UserCategory { get; set; }

            //[BindProperty]
            //public SelectList Dropdown { get; set; }
        }

        //public async Task OnGetAsync(Guid guid, string returnUrl = null)
        //{
        //    var ParentUserId = await _context.SectrorsDepartment.FindAsync(guid);
        //    UserDepartmentId = ParentUserId.SectrorsDepartmentId;
        //    UserParentId = ParentUserId.DepartmentParentId;
        //    UserCategory = ParentUserId.DepartmentCategory;
        //    ReturnUrl = returnUrl;
        //    ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

        //}
        public async Task OnGetAsync(Guid? id, string returnUrl = null)
        {
            var ParentUserData = await _context.SectrorsDepartment.FindAsync(id);
            UserDepartmentId = ParentUserData.SectrorsDepartmentId;
            UserParentId = ParentUserData.DepartmentParentId;
            DepartmentCategory = ParentUserData.DepartmentCategory;

            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(Guid UserParentId, Guid UserDepartmentId, string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (!ModelState.IsValid)
            {
                var ParentUserData = await _context.SectrorsDepartment.FindAsync(UserDepartmentId);

                var user = new ApplicationUser
                {
                    UserName = Input.Email,
                    Email = Input.Email
                };
                user.UserParentId = UserParentId;
                user.UserDepartmentId = UserDepartmentId;
                user.DepartmentCategory = ParentUserData.DepartmentCategory;
                user.Full_Name = Input.Full_Name;

                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
