using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FirstWebMVC.Models
{
    [Table("DaiLy")]
    public class DaiLy
    {
        [Key]
        public string MaDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string DiaChi { get; set; }
        public string NguoiDaiDien { get; set; }
        public string Dienthoai { get; set; }

            [ForeignKey("HeThongPhanPhoi")]
        public string MaHTPP { get; set; }
    }
}