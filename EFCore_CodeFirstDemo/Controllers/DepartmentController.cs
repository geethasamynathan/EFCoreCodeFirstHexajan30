using Microsoft.AspNetCore.Mvc;
using EFCore_CodeFirstDemo.Models;
using EFCore_CodeFirstDemo.Repositories;
namespace EFCore_CodeFirstDemo.Controllers
{
    public class DepartmentController : Controller
    {
        IDepartmentRepo repository;
        public DepartmentController(IDepartmentRepo repo)
        {
            this.repository = repo;
        }
        public IActionResult Index()
        {
            
            return View(repository.GetAllDepartments());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            repository.AddNewDepartment(department);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            Department department= repository.GetDepartmentById(id);
            if(department!=null)
            return View(department);
            else
                return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Department department)
        {
            repository.UpdateDepartment(department);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Department department = repository.GetDepartmentById(id);
            if (department != null)
            {
               
                return View(department);
            }
            else
                return NotFound();
        }
        [HttpPost]
        public IActionResult Delete(Department department)
        {
            repository.DeleteDepartment(department.DepartmentId);
            return RedirectToAction("Index");
        }

    }
}
