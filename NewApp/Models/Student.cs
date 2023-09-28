using NewApp.Models;
public class Fruit
{
    private static void Main(string[] args)
    {
        //khoitaodoituong
        Student std1 = new Student();
        Student std2 = new Student();
        //gangiatrithuoctinh
        std1.FullName = "LQA";
        std2.Address = "Ha Noi";
        //goi pt hien thi thong tin
        std1.Display();
        std2.Display();
    }
}
     
// Le Quynh Anh_2021050074