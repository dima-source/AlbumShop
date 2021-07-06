using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }
        [Display(Name = "Введите имя")]
        [StringLength(50, MinimumLength = 2)]
        [Required(ErrorMessage = "Длинна имени не менее 2 символов")]
        public string Name { get; set; }
        [Display(Name = "Введите фамилию")]
        [StringLength(50, MinimumLength = 2)]
        [Required(ErrorMessage = "Длинна фамилии не менее 2 символов")]
        public string SuName { get; set; }
        [Display(Name = "Введите адресс")]
        [StringLength(50, MinimumLength = 2)]
        [Required(ErrorMessage = "Длинна адреса не менее 2 символов")]
        public string Adress { get; set; }
        [Display(Name = "Введите номер")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длинна номера не менее 10 символов")]
        public string Phone { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, MinimumLength = 2)]
        [Required(ErrorMessage = "Длинна имени не менее 6 символов")]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
