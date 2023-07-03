using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetofinaldnv.Enums;

namespace projetofinaldnv.Models
{
    public class ProcessoSeletivo : Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdProcesso { get; set; }

        [ForeignKey("Gerente")]

        public int IdGerente { get; set; }

        [Required, MaxLength(100)]
        public string NomeProcesso { get; set; }
        [Required]
        public string DescricaoProcesso { get; set; }
        public DateTime DataInicio { get; set; }
        [Required]
        public DateTime DataFim { get; set; }
        [MaxLength(100)]
        public string NomeEmpresa { get; set; }
        public Gerente CriadorProcesso { get; set; }
        public Privacidade PrivacidadeProcesso { get; set; }
        public ICollection<Candidato> CandidatosProcesso { get; set; }
        public List<Candidatura> Canditaturas { get; set; }
        public void SetIdProcesso(int value)
        {
            IdProcesso = value;
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine(NomeProcesso);
            Console.WriteLine(DescricaoProcesso);
            Console.WriteLine(DataInicio);
            Console.WriteLine(DataFim);
            Console.WriteLine(NomeEmpresa);
            Console.WriteLine(CriadorEvento);
            Console.WriteLine(PrivacidadeProcesso);

        }

    }
}
