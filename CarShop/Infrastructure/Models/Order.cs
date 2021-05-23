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
        [RegularExpression(@"^[А-Яа-яёЁ]{2,20}$", ErrorMessage = "В поле имя покупателя можно использовать только кирилицу и длина поля должна быть от 2 до 20 символов")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым.")]
        [Display(Name = "Фамилия покупателя")]
        [RegularExpression(@"^[А-Яа-яёЁ]{2,20}$", ErrorMessage = "В поле фамилия покупателя можно использовать только кирилицу и длина поля должна быть от 2 до 20 символов")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Электронная почта")]
        [StringLength(100, ErrorMessage = "{0} должна быть от {2} до {1} символов длинной.", MinimumLength = 7)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым.")]
        [Display(Name = "Адрес")]
        [StringLength(100, ErrorMessage = "{0} должен быть от {2} до {1} символов длинной.", MinimumLength = 5)]
        [RegularExpression(@"^[А-Яа-яёЁa-zA-Z\s.,-\\]{5,100}$", ErrorMessage = "Поле адрес должно быть от 5 до 100 символов длиной")]
        public string Address { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
