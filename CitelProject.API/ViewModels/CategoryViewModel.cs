using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CitelProject.WebApi.ViewModels
{
    public class CategoryViewModel
    {
        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage ="Preencha o campo Nome")]
        [Display(Name="Nome")]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição")]
        [Display(Name = "Descrição")]
        [MaxLength(250)]
        public string Description { get; set; }

        public virtual IEnumerable<ProductViewModel> Products { get; set; }
    }
}