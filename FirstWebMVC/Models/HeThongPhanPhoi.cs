using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FirstWebMVC.Models

{
    
    public class HeThongPhanPhoi
    {
        [Key]
        public required string MaHTPP { get; set; }
        public string TenHTPP { get; set; } = string.Empty;

        public ICollection<DaiLy>? DaiLy { get; set; }
    }
}