using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CarShop.Infrastructure.Models
{
    public class Car
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле модель не может быть пустым.")]
        [Display(Name = "Модель")]
        [RegularExpression(@"^[А-Яа-яёЁA-Za-z0-9\s]{2,20}$", ErrorMessage = "В поле модель можно использовать кирилицу,латиницу,цифры и длина поля должна быть от 2 до 20 символов")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Поле описание не может быть пустым.")]
        [Display(Name = "Описание")]
        [RegularExpression(@"^[А-Яа-яёЁA-Za-z0-9\s,.\\-_:]{2,300}$", ErrorMessage = "В поле модель можно использовать кирилицу,латиницу,цифры и длина поля должна быть от 2 до 300 символов")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Поле пробег не может быть пустым")]
        [Display(Name = "Пробег")]
        [Range(0, 1500000, ErrorMessage = "Недопустимый пробег")]
        public uint Mileage { get; set; }


        [Display(Name = "Цвет кузова")]
        public string Color { get; set; }

        
        [Display(Name = "Год выпуска")]
        public uint Year { get; set; }

        
        [Display(Name = "Объём двигателя")]
        public double EngineVolume { get; set; }

        [Required(ErrorMessage = "Поле марка не может быть пустым.")]
        [Display(Name = "Марка")]
        [RegularExpression(@"^[А-Яа-яёЁA-Za-z0-9\s]{2,20}$", ErrorMessage = "В поле модель можно использовать кирилицу,латиницу,цифры и длина поля должна быть от 2 до 20 символов")]
        public string Brand { get; set; }

        
        [Display(Name = "Тип кузова")]
        public string BodyType { get; set; }

        
        [Display(Name = "Тип двигателя")]
        public string EngineType { get; set; }

       
        [Display(Name = "КПП")]
        public string GearBox { get; set; }
        
       
        [Display(Name = "Привод")]
        public string DriveUnit { get; set; }

        [Required(ErrorMessage = "Поле цена не может быть пустым.")] 
        [Display(Name = "Цена")]
        [Range(0,10000000, ErrorMessage = "Недопустимая цена")]
        public decimal Price { get; set; }
    }
}
