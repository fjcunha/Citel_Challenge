using System.ComponentModel.DataAnnotations;

namespace CitelProject.WebApi.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [Display(Name = "Nome")]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição")]
        [Display(Name = "Descrição")]
        [MaxLength(150)]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Preencha o campo Valor")]
        [Range(typeof(decimal),"0","999999999999")]
        [Display(Name = "Valor")]
        public decimal Value { get; set; }

        public int CategoryID { get; set; }
        public virtual CategoryViewModel Category { get; set; }
    }
}