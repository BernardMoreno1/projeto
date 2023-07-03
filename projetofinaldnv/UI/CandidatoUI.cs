using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetofinaldnv.Models;
using projetofinaldnv.Context;
using System.Globalization;

namespace projetofinaldnv.UI
{
    public class CandidatoUI
    {
        public void ImprimirValores()
        {
            try
            {
                Console.WriteLine("Digite seu nome:");
                var nome = Console.ReadLine();

                Console.WriteLine("Digite seu email:");
                var email = Console.ReadLine();

                Console.WriteLine("Digite seu telefone:"); 
                var telefone = Console.ReadLine();

                Console.WriteLine("Digite sua data de nascimento (DD/MM/YYYY):");
                var dataNascimentoStr = Console.ReadLine();

                Console.WriteLine("Gostaria de estar se cadastando como gerente(G) ou candidato(C)?");
                var decisao = Console.ReadLine();;

                if (decisao == "C")
                {
                    using (var context = new MeuContexto())
                    {
                        var candidato = new Candidato { Nome = nome, Email = email, Telefone = telefone, DataNascimento = DateTime.Parse(dataNascimentoStr) };
                        context.Candidatos.Add(candidato);
                        context.SaveChanges();
                    }
                }   else
                {
                    using (var context = new MeuContexto())
                    {
                        var gerente = new Gerente { Nome = nome, Email = email, Telefone = telefone };
                        context.Gerentes.Add(gerente);
                        context.SaveChanges();
                    }
                }
                Console.WriteLine("Cadastro realizado com sucesso!");
            }
            catch
            {
                Console.WriteLine("Erro ao se cadastrar!");
            }
        }
    }
}
