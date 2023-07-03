using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace projetofinaldnv.Models
{
    public class Candidatura : Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdCandidato { get; set; }

        [Required]
        public DateTime DataAplicacao { get; set; }

        [ForeignKey("Processo_Seletivo")]
        public int IdProcessoCandidato { get; set; }
        public ProcessoSeletivo ProcessoCandidatura { get; set; }
        [ForeignKey("Candidato")]
        public int CandidatoCandidaturaIdCandidato { get; set; }
        public int ProcessoCandidaturaIdProcesso{ get; set; }
        public Candidato CandidatoCandidatura { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine(IdProcessoCandidato);
            Console.WriteLine(ProcessoCandidatura);
            Console.WriteLine(CandidatoCandidaturaIdCandidato);
            Console.WriteLine(ProcessoCandidaturaIdProcesso);
            Console.WriteLine(CandidatoCandidatura);

        }

    }
}
