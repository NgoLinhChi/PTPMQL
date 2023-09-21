using Microsoft.Win32.SafeHandles;

namespace NewApp.Models
{
    public class Student
    {
        public string TenSV { get; set; }
        public string MaSV { get; set; }
        public string LopSV { get; set; }
        public double DiemSV { get; set; }

        public Student(){
            TenSV = "Ngo Linh Chi";
            MaSV = "2021050894";
            DiemSV = 8.1;
        }

    public void Nhapthongtin()
    {
        System.Console.WriteLine("Ten sinh vien:");
        TenSV = Console.ReadLine();
        System.Console.WriteLine("Ma sinh vien:");
        MaSV = Console.ReadLine();
        System.Console.WriteLine("Lop sinh vien:");
        LopSV = Console.ReadLine();
        System.Console.WriteLine("Diem sinh vien:");
        DiemSV = Convert.ToInt32(Console.ReadLine());
    }
    public void Hienthi()
    {
        System.Console.WriteLine(TenSV + "-" + MaSV + "-" + LopSV + "-" + DiemSV);
    }
    public void HienThi(string HoTen, string MaSV)
    {
        System.Console.WriteLine("Sinh vien {0} co ma sinh vien la {1}");
    }
    public double Diemhe4(){
        return (DiemSV*0.4);
    }
    }
}