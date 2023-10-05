namespace NewApp.Models
{
public class Fruit{
    public string Name{get; set;}
    public int Price{get; set;}
    public void NhapThongTin(){
        System.Console.Write("Name =");
        Name = Console.ReadLine();
        System.Console.Write("Price =");
        try{
            Price = Convert.ToInt16(Console.ReadLine());
        }catch(Exception e)
        {
            Price = 0;
        }
      
    }  
    public void HienThi(){
        System.Console.WriteLine("{0} - {1} ", Name, Price);
    }
}
    
}
     
// Le Quynh Anh_2021050074