using System.Net.Sockets;

namespace NewApp.Models;
public class Person 
{
    public string HoTen { get; set; }
    public int Tuoi { get; set; }
    public string DiaChi { get; set; }

    public Person(){
        HoTen = "Default";
        DiaChi = "Default";
        Tuoi = 15;
    }
    public void Nhapthongtin(){
        System.Console.WriteLine("Ho va ten: ");
        HoTen = Console.ReadLine();
        System.Console.WriteLine("Tuoi: ");
        Tuoi = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Dia chi: ");
        DiaChi = Console.ReadLine();
        
    }
    public void HienThi(){
        System.Console.WriteLine(HoTen + "-" + Tuoi + "-" + DiaChi);
    }
    public void HienThi(string Ten, int Tuoi){
        System.Console.WriteLine("{0} - {1} tuoi", Ten, Tuoi);
    }
    public int Namsinh(int Tuoi){
        int Namsinh = 2023 - Tuoi;
        return Namsinh;
    }    
}
