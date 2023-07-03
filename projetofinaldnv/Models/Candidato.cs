using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using projetofinaldnv.Context;

namespace projetofinaldnv.Models
{
    public class Candidato : Persona
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

            public int IdCandidato { get; set; }

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

            [Required]
            [DataType(DataType.Date)]
            public DateTime DataNascimento { get; set; }

    }
}
