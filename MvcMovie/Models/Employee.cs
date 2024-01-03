using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models
{
    public class Employee 
    {
        public string FullName { get; set; }
        public string EmployeeID  { get; set; }
        public string SoDienThoai  { get; set; }
        public string Address { get; set; }

    }
}