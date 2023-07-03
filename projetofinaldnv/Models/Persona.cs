using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetofinaldnv.Models
{
    public abstract class Persona //Herança
    {
        [Required]
        [MaxLength(100)]
        public string? Nome { get; set; }

        public string Informacoes { get; set; }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine(Informacoes);
        }

    }
}
