namespace NewApp.Models
{
    public class Employee : Person
    {
        public string MaNV { get; set; }
        public int LuongCoBan { get; set; }

        public Employee(){
            MaNV = "2021050894";
        }
    
        public void Nhapthongtin()
        {
            base.Nhapthongtin();
            System.Console.WriteLine("Ma nhan vien:");
            MaNV = Console.ReadLine();
            System.Console.WriteLine("Luong co ban: ");
            LuongCoBan = Convert.ToInt32(Console.ReadLine());
        }
        public void Hienthi()
        {
            base.HienThi();
            System.Console.WriteLine("-" + MaNV + "-" + LuongCoBan);
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