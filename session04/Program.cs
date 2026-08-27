internal class Ex01
{
    /// <summary>
    /// Write a C# Sharp program that takes two numbers as input and 
    /// performs an operation (+,-,*,x,/) on them and displays the result of that operation.
    /// </summary>
    static void bai_1()
    {
        Console.Write("Nhap so a ="); int a = int.Parse(Console.ReadLine()!);
        Console.Write("Nhap so b ="); int b = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"{a} + {b} = {a+b}");
        Console.WriteLine($"{a} - {b} = {a-b}");
        Console.WriteLine($"{a} * {b} = {a*b}");
        Console.WriteLine($"{a} / {b} = {a/b}");
        Console.WriteLine($"{a} % {b} = {a%b}");
    }
    /// <summary>
    /// Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 
    /// (using integer numbers for y, ranging from -5 to +5).
    /// </summary>
    static void bai_2()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("NNhập giá trị y bắt đầu: "); int ystart = int.Parse(Console.ReadLine()!);
        Console.Write("Nhập giá trị y kết thúc: "); int yend = int.Parse(Console.ReadLine()!);

        Console.WriteLine("{0,5} | {1,5}", "y", "x");
        //
        Console.WriteLine("-----------------------");

        for(int y = ystart; y <= yend; ++y)
        //chạy từ -5 đến 5, và mỗi khi chạy +1
        {
            int x = (y*y) + (2*y) + 1;
            Console.WriteLine("{0,5} | {1,5}", y, x);
        }
    }
    public static void Main(string[]args)
    {
        bai_1();
        bai_2();
    }
}