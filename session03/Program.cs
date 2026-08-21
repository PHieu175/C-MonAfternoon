internal class Excercise_21thAug
{
    static void Bai_1()
    {
      //Bai 1:
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
public static void Main(string[]args)
    {
        Bai_1();

        //Bai 2: 
        Console.Write("Chieu cao (m): ");
        double chieucao = Convert.ToDouble(Console.ReadLine());
        Console.Write("Can nang (kg): ");
        double cannang = Convert.ToDouble(Console.ReadLine());

        double bmi = cannang/(chieucao*chieucao);

    } 
}
