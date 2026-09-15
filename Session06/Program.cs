using System.Security.Cryptography.X509Certificates;
using System.Text;

internal class Excercise_14thSep
{
    public static void Main(string[] args)
    {

    }
    static int bai_1()
    {
       Console.OutputEncoding = Encoding.UTF8;        

       Console.WriteLine("Tìm giá trị lớn nhất của đúng 3 số:");
       Console.Write("Nhập số thứ 1: "); int num1 = int.Parse(Console.ReadLine()!);
       Console.Write("Nhập số thứ 2: "); int num2 = int.Parse(Console.ReadLine()!);
       Console.Write("Nhập số thứ 3: "); int num3 = int.Parse(Console.ReadLine()!);

        int max = num1; 
        if (num2 > max) max = num2;
        if (num3 > max) max = num3;
        return max;
    }
    
}