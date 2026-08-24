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
        Console.Write("Nhap gia tri y bat dau: "); int ystart = int.Parse(Console.ReadLine()!);
        Console.Write("Nhap gia tri y ket thuc: "); int yend = int.Parse(Console.ReadLine()!);

        Console.WriteLine("{0,5} | {1,5}", "y", "x");
        //
        Console.WriteLine("-----------------------");

        for(int y = ystart; y <= yend; ++y)
        //chay tu -5 toi 5, va moi lan chay se +1
        {
            int x = (y*y) + (2*y) + 1;
            Console.WriteLine("{0,5} | {1,5}", y, x);
        }
    }
    public static void Main(string[]args)
    {
       
        bai_2();
    }
}