using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FirstWebMVC.Models;

public class DaiLy
{
    [Key]
    public required string MaDaiLy { get; set; }
    public string TenDaiLy { get; set; } = string.Empty;
    public string DiaChi { get; set; } = string.Empty;
    public string NguoiDaiDien { get; set; } = string.Empty;
    public string DienThoai { get; set; } = string.Empty;

    // Khóa ngoại
    [ForeignKey("HeThongPhanPhoi")]
    public string MaHTPP { get; set; }

    // Liên kết với HeThongPhanPhoi
    public HeThongPhanPhoi HeThongPhanPhoi { get; set; }
}
