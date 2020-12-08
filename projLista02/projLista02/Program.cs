using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projLista02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas;
            pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa("Maria", "Silva"));
            pessoas.Add(new Pessoa("Roberta", "Silva", "F"));
            pessoas.Add(new Pessoa("João", "Souza", "M"));
            pessoas.Add(new Pessoa("Antonio", "Santos", "M"));
            pessoas.Add(new Pessoa("Antonia", "Souza", "F"));
            listaPessoas(pessoas);

            pessoas.Insert(3, new Pessoa("Roberta", "Silva", "F"));

            listaPessoas(pessoas);

            // Remoção pelo valor
            Console.WriteLine(pessoas.Remove(new Pessoa("Antonio", "Santos")) ? "Removeu" : "Não encontrou");
            listaPessoas(pessoas);

            // Remoção pela posição
            pessoas.RemoveAt(0);
            listaPessoas(pessoas);

            Console.WriteLine("Posição da Roberta Silva: {0}", pessoas.IndexOf(new Pessoa("Roberta", "Silva")));
            Console.WriteLine("Posição da Roberta Silva: {0}", pessoas.LastIndexOf(new Pessoa("Roberta", "Silva")));

            Console.WriteLine("Dados do João Souza: {0}", pessoas.Find(x => x.nomeCompleto() == "João Souza").ToString());
            Console.WriteLine("Só o nome do João Souza: {0}", pessoas.Find(x => x.nomeCompleto() == "João Souza").Nome);

            listaPessoasNomeBibliografico(pessoas.Where(x => x.Sobrenome == "Souza").ToList());

            listaPessoasNomeBibliografico(pessoas.FindAll(x => x.Sobrenome == "Silva"));

            listaPessoas(pessoas.OrderBy(x => x.Nome).ToList());

            listaPessoas(pessoas.FindAll(x => x.Sexo == "M"));

            Console.ReadKey();
        }

        static void listaPessoas(List<Pessoa> lp)
        {
            Console.WriteLine("- Qtde: {0} -----------------------------", lp.Count);
            foreach (Pessoa p in lp)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("---------------------------------------");
        }

        static void listaPessoasNomeBibliografico(List<Pessoa> lp)
        {
            Console.WriteLine("- Qtde: {0} -----------------------------", lp.Count);
            foreach (Pessoa p in lp)
            {
                Console.WriteLine(p.nomeBibliografico());
            }
            Console.WriteLine("---------------------------------------");
        }
    }
}
