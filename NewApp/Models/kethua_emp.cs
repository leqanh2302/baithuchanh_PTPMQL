namespace NewApp.Models
{
    public class Employee : Person
    {
        public int MaNhanVien {get; set;}
        public string TenNhanVien {get; set;}
        public int Tuoi {get; set;}
        public void EnterData()
        {
            System.Console.WriteLine("MaNhanVien = ");
            MaNhanVien = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("TenNhanVien = ");
            TenNhanVien = Console.ReadLine();
            System.Console.WriteLine("Tuoi");
            Tuoi = Convert.ToInt16(Console.ReadLine());
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", MaNhanVien, TenNhanVien, Tuoi);
            base.Display();
            System.Console.WriteLine("- Ma Nhan Vien: {0}", MaNhanVien);
        }
    }
}
/// Le Quynh Anh_2021050074