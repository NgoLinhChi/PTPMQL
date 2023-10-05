using System.IO.Pipes;

namespace NewApp.Models;
public class Customer : Person
{
    public string CustomerID { get; set; }
    public string SoDT { get; set; }
    public Customer() {
        CustomerID ="2021050894";
    }
    public void Nhapthongtin(){
        System.Console.WriteLine("Ma khach hang: ");
        CustomerID = Console.ReadLine();
        System.Console.WriteLine("So dien thoai khach hang: ");
        SoDT = Console.ReadLine();
    }
    public void HienThi(){
        base.HienThi();
        System.Console.WriteLine(CustomerID + "-" + SoDT);
    }
}