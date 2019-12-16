using System;

using _50minutos_biblioteca;

namespace _50minutos_facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Homem.SacarDinheiro();
            Console.ReadKey();
        }
    }
}

//Library
namespace _50minutos_biblioteca
{
    //SubsystemA
    internal class Pessoa
    {
        internal void Ir(String paraOnde)
        {
            Console.WriteLine("chegou: ", paraOnde);
        }

        internal void PassarCartao()
        {
            Console.WriteLine("passou o cartão");
        }

        internal void DigitarSenha()
        {
            Console.WriteLine("digitou a senha");
        }

        internal void PegarDinheiro()
        {
            Console.WriteLine("pegou o dinheiro");
        }
    }

    //SubsystemB
    internal class Carteira
    {
        internal void Abrir()
        {
            Console.WriteLine("carteira aberta");
        }

        internal void Fechar()
        {
            Console.WriteLine("carteira fechada");
        }

        internal void Pegar()
        {
            Console.WriteLine("carteira na mão");
        }

        internal void Guardar(String onde)
        {
            Console.WriteLine("carteira guardada: ", onde);
        }

        internal void PegarCartao(String qual)
        {
            Console.WriteLine("cartão na mão: ", qual);
        }

        internal void GuardarCartao()
        {
            Console.WriteLine("cartão na carteira");
        }
    }

    //Facade
    public static class Homem
    {
        //SubsystemA
        static Carteira carteira = new Carteira();

        //SubsystemB
        static Pessoa pessoa = new Pessoa();

        //Operation1
        public static void SacarDinheiro()
        {
            pessoa.Ir("caixa eletrônico");
            carteira.Abrir();
            carteira.PegarCartao("débito");
            pessoa.PassarCartao();
            pessoa.DigitarSenha();
            pessoa.PegarDinheiro();
            carteira.GuardarCartao();
            carteira.Guardar("bolso");
            pessoa.Ir("casa");
        }
    }
}
