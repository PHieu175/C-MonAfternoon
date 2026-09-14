using System.Globalization;
using System.Text;

internal class Excercise_7thSep
{
    public static void Main(string[] args)
    {
        //ktraSoHoanHao();
        //ktra_soNguyenTo();
        //lapBangNhan();
        //ktraLoaiTamGiac();
        //doc10SoVaTinhTrungBinh();
        //trianglePatternWithNum();
        displayTheNTerms();
    }

    static void lapBangNhan()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số cần lập bảng nhân: ");
        int number = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
    static void ktraSoHoanHao()
    {
        Console.Write("Nhap so can kiem tra: ");
        int so = int.Parse(Console.ReadLine()!);

        int tong = 0;
        for (int i = 1; i <= so / 2; i++)
        {
            if (so % i == 0)
                tong += i;
        }

        if (tong == so)
        {
            Console.WriteLine($"So {so} la so hoan hao");
        }
        else
        {
            Console.WriteLine($"So {so} KHONG la so hoan hao");
        }
    }
    static void ktra_soNguyenTo()
    {
        Console.Write("Nhap so can kiem tra: ");
        int so = int.Parse(Console.ReadLine()!);


        for (int i = 2; i <= so / 2; i++)
        {
            if (so % i == 0)
            {
                Console.Write($"So {so} ko phai la so Nguyen To");
                break;
            }
        }

    }
    static void ktraLoaiTamGiac()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập độ dài cạnh 1: ");
        double canh1 = double.Parse(Console.ReadLine()!);
        Console.Write("Nhập độ dài cạnh 2: ");
        double canh2 = double.Parse(Console.ReadLine()!);
        Console.Write("Nhập độ dài cạnh 3: ");
        double canh3 = double.Parse(Console.ReadLine()!);

        if (canh1 + canh2 > canh3 && canh1 + canh3 > canh2 && canh2 + canh3 > canh1)
        {
            if (canh1 == canh2 && canh2 == canh3)
            {
                Console.WriteLine("\nTam giác là tam giác Cân");
            }
            else if (canh1 == canh2 || canh1 == canh3 || canh2 == canh3)
            {
                Console.WriteLine("\nTam giác là tam giác Đều");
            }
            else
            {
                Console.WriteLine("\nTam giác là tam giác Thường");
            }
        }
        else
        {
            Console.WriteLine("\nSố đo các cạnh không hợp lệ");
        }
    }
    static void doc10SoVaTinhTrungBinh()
    {
        Console.OutputEncoding = Encoding.UTF8;

        double sum = 0;
        int soLanlap = 10;

        Console.WriteLine("Hãy nhập 10 số:\n");

        for (int i = 1; i <= soLanlap; i++)
        {
            Console.Write($"Số thứ {i}: ");
            double number = double.Parse(Console.ReadLine()!);
            sum += number;
        }
        double trungBinh = sum / soLanlap;

        Console.WriteLine($"Trung bình của 10 chữ số là {trungBinh:F2}");
    }
    static void trianglePatternWithNum()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số hàng: ");
        int row = int.Parse(Console.ReadLine()!);

        int a = 1;

        for (int i = 1; i <= row; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(a + " ");
                a++;
            }
            Console.WriteLine();
        }
    }
    static void displayTheNTerms()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số số hạng: ");
        int n = int.Parse(Console.ReadLine()!);

        double sum = 0.0;

        for (int i = 1; i <= n; i++)
        {
            if (i < n)
            {
                Console.Write($"1/{i} + ");
            }
            else
            {
                Console.Write($"1/{i}");
            }

            sum += 1.0 / i;
        }
        Console.WriteLine($"\n\nTổng của dãy số tính tới {n} số hạng là: {sum:F6}");

    }
}

