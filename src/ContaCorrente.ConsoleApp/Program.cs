using System.ComponentModel.Design;

namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.setCliente("PAULO SERGIO PADILHA");
            conta.setCpf("028.140.739-82");
            conta.setNumero(50199);
            conta.setSaldo(100);
            conta.setStatus(true);
            conta.setLimite(500);


            while (true)
            {
                Operacao novaOperacao = new Operacao();
                novaOperacao.setTipoDeOperacao(Menu());

                conta.setNumero(SubMenu());

                novaOperacao.VerificaTipoOperacao(novaOperacao, conta);


                Console.ReadKey();
            }
        }

        static void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("****   BANCO DO PROGRAMADOR   ****");
            Console.WriteLine("**********************************");
            Console.WriteLine();
        }

        static string Menu()
        {
            Cabecalho();
            Console.WriteLine("Que tipo de operação deseja realizar?");
            Console.WriteLine();
            Console.WriteLine("(1)Saque\n(2)Depósito\n(3)Transferência\n(4)Saldo\n(5)Extrato");
            Console.WriteLine();
            Console.Write("Operação: ");
            return Console.ReadLine();
        }

        static int SubMenu()
        {
            Cabecalho();
            Console.WriteLine("Digite o número da conta!");
            Console.WriteLine();
            Console.Write("Conta: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
