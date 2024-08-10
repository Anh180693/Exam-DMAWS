using System.ComponentModel.DataAnnotations;

namespace Exam.Models
{
    public class Order
    {
        [Key]
        public int ItemCode { get; set; }

        [Required]
        [StringLength(100)]
        public string ItemName { get; set; }

        [Required]
        public int ItemQty { get; set; }

        [Required]
        public DateTime OrderDelivery { get; set; }

        [Required]
        [StringLength(200)]
        public string OrderAddress { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
