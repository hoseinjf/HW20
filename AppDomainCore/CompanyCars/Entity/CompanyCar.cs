using AppDomainCore.Cars.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CompanyCars.Entity
{
    public class CompanyCar
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="این فیلد اجباری است")]
        [MinLength(2,ErrorMessage ="تعداد کاراکتر وارد شده کمتر از حد مجاز است")]
        [MaxLength(50, ErrorMessage = "تعداد کاراکتر وارد شده بیشتر از حد مجاز است")]
        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        public CompanyEnum Company { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        public DateOnly CreateYear { get; set; }
    }
}
