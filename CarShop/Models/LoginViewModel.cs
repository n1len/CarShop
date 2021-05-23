using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Поле не может быть пустым.")]
        [Display(Name = "Логин")]
        [RegularExpression(@"^[A-Za-z0-9_]{2,20}$", ErrorMessage = "В поле логин можно использовать только латинские буквы, цифры, знак \"_\" и длина поля должна быть от 2 до 20 символов")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым.")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        [StringLength(30, ErrorMessage = "{0} должен быть от {2} до {1} символов длинной.", MinimumLength = 6)]
        public string Password { get; set; }

        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
