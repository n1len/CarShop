using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CarShop.Infrastructure.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым.")]
        [Display(Name = "Имя покупателя")]
        [StringLength(20, ErrorMessage = "{0} должно быть от {2} до {1} символов длинной.",MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым.")]
        [Display(Name = "Фамилия покупателя")]
        [StringLength(20, ErrorMessage = "{0} должна быть от {2} до {1} символов длинной.", MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Электронная почта")]
        [StringLength(100, ErrorMessage = "{0} должна быть от {2} до {1} символов длинной.", MinimumLength = 7)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым.")]
        [Display(Name = "Адрес")]
        [StringLength(100, ErrorMessage = "{0} должен быть от {2} до {1} символов длинной.", MinimumLength = 5)]
        public string Address { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
