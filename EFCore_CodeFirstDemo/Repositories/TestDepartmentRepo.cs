using EFCore_CodeFirstDemo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace EFCore_CodeFirstDemo.Repositories
{
    public class TestDepartmentRepo : IDepartmentRepo
    {
        DepartmentContext context;
        public TestDepartmentRepo(DepartmentContext departmentContext) {
            context = departmentContext;
        }
        public void AddNewDepartment(Department department)
        {
            context.Departments.Add(department);
            context.SaveChanges();
        }
        public void DeleteDepartment(int id)
        {
            Department department = context.Departments.Find(id);
            if(department != null)
            {
                context.Departments.Remove(department);
                context.SaveChanges();
            }
        }
        public List<Department> GetAllDepartments()
        {
            return context.Departments.ToList();
        }
        public void UpdateDepartment(Department newdepartment)
        {
            Department department = context.Departments.FirstOrDefault(d =>
            d.DepartmentId ==newdepartment.DepartmentId);
            if (department != null)
            {
                department.DepartmentId = newdepartment.DepartmentId;
                department.DepartmentName = newdepartment.DepartmentName;
                department.Location = newdepartment.Location;
                context.SaveChanges();
            }
        }
        public Department GetDepartmentById(int id)
        {
            Department dept = context.Departments.Find(id);
           
                return dept;
            
        }
    }
}
