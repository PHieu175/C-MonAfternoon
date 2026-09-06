using System.Runtime.CompilerServices;

internal class Excercise_24thAug
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
    ///<summary>
    ///Write a C# Sharp program to check whether a given number is even or odd.
    /// </summary>
    static void bai_3()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        int number = 0;
        bool isValid = false;

        do
        {
            Console.Write("Nhap so nguyen bat ky: ");
            String input = Console.ReadLine()!;

            if(int.TryParse(input, out number))
            {
                isValid = true; 
            }
            else
            {
                Console.WriteLine("Loi: Gia tri ko phai so nguyen, can nhap lai");

            }

        } while(!isValid);

        if(number % 2 == 0)
        {
            Console.WriteLine("{number} la So Chan");
        }
        else
        {
            Console.WriteLine("{number} la So Le");
        }
    }
    /// <summary>
    /// Write a C# Sharp program to find the largest of three numbers.
    /// </summary>
    static void bai_4()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        //vì viết 3 vòng lặp do-while riêng biệt cho 3 biến a, b, c rất dài dòng nên cần một một hàm hỗ trợ dùng chung
        static int soNguyen(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()!;

                if (int.TryParse(input, out value))
                {
                    return value; 
                }

                Console.WriteLine("Loi: gia tri phai la so nguyen, can nhap lai");
            }
        }
        int a = soNguyen("Nhap so a bat ky: ");
        int b = soNguyen("Nhap so b bat ky: ");
        int c = soNguyen("Nhap so c bat ky: ");

        int max = a;
        if(b>max)
        {
            max = b;
        }

        if (c > max)
        {
            max = c;
        }

        Console.WriteLine($"So lon nhat trong ba so la: {max}");        
    }
    public static void Main(string[]args)
    {
       
        
        bai_4();
    }
    
}