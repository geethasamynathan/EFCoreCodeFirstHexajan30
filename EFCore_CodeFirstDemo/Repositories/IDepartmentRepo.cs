using EFCore_CodeFirstDemo.Models;
using System.Collections.Generic;

namespace EFCore_CodeFirstDemo.Repositories
{
    public interface IDepartmentRepo
    {
        List<Department> GetAllDepartments();
        void AddNewDepartment(Department department);
        void UpdateDepartment(Department department);
        Department GetDepartmentById(int id);
        void DeleteDepartment(int id);

    }
}
