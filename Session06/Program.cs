using System.Security.Cryptography.X509Certificates;
using System.Text;

internal class Excercise_14thSep
{
    public static void Main(string[] args)
    {
        //bai_1();
        //bai_2();
        //bai_3();
        //bai_4();
        //bai_5();
        //bai_6();
        //bai_7();
        //bai_8();
        //bai_9();
        //bai_10();
        //bai_11();
        //bai_12();
        //bai_13();
        //bai_14();
        //bai_15();
        //bai_16();
        //bai_17();
        //bai_18();
        //bai_19();
        bai_20();
    }
    static void bai_1()
    {
        Console.OutputEncoding = Encoding.UTF8;        

        int number01 = 35;
        int number02 = 15;
        int ketQua = Tongtien(number01,number02);
        Console.WriteLine($"Kết quả của phép tính {number01} + {number02} là: {ketQua}");
    }
    static void bai_2()
    {
        Console.OutputEncoding=Encoding.UTF8;

        int soCanTest = 25;

        if (kiemTraChan(soCanTest))
        {
            Console.WriteLine($"Số {soCanTest} là số Chẵn");
        }
        else
        {
            Console.WriteLine($"Số {soCanTest} là số Lẻ");
        }
    }
    static void bai_3()
    {
        Console.OutputEncoding=Encoding.UTF8;

        int x = 36;
        int y = 67;
        int z = 81;
        int maxNumber = timMax(x, y, z);
        Console.WriteLine($"Số lớn nhất trong 3 số {x}, {y}, {z} là: {maxNumber}.");
    }
    static void bai_4()
    {
        Console.OutputEncoding=Encoding.UTF8;

        int n = 5;
        long result = tinhGiaiThua(n);
        Console.WriteLine($"Giai thừa của {n} ({n}!) = {result}");
    }
    static void bai_5()
    {
        Console.OutputEncoding=Encoding.UTF8;

        string text = "CIVIC";
        string ketQua = daoNguocChuoi(text);
        Console.WriteLine($"Chuỗi ban đầu: {text}.");        
        Console.WriteLine($"Chuỗi đảo ngược: {ketQua}.");        
    }
    static void bai_6()
    {
        Console.OutputEncoding=Encoding.UTF8;

        int testNum1 = 7;
        int testNum2= 10;

        Console.Write($"Input: {testNum1} -> Output: {kiemTraNguyenTo(testNum1)}");
        Console.WriteLine($@" | Input: {testNum2} -> Output: {kiemTraNguyenTo(testNum2)}");
    }
    static void bai_7()
    {
        //Dãy Fibonacci là dãy số tự nhiên bắt đầu bằng 0 và 1 (hoặc 1 và 1), 
        //trong đó mỗi số liền sau luôn bằng tổng của hai số liền trước
        Console.OutputEncoding=Encoding.UTF8;

        int soN = 6;
        Console.Write($"Input: {soN} -> Output: ");
        inFibonacci(soN);
    }
    static void bai_8()
    {
        Console.OutputEncoding=Encoding.UTF8;

        string input = "Hello World";
        int count = demNguyenAm(input);
        Console.WriteLine($"Input: \"{input}\" -> Output: {count}");
    }
    static void bai_9()
    {
        Console.OutputEncoding=Encoding.UTF8;
        
        double x1 = 2; 
        int y1 = 3;
        double x2 = 2; 
        int y2 = -3;
        Console.WriteLine($"Input: x = {x1}, y = {y1} -> Output: {tinhLuyThua(x1,y1)}");
        Console.WriteLine($"Input: x = {x2}, y = {y2} -> Output: {tinhLuyThua(x2,y2)}");
    }
    static void bai_10()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int[]numbers = {4,5,6,7};
        double ketQua = tinhTrungBinh(numbers);
        Console.WriteLine($"Input: [{string.Join(", ", numbers)}] -> Output: {ketQua}");
    }
    static void bai_11()
    {
        Console.OutputEncoding = Encoding.UTF8; 
        string input1 = "radar"; 
        string input2 = "hello"; 
        string input3 = "civic"; 
        Console.WriteLine($"Input: \"{input1}\" -> Output: {kiemTraDoiXung(input1)}"); 
        Console.WriteLine($"Input: \"{input2}\" -> Output: {kiemTraDoiXung(input2)}");
        Console.WriteLine($"Input: \"{input3}\" -> Output: {kiemTraDoiXung(input3)}");
    }
    static void bai_12()
    {
        double c = 25;
        Console.WriteLine($"Input: {c} -> Output: {cToF(c)}");
    }
    static void bai_13()
    {
        int[]numbers = {10,5,8,2,9};
        int ketQua = timMin(numbers);
        Console.WriteLine($"Input: [{string.Join(", ", numbers)}] -> Output: {ketQua}");
    }
    static void bai_14()
    {
        int n = 1234; 
        Console.WriteLine($"Input: {n} -> Output: {tongCacChuSo(n)}");
    }
    static void bai_15()
    {
        int[] numbers = { 3, 1, 4, 2 }; 
        Console.Write($"Input: [{string.Join(", ", numbers)}] -> Output: "); 
        sapXepMang(numbers);
    }
    static void bai_16()
    {
        string input = "programming"; 
        Console.WriteLine($"Input: \"{input}\" -> Output: \"{xoaTrungLap(input)}\"");
    }
    static void bai_17()
    {
        int a = 12, b = 18; 
        Console.WriteLine($"Input: a = {a}, b = {b} -> Output: {UCLN(a, b)}");
    }
    static void bai_18()
    {
      int n = 10;
      Console.WriteLine($"Input: {n} -> Output: \"{decimalToBinary(n)}\"");  
    }
    static void bai_19()
    {
        int year1 = 2024; 
        int year2 = 2023; 
        Console.Write($"Input: {year1} -> Output: {kiemTraNamNhuan(year1)}"); 
        Console.WriteLine($@" | Input: {year2} -> Output: {kiemTraNamNhuan(year2)}");
    }
    static void bai_20()
    {
        string input = "Học lập trình C# rất thú vị";
        Console.WriteLine($"Input: \"{input}\" -> Output: {demSoTu(input)}");
    }
    static int Tongtien(int a, int b)
    {
       return a + b; 
    }
    static bool kiemTraChan(int n)
    {
        return n % 2 == 0;
    }
    static int timMax(int x, int y, int z)
    {
        return Math.Max(Math.Max(x,y),z);
    }
    static long tinhGiaiThua(int n)
    {
        long ketQua = 1;
        for (int i = 1; i <= n; i++)
        {
            ketQua *= i;
        }
        return ketQua;
    }
    static string daoNguocChuoi(string input)
    {
        char[]charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string (charArray);
    }
    static bool kiemTraNguyenTo(int n)
    {
        if(n <= 1) return false;
        for (int i = 2; i*i <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void inFibonacci(int n)
    {
        if (n <= 0)
        {
            return;
        }
        long a = 0; 
        long b = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write(a+ " "); //in số đầu tiên
            long next = a+b;
            a=b;
            b=next;
        }
        Console.WriteLine();
    }
    static int demNguyenAm(string n)
    {
        int count = 0; 
        string nguyenAm = "aeiouAEIOU";
        foreach (char kyTu in n)
        {
            if (nguyenAm.Contains(kyTu))
            {
                count++;
            }
        }
        return count;
    }
    static double tinhLuyThua(double x, int y)
    {
      double ketQua = 1.0;
      int soMu = Math.Abs(y);

      for (int i = 0; i < soMu; i++)
        {
            ketQua *= x; 
        }
        if (y < 0)
        {
            return 1.0 / ketQua;
        }
        return ketQua;
    }
    static double tinhTrungBinh(int[] mang)
    {
        double sum = 0;
        foreach(int x in mang)
        {
            sum += x;
        }
        return sum/mang.Length;
    }
    static bool kiemTraDoiXung(string chuoi)
    {
        char[]charArray = chuoi.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        return chuoi == reversed;
    }
    static double cToF(double c)
    {
        return (c * 1.8) + 32;
    }
    static int timMin(int[] mang)
    {
        int min = mang[0];
        for(int i = 1; i < mang.Length; i++)
        {
            if (mang[i] < min)
            {
                min = mang[i];
            }
        }
        return min;
    } 
    static int tongCacChuSo(int n)
    {
        int sum = 0; 
        while (n > 0) 
        { 
            int chuSoCuoi = n % 10; //Lấy chữ số cuối 
            sum += chuSoCuoi; 
            n /= 10; //bỏ chữ số cuối 
        }
        return sum;
    }
    static void sapXepMang(int[] mang)
    {
        for (int i = 0; i < mang.Length - 1; i++) 
        { 
            for (int j = i + 1; j < mang.Length; j++) 
            {  
                if (mang[i] > mang[j]) 
                { 
                    int bienTam = mang[i]; 
                    mang[i] = mang[j]; 
                    mang[j] = bienTam; 
                } 
            }
        }
        for (int i  = 0; i < mang.Length; i++) 
        { 
            Console.Write(mang[i] + (i < mang.Length - 1 ? " " : "")); //nếu đkien đúng, thực hiện sau dấu ?, ngoài ra thực hiện sau dấu :
        } 
        Console.WriteLine(); 
    }
    static string xoaTrungLap(string chuoi)
    {
        string ketQua = "";
        foreach (char kyTu in chuoi) 
        { 
            if (!ketQua.Contains(kyTu)) //!true -> false
            { 
                ketQua += kyTu; 
            } 
        } 
        return ketQua;
    }
    static int UCLN(int a, int b)
    {
        a = Math.Abs(a); 
        b = Math.Abs(b); 
        
        while (b != 0) 
        { 
            int bienTam = b;  
            b = a % b; 
            a = bienTam; 
        } 
        return a; 
    }
    static string decimalToBinary(int n)
    {
        string binary = ""; 
        int bienTam = Math.Abs(n);

        while(bienTam > 0)
        {
            int x = bienTam % 2;
            binary = x + binary;
            bienTam /= 2;
        }
        return n < 0 ? "-" + binary : binary;
    }
    static bool kiemTraNamNhuan(int year)
    {
       return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0); 
    }
    static int demSoTu(string cau)
    {
        string[] words = cau.Split(' ', StringSplitOptions.RemoveEmptyEntries);  
        return words.Length;
    }  
}

