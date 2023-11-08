using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models
{
    public class Employee : Person
    {
        public string Fullname{get;set;}
        public int MaNV{get;set;}
        public int TuoiNV{get;set;}
        public int Luong{get;set;}
        public string EmployeeID{get;set;}
        public int Age{get;set;}

    }
}
//Le Quynh Anh_2021050074