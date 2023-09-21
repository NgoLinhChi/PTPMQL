using NewApp.Models;
public class Program {
    private static void Main(string[] args){
        Person ps1 = new Person();
        Person ps2 = new Person();
        Employee emp = new Employee();
        Student std = new Student();
        Fruit fr = new Fruit();
        ps1.HoTen = "Ngo Linh Chi";
        ps1.DiaChi = "Ha Noi";
        ps1.Tuoi = 21;
        ps1.Hienthi();
        ps2.Nhapthongtin();
        ps2.Hienthi();
        emp.Nhapthongtin();
        emp.Hienthi();
        std.Nhapthongtin();
        std.Hienthi();
        fr.Nhapthongtin();
        fr.Hienthi();
    }
}