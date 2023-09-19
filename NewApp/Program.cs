public class Program
{
    private static void Main(string[] args)
    {
      int a,b;
      System.Console.Write(" a = ");
      a = Convert.ToInt32(Console.ReadLine());
      System.Console.Write(" b = ");
      b = Convert.ToInt32(Console.ReadLine());
      int hieu = a-b;
      System.Console.WriteLine("hieu 2 so = " +hieu);
      int tich = a*b;
      System.Console.WriteLine("tich 2 so = " +tich);
      int nguyen = a/b;
      System.Console.WriteLine("chialaynguyen = " +nguyen);
      int du =a%b;
      System.Console.WriteLine("chialaydu = " +du);

    }
}


