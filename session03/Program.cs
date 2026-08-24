internal class Excercise_21thAug
{
    static void Bai_1()
    {
        Console.Write("Nhap chi so Dien cu (kWh): "); 
        int chisoCu = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhap chi so Dien moi (kWh): ");
        int chisoMoi = Convert.ToInt32(Console.ReadLine());

        decimal tienDienchuathue = 0;
        decimal ThueVat = 0;
        decimal tongTien = 0;

        if(chisoMoi < chisoCu)
        {
            Console.WriteLine("Loi: chi so Moi phai lon hon chi so Cu!!!");
            return;
        }
        int soDien = chisoMoi - chisoCu;

        if(soDien < 50)
        {
            tienDienchuathue = soDien*1806m;
        }
        if(soDien < 100)
        {
            tienDienchuathue = soDien*1866m;
        }
        if(soDien < 200)
        {
            tienDienchuathue = soDien*2167m;
        }
        if(soDien<300)
        {
            tienDienchuathue = soDien*2729m;
        }
        else
        {
            tienDienchuathue = soDien*3050m;
        }

        ThueVat = tienDienchuathue*0.08m;
        tongTien = tienDienchuathue + ThueVat;

        Console.WriteLine($"So dien tieu thu: {soDien:N0} kWh");
        Console.WriteLine($"Tien dien chua thue: {tienDienchuathue:N0} VND");
        Console.WriteLine($"Thue VAT (8%): {ThueVat:N0} VND");
        Console.WriteLine($"Tong thanh toan: {tongTien:N0} VND");

        Console.ReadKey();  
    }
    static void Bai_2()
    {
        Console.Write("Chieu cao (m): ");
        double chieucao = Convert.ToDouble(Console.ReadLine());
        Console.Write("Can nang (kg): ");
        double cannang = Convert.ToDouble(Console.ReadLine());

        double bmi = cannang/(chieucao*chieucao);

        Console.WriteLine($"Chi co BMI cua ban: {bmi}");

        Console.ReadKey(); 
    }
    static void Bai_3()
    {
        
    }
    static void Bai_4()
    {
        
    }
    static void Bai_5()
    {
        
    }
    static void Bai_6()
    {
        
    }
    static void Bai_7()
    {
        
    }
    static void Bai_8()
    {
        
    }
    static void Bai_9()
    {
        
    }
    static void Bai_10()
    {
        
    }
    static void Bai_11()
    {
        
    }
    static void Bai_12()
    {
        
    }
    static void Bai_13()
    {
        
    }
    static void Bai_14()
    {
        
    }
    static void Bai_15()
    {
        
    }
public static void Main(string[]args)
    {
        Bai_1();
        Bai_2();
        Bai_3();
        Bai_4();
        Bai_5();
        Bai_6();
        Bai_7();
        Bai_8();
        Bai_9();
        Bai_10();
        Bai_11();
        Bai_12();
        Bai_13();
        Bai_14();
        Bai_15();
    } 
}
