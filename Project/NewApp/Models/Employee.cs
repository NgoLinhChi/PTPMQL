namespace NewApp.Models
{
    public class Employee
    {
        public string TenNV { get; set; }
        public string MaNV { get; set; }
        public int TuoiNV { get; set; }
        public int LuongCoBan { get; set; }

        public Employee(){
            MaNV = "2021050894";
            TenNV = "Ngo Linh Chi";
        }
    
        public void Nhapthongtin()
        {
            System.Console.WriteLine("Ten nhan vien:");
            TenNV = Console.ReadLine();
            System.Console.WriteLine("Ma nhan vien:");
            MaNV = Console.ReadLine();
            System.Console.WriteLine("Tuoi nhan vien:");
            TuoiNV = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Luong co ban: ");
            LuongCoBan = Convert.ToInt32(Console.ReadLine());
        }
        public void Hienthi()
        {
            System.Console.WriteLine(TenNV + "-" + MaNV + "-" + TuoiNV + "-" + LuongCoBan);
        }
        public void HienThi(string TNV, int LCB)
        {
            System.Console.WriteLine("Nhan vien {0} co muc luong co ban la {1}");
        }
        public int Luong(double hsl, int pc)
        {
            return Convert.ToInt32(LuongCoBan * hsl + pc);
        }
    } 
}