using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_MVC.Models
{
    public class Produto
    {
        public int id { get; set; }

        [Display(Name ="Descrição")]
        [Required(ErrorMessage ="Campo Obrigatório.")]
        public string descricao { get; set; }
        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Range(1,10,ErrorMessage ="Quantidade fora do range")]
        public int quantidade { get; set; }
        [Display(Name = "Categoria")]
        public int categoriaID { get; set; }

        public Categoria Categoria { get; set; }

    }
}
