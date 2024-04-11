namespace ContaCorrente.ConsoleApp
{
    public class Conta
    {
        private int numero;
        private string cliente;
        private string cpf;
        private decimal saldo;
        private bool status;
        private decimal limite;

        public int getNumero()
        {
            return numero;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public string getCliente()
        {
            return cliente;
        }

        public void setCliente(string cliente)
        {
            this.cliente = cliente;
        }

        public string getCpf()
        {
            return cpf;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public decimal getSaldo()
        {
            return saldo;
        }

        public void setSaldo(decimal saldo)
        {
            this.saldo = saldo;
        }

        public bool getStatus()
        {
            return status;
        }

        public void setStatus(bool status)
        {
            this.status = status;
        }

        public decimal getLimite()
        {
            return limite;
        }

        public void setLimite(decimal limite)
        {
            this.limite = limite;
        }
    }
}
