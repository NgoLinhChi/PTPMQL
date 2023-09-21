namespace NewApp.Models
{
    public class Employee
    {
        public string TenNV { get; set; }
        public string MaNV { get; set; }
        public int TuoiNV { get; set; }
        public int LuongNV { get; set; }
    
        public void Nhapthongtin()
        {
            System.Console.WriteLine("Ten nhan vien:");
            TenNV = Console.ReadLine();
            System.Console.WriteLine("Ma nhan vien:");
            MaNV = Console.ReadLine();
            System.Console.WriteLine("Tuoi nhan vien:");
            TuoiNV = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Luong nhan vien:");
            LuongNV = Convert.ToInt32(Console.ReadLine());
        }
        public void Hienthi()
        {
            System.Console.WriteLine(TenNV + "-" + MaNV + "-" + TuoiNV + "-" + LuongNV);
        }
    } 
}