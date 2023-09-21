namespace NewApp.Models;
public class Person 
{
    public string HoTen { get; set; }
    public int Tuoi { get; set; }
    public string DiaChi { get; set; }

    public void Nhapthongtin(){
        System.Console.WriteLine("Ho va ten: ");
        HoTen = Console.ReadLine();
        System.Console.WriteLine("Tuoi: ");
        Tuoi = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Dia chi: ");
        DiaChi = Console.ReadLine();
        
    }
    public void Hienthi(){
        System.Console.WriteLine(HoTen + "-" + Tuoi + "-" + DiaChi);
    }
}
