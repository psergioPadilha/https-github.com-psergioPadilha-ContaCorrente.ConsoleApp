using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;

namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta[] contas = new Conta[3];

            contas[0] = new Conta();
            contas[0].cliente.setNome("PAULO SERGIO PADILHA");
            contas[0].cliente.setCpf("028.140.739-82");
            contas[0].setNumero(100);
            contas[0].setSaldo(100.00m);
            contas[0].setStatus(true);
            contas[0].setLimite(500m);

            contas[1] = new Conta();
            contas[1].cliente.setNome("VALÉRIA DEUCHER");
            contas[1].cliente.setCpf("071.548.889-34");
            contas[1].setNumero(101);
            contas[1].setSaldo(155.00m);
            contas[1].setStatus(true);
            contas[1].setLimite(400m);

            contas[2] = new Conta();
            contas[2].cliente.setNome("CAMILA DEUCHER PADILHA");
            contas[2].cliente.setCpf("153.784.359-51");
            contas[2].setNumero(102);
            contas[2].setSaldo(283.00m);
            contas[2].setStatus(true);
            contas[2].setLimite(150m);

            while (true)
            {
                Operacao novaOperacao = new Operacao();
                Conta contaOperacao = new Conta();

                novaOperacao.setTipoDeOperacao(Menu());

                novaOperacao.VerificaTipoOperacao(novaOperacao, contas);

                Console.ReadKey();
            
            }
        }

        static string Menu()
        {
            Apresentacao apresentacao = new Apresentacao();
            apresentacao.Menu();

            Console.WriteLine("Que tipo de operação deseja realizar?");
            Console.WriteLine();
            Console.WriteLine("(1)Saque\n(2)Depósito\n(3)Transferência\n(4)Saldo\n(5)Extrato");
            Console.WriteLine();
            Console.Write("Operação: ");
            return Console.ReadLine();
        }
    }
}
