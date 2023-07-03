using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetofinaldnv.Models;
using projetofinaldnv.Context;

namespace projetofinaldnv.UI
{
    public class ProcessoSeletivoUI
    {
        public void AdicionarProcesso()
        {
            try
            {
                Console.WriteLine("Digite seu ID de identificação:");
                var gerenteId = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome do processo:");
                var nome = Console.ReadLine();

                Console.WriteLine("Digite o nome de sua empresa:");
                var NomeEmp = Console.ReadLine();

                Console.WriteLine("Digite a descrição do processo, digite de maneira clara e coesa!");
                var textoDesc = Console.ReadLine();

                Console.WriteLine("Digite a data de início do processo seletivo (DD/MM/YYYY):");
                var dataIniInf = Console.ReadLine();

                Console.WriteLine("Digite a data de término do processo seletivo (DD/MM/YYYY):");
                var dataFimInf = Console.ReadLine();


                using (var context = new MeuContexto())
                {
                    var processo = new ProcessoSeletivo { IdGerente = gerenteId, Nome = nome, NomeEmpresa = NomeEmp, DescricaoProcesso = textoDesc, DataInicio = DateTime.Parse(dataIniInf), DataFim = DateTime.Parse(dataFimInf) };
                    context.Processos.Add(processo);
                    context.SaveChanges();
                }

                Console.WriteLine("Processo adicionado com sucesso!");
            }
            catch
            {
                Console.WriteLine("Erro ao adicionar processo");
            }

        }
    }
}
