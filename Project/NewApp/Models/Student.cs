using Microsoft.Win32.SafeHandles;

namespace NewApp.Models
{
    public class Student
    {
        public string TenSV { get; set; }
        public string MaSV { get; set; }
        public string LopSV { get; set; }
        public double DiemSV { get; set; }

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
    }
}