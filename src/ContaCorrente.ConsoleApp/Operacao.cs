using System.Runtime.CompilerServices;

namespace ContaCorrente.ConsoleApp
{
    public class Operacao
    {
        private string tipoDeOperacao;

        public string getTiPoDeOperacao()
        {
            return tipoDeOperacao;
        }

        public void setTipoDeOperacao(string tipoDeOperacao)
        {
            this.tipoDeOperacao = tipoDeOperacao;
        }

        public void VerificaTipoOperacao(Operacao operacao, Conta conta)
        {
            if ((operacao.getTiPoDeOperacao() == "4"))
            {
                Console.WriteLine("Saldo: " + conta.getSaldo());
                Console.WriteLine("Conta: " + conta.getNumero());
            }
        }
    }
}
