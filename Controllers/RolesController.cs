﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ExpertManagmentSystem.Controllers
{
    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _manager;
        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            _manager = roleManager;
        }

        public IActionResult Index()
        {
            var roles = _manager.Roles;
            return View(roles);
        }
        [HttpGet]
        public IActionResult Create()
        {
            //IdentityRole role = new();
            //return PartialView("_RolesModelPartial", role);
            return View();
        }
        [HttpPost]
        public IActionResult Create(IdentityRole role)
        {
            if (!_manager.RoleExistsAsync(role.Name).GetAwaiter().GetResult())
            {
                _manager.CreateAsync(new IdentityRole(role.Name)).GetAwaiter().GetResult();
            }
            return RedirectToAction("Index");
        }


    }
}
