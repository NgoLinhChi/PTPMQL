using System.Reflection.Metadata;
using NewApp.Models;
public class Program {
    private static void Main(string[] args){
        Person ps1 = new Person();
        Employee emp = new Employee();
        Student std = new Student();
        Fruit fr = new Fruit();
        Cam org = new Cam();
        string HoTen = "Ngo Linh Chi";
        int Tuoi = 21;
        ps1.HienThi(HoTen, Tuoi);
        System.Console.WriteLine("{0} sinh nam {1}", HoTen, ps1.Namsinh);
        
        std.Nhapthongtin();
        std.HienThi();

        emp.Nhapthongtin();
        emp.HienThi();

        org.Nhapthongtin();
        org.Hienthi();
        org.Note();
    }
}