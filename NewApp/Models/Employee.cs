 namespace NewApp.Models
 {
     public class Employeee{
        public string FullName {get; set;}
        public string Address {get; set;}
        public int EmployeeID {get; set;}
        public void NhapThongTin(){
            System.Console.Write("Full name");
            FullName = Console.ReadLine();
            System.Console.Write("Address");
            Address = Console.ReadLine();
            System.Console.Write("Age");
            try{
                EmployeeID = Convert.ToInt16(Console.ReadLine());
            }catch(Exception e)
            {
                EmployeeID = 0;
            }
        }
        public void HienThi()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", FullName, Address, EmployeeID);
        }


     }

 }
 
// Le Quynh Anh_2021050074