namespace FirstWebMVC.Models
{
    public class Product
    { 
          
         public string ProductID { get; set; } = string.Empty; // Mã sản phẩm
        public int Quantity { get; set; }  // Số lượng
        public double UnitPrice { get; set; }  // Đơn giá

        public double TotalPrice => Quantity * UnitPrice;  // Thành tiền
    }
}