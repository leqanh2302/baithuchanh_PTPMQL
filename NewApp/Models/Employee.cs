namespace NewApp.Models
{
    public class Employee
    {
        public int MaNhanVien {get; set;}
        public string TenNhanVien {get; set;}
        public int Tuoi {get; set;}
        public float Luong {get; set;}
        publicvoid EnterData()
        {
            System.Console.WriteLine("MaNhanVien = ");
            MaNhanVien = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("TenNhanVien = ");
            TenNhanVien = Console.ReadLine();
            System.Console.WriteLine("Tuoi");
            Tuoi = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("Luong");
            Convert.ToFloat(Console.ReadLine());
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", MaNhanVien, TenNhanVien, Tuoi, Luong);
        }
    }
}
/// Le Quynh Anh_2021050074