using System.Globalization;
using System.Runtime.CompilerServices;

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
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        double chieucao = 0;
        double cannang = 0;

        Console.Write("Chiều cao (m): ");
        chieucao = Convert.ToDouble(Console.ReadLine());
        if(chieucao <= 0)
        {
            Console.WriteLine("Lỗi!!! Chiều cao phải là số thực lớn hơn 0");
            return;
        }
        Console.Write("Cân nặng (kg): ");
        cannang = Convert.ToDouble(Console.ReadLine());
         if(cannang <= 0)
        {
            Console.WriteLine("Lỗi!!! Cân nặng phải là số thực lớn hơn 0");
            return;
        }

        double bmi = cannang/(Math.Pow(chieucao,2));

        string phanLoai = "";
        if(bmi < 18.5)
        {
            phanLoai = "Gầy (Thiếu cân)";
        }
        else if(bmi < 23)
        {
            phanLoai = "Bình thường (Lý tưởng)";
        }
        else if(bmi < 25)
        {
            phanLoai = "Thừa cân (Tiền béo phì)";
        }
        else
        {
            phanLoai = "Béo phì";
        }

        double minIdealWeight = 18.5 * Math.Pow(chieucao,2);
        double maxIdealWeight = 22.9 * Math.Pow(chieucao,2);
    
        Console.WriteLine($"Chỉ co BMI cua ban: {bmi:F2}");
        Console.WriteLine($"Phân loại sức khoẻ: {phanLoai}");
        Console.WriteLine($"Lời khuyên: Cân nặng lý tưởng của bận nên từ {minIdealWeight:F2} kg đến {maxIdealWeight:F2} kg.");

        Console.ReadKey(); 
    }
    static void Bai_3()
    {
       Console.OutputEncoding = System.Text.Encoding.UTF8;
       Console.InputEncoding = System.Text.Encoding.UTF8;

       decimal vndInput = 0;
       bool isValid = false;
    
       do
        {
            Console.Write("Nhập số tiền VNĐ: ");
            string soTien = Console.ReadLine()!;
            //thêm "!" để bỏ thông báo có thể có null

            if(decimal.TryParse(soTien, out vndInput) && vndInput > 0)
            {
            isValid = true;
            }
            else
            {
            Console.WriteLine("Lỗi!!! Số tiền nhập phải lớn hơn 0. Vui lòng nhập lại."); 
            }

        } while(isValid == false);
        //cách sử dụng "bool" và vòng lặp "do-while" được e tham khảo từ ng bên ngoài

        CurrencyType currencyDaChon = CurrencyType.USD; 
        bool isValidChoice = false;

        do
        {
            Console.WriteLine("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): "); 
            string luaChonChuoi = Console.ReadLine()!;
            int luaChon;

            if(int.TryParse(luaChonChuoi, out luaChon) && Enum.IsDefined(typeof(CurrencyType), luaChon))
            {
                currencyDaChon = (CurrencyType)luaChon;
                isValidChoice = true;
            }
            else
            {
                Console.WriteLine("Lỗi!!! Lựa chọn không hợp lệ (Chỉ nhập từ 1 đến 4). Vui lòng nhập lại!");
            }
        } while(isValidChoice == false);

        decimal rateUSD = 25400m;
        decimal rateEUR = 27200m;
        decimal rateJPY = 165m;
        decimal rateGBP = 32100m;

        decimal phiPhanTram = 0.005m; 
        decimal phiDichVu = vndInput * phiPhanTram; 
        decimal luongTienVNDQuyDoi = vndInput - phiDichVu;
        
        decimal luongQuyDoi = 0;
        decimal tyLeQuyDoi = 1;
        string kyHieuTienTe = "";

        switch (currencyDaChon)
        {
            case CurrencyType.USD:
                tyLeQuyDoi = rateUSD;
                kyHieuTienTe = "USD";
                break;
            case CurrencyType.EUR:
                tyLeQuyDoi = rateEUR;
                kyHieuTienTe = "EUR";
                break;
            case CurrencyType.JPY:
                tyLeQuyDoi = rateJPY;
                kyHieuTienTe = "JPY";
                break;
            case CurrencyType.GBP:
                tyLeQuyDoi = rateGBP;
                kyHieuTienTe = "GBP";
                break;
        }  
        luongQuyDoi = luongTienVNDQuyDoi/tyLeQuyDoi;

        Console.WriteLine($"Phí dịch vụ (0.5%): {luongTienVNDQuyDoi:N0} VNĐ");
        Console.WriteLine($"Số tiền tính đổi: {luongTienVNDQuyDoi:N0} VNĐ"); 
        Console.WriteLine($"Số tiền {kyHieuTienTe} nhận được: {luongQuyDoi:N2} {kyHieuTienTe}");   

        Console.ReadKey();  

    } 
    static void Bai_4()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        DateTime birthDate = DateTime.MinValue;
        //Ngày giờ của ngày SN = mốc thời gian nhỏ nhất có thể lưu trữ

        Console.Write("Nhập ngày sinh của bạn (định dạng dd/MM/yyyy, ví dụ 15/09/2003): ");
        string duLieuNhap = Console.ReadLine()!;

        DateTime.TryParseExact(duLieuNhap, "dd/MM/yyyy", CultureInfo.InvariantCulture,  DateTimeStyles.None,  out birthDate);
        // "CultureInfo.InvariantCulture" tạo quy chuẩn chung cho all quốc gia
        // "DateTimeStyles.None" ko cho khoảng trắng, hay tự bù trừ múi giờ    

        DateTime today = DateTime.Today;

        int age = today.Year - birthDate.Year;
        // tính tuổi tạm thời = cách lấy năm nay - năm sinh
        if (today < birthDate.AddYears(age))
        {
            age--;
        }
        //birthDate.AddYears sẽ tính ngày sinh trong năm nay = cách lấy ngày/tháng/năm gốc cộng tuổi tạm thời
        //"if" nếu ngày hôm nay < ngày sinh trong năm nay thì tuổi tạm thời -1
        // có tham khảo các nguồn bên ngoài

        TimeSpan soNgayDaQua = today - birthDate;
        int tongNgaySong = (int)soNgayDaQua.TotalDays;

        // tính số ngày còn lại đến sinh nhật tiếp theo
        int nextBirthdayYear = today.Year;
        int birthMonth = birthDate.Month;
        int birthDay = birthDate.Day;

        DateTime nextBirthday = new DateTime(nextBirthdayYear, birthMonth, birthDay);

        if (nextBirthday < today)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }

        int daysLeft = (nextBirthday - today).Days;

        Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
        Console.WriteLine($"Bạn đã sống tổng cộng: {tongNgaySong:N0} ngày");
        Console.WriteLine($"Sinh nhật tiếp theo còn: {daysLeft} ngày nữa");
        
        Console.ReadKey();  
    }
    static void Bai_7()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Quãng đường (km): ");
        double khoangCach = double.Parse(Console.ReadLine()!);

        Console.Write("Mức tiêu hao (L/100km): ");
        double mucTieuHaoNhienLieu = double.Parse(Console.ReadLine()!);

        Console.Write("Giá xăng (VNĐ/Lít): ");
        decimal giaXang = decimal.Parse(Console.ReadLine()!);

        Console.Write("Số người đi: ");
        int slNguoiThamGia = int.Parse(Console.ReadLine()!);

        double tongSoLitNhienLieu = (khoangCach / 100.0) * mucTieuHaoNhienLieu;

        decimal tongGiaXang = (decimal)tongSoLitNhienLieu * giaXang;

        decimal giaGocTrenNguoi = tongGiaXang / slNguoiThamGia;
        decimal giaLamTronTrenNguoi = Math.Ceiling(giaGocTrenNguoi / 1000m) * 1000m;

        Console.WriteLine($"Tổng nhiên liệu tiêu thụ : {tongSoLitNhienLieu:N2} Lít");
        Console.WriteLine($"Tổng chi phí xăng dầu   : {tongGiaXang:N0} VNĐ");
        Console.WriteLine($"Chi phí mỗi người        : {giaLamTronTrenNguoi:N2} VNĐ");
        Console.WriteLine("---------------------------------------------------------");
        
        Console.ReadKey();
        }
enum CurrencyType
    {
        USD = 1,
        EUR,
        JPY,
        GBP,
    }
    public static void Main(string[]args)
    {
        Bai_7();
    } 
}
