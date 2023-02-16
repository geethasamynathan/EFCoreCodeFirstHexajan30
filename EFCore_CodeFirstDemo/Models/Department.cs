using System.ComponentModel.DataAnnotations;

namespace EFCore_CodeFirstDemo.Models
{
    public class Department
    {
        //public int Id { get; set; }
         public int DepartmentId { get; set; }
       // [Key]
       //public int DeptId { get; set; }
        public string DepartmentName { get; set; }
        public string Location { get; set; }

    }
}
