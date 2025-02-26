using System.IO;    
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FirstWebMVC.Models
{
    public class TotalAmount
    {
        [Required(ErrorMessage = "ID san pham ko duoc de trong!")]
        public string productID { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "so luong pahi lon hon or bang 0")]
        [DefaultValue(0)] //khong nhap sl se bang 0
        public int Quantity { get; set;}

        [Range(1000, 1000000, ErrorMessage = "don gia phai tu 1k den 1000k!")]
        public double UnitPrice { get; set; }

        public double totalAmount => UnitPrice * Quantity; // thuoc tinh chi doc(tranh quen tong tien sau khi thay doi so luowng)

    }
}