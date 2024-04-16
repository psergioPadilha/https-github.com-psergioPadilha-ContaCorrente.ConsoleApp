using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ContaCorrente.ConsoleApp
{
    public class Movimentacao
    {
        public int numeroConta;
        public string tipoMovimentacao;
        public string valorMovimentacao;
        public decimal saldoConta;

        public int getNumeroConta()
        {
            return numeroConta;
        }

        public void setNumeroConta(int numeroConta)
        {
            this.numeroConta = numeroConta;
        }

        public string getTipoMovimentacao()
        {
            return tipoMovimentacao;
        }

        public void setTipoMovimentacao(string tipoMovimentacao)
        {
            this.tipoMovimentacao = tipoMovimentacao;
        }

        public string getValorMovimentacao()
        {
            return valorMovimentacao;
        }

        public void setValorMovimentacao(string valorMovimentacao)
        {
            this.valorMovimentacao = valorMovimentacao;
        }

        public decimal getSaldoConta()
        {
            return saldoConta;
        }

        public void setSaldoConta(decimal saldoConta)
        {
            this.saldoConta = saldoConta;
        }
    }
}
