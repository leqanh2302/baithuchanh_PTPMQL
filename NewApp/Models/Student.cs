namespace NewApp.Models
{
    public class Student
    {
        public int MaSinhVien {get; set;}
        public string TenSinhVien {get; set;}
        public int Tuoi {get; set;}
        public string DiaChi {get; set;}
        publicvoid EnterData()
        {
            System.Console.WriteLine("MaSinhVien = ");
            MaNhanVien = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("TenSinhVien = ");
            TenNhanVien = Console.ReadLine();
            System.Console.WriteLine("Tuoi");
            Tuoi = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("DiaChi");
            DiaChi = Console.ReadLine();
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", MaSinhVien, TenSinhVien, Tuoi, DiaChi);
        }
    }
}
/// Le Quynh Anh_2021050074