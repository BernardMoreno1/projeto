using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetofinaldnv.Models
{
    public class Gerente : Persona
    {
        [Key]
        public int IdGerente { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string? Email { get; set; }

        [Required]
        [Phone]
        [MaxLength(20)]
        public string? Telefone { get; set; }

        [Required]
        public string? SenhaUsuario { get; set; }

    }
}
