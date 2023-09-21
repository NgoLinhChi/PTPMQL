using Microsoft.Win32.SafeHandles;

namespace NewApp.Models
{
    public class Student : Person
    {
        public string MaSV { get; set; }
        

    public void Nhapthongtin()
    {
        base.Nhapthongtin();
        System.Console.WriteLine("Ma sinh vien: ");
        MaSV = Console.ReadLine();
    }
    public void HienThi()
    {
        base.HienThi();
        System.Console.WriteLine("- Ma sinh vien {0}", MaSV);
    }
    public void HienThi(string HoTen, string MaSV)
    {
        System.Console.WriteLine("Sinh vien {0} co ma sinh vien la {1}");
    }
    public double Namsinh()
    {
        return 2023 - Tuoi;
    }
}
}