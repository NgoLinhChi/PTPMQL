using System.Reflection.Metadata;
using NewApp.Models;
public class Program {
    private static void Main(string[] args){
        Person ps1 = new Person();
        Employee emp = new Employee();
        Student std = new Student();
        Fruit fr = new Fruit();
        string HoTen = "Ngo Linh Chi";
        int Tuoi = 21;
        ps1.HienThi(HoTen, Tuoi);
        System.Console.WriteLine("{0} sinh nam {1}", HoTen, ps1.Namsinh);
        
        string TenSV = "Ngo Linh Chi";
        string MaSV = "2021050894";
        std.HienThi(TenSV,MaSV);
        System.Console.WriteLine("Sinh vien {0} co ma sinh vien la {1}", TenSV, MaSV);

        string TenNV = "Ngo Linh Chi";
        int LuongCoBan = 2000000;
        double hsl = 3.12;
        int pc = 150000;
        emp.HienThi(TenNV, LuongCoBan);
        emp.LuongCoBan = 3000000;
        System.Console.WriteLine("Nhan vien {0} nhan muc luong co ban la {1}", TenNV, LuongCoBan);

        string Tengoi = "Dau tay";
        string Xuatxu = "Han Quoc";
        fr.HienThi(Tengoi, Xuatxu);
        System.Console.WriteLine("{0} co xuat xu tu {1}", Tengoi, Xuatxu);
    }
}