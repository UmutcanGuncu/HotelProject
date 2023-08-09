using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using HotelProjectUILayer.Dtos.RoleDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelProjectUILayer.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager  )
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(CreateRoleDto model)
        {
            AppRole appRole = new AppRole()
            {
                Name= model.Name
            };
            var result = await _roleManager.CreateAsync(appRole);
            if (result.Succeeded)
            {
                return Redirect("/Admin/Role/Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteRole(Guid id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            await _roleManager.DeleteAsync(value);
            return Redirect("/Admin/Role/Index");
        }
        [HttpGet]
        public IActionResult UpdateRole(Guid id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            UpdateRoleDto updateRoleDto = new UpdateRoleDto()
            {
                Id = value.Id,
                Name = value.Name
            };
            return View(updateRoleDto);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleDto model)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == model.Id);
            value.Name = model.Name;
            await _roleManager.UpdateAsync(value);
            return Redirect("/Admin/Role/Index");
        }
    }
}

