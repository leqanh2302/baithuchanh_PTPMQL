namespace NewApp.Models
{
    public class Fruit
    {
        public string TenQua {get; set;}
        public float Gia {get; set;}
        publicvoid EnterData()
        {
            System.Console.WriteLine("TenQua = ");
            TenQua = Console.ReadLine();
            System.Console.WriteLine("Gia");
            Gia = Convert.ToFloat(Console.ReadLine());
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} gia", TenQua, Gia);
        }
    }
}
//Le Quynh Anh_2021050074