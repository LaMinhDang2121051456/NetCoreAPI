using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
namespace FirstWebMVC.Models
{
    public class AverageScore
    {
        [Required(ErrorMessage = "khong duoc de trong")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "ten mon hoc phai dai tu 3 den 100 ki tu")]
        public string SubjectName { get; set; } = "";
        [Required(ErrorMessage = "khong duoc de trong diem ")]
        [Range(0, 10, ErrorMessage = "diem nam tu 0 den 10")]
        public double Ascore { get; set; }
        public double Bscore { get; set; }
        public double Cscore { get; set; }
        public double TotalScore { get; set; }
        
    }
}