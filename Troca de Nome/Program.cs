using System;
using static System.Console;

namespace TrocaDeNome
{
    class Program
    {
        static string MudarNome(string nomeMudado, string nomeNovo)
        {
            return nomeMudado = nomeNovo;
        }
        static void Main(string[] args)
        {
            Write("------ATUALIZAÇÃO DE NOME------");
            Pessoa pessoa = new Pessoa();
            Write("\nInsira seu antigo nome: ");
            pessoa.Nome = ReadLine();
            Write("Insira sua idade: ");
            pessoa.Idade = int.Parse(ReadLine());
            Write("Insira seu documento: ");
            pessoa.Documento = ReadLine();
            string nomeNovo = pessoa.Nome;
            if (pessoa.Idade >= 18)
            {
                Write("Qual o seu nome? ");
                nomeNovo = ReadLine();
                Clear();
            }
            else
            {
                Write("Seus pais permitem esta atualização de nome? (S/N)");
                string resposta = ReadLine();
                if (resposta.ToUpper() == "S")
                {
                    Write("Qual o seu nome? ");
                    nomeNovo = ReadLine();
                    Clear();
                }
                else
                {
                    Clear();
                    Write("Desculpe, não será possível alterar seu nome.\n");
                    
                }
            }
            
            Write($@"NOME: {MudarNome(pessoa.Nome, nomeNovo)}
IDADE: {pessoa.Idade}
DOCUMENTO: {pessoa.Documento}");
        }
    }
}
