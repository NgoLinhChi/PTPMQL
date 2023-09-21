namespace NewApp.Models
{
    public class Fruit
    {
        public string Tengoi { get; set; }
        public string Xuatxu { get; set; }
        public string MaSP { get; set; }

        public void Nhapthongtin()
        {
            System.Console.WriteLine("Ten:");
            Tengoi = Console.ReadLine();
            System.Console.WriteLine("Xuat xu:");
            Xuatxu = Console.ReadLine();
            System.Console.WriteLine("Ma san pham:");
            MaSP = Console.ReadLine();
        }
         public void Hienthi()
        {
        System.Console.WriteLine(Tengoi + "-" + MaSP + "-" + Xuatxu);
        }
    }
}