using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_MVC.Models
{
    public class Categoria
    {
        public int id { get; set;}

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string descricao { get; set;}
    }
}
