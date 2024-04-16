using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ContaCorrente.ConsoleApp
{
    public class Cliente
    {
        private string nome;
        private string cpf;


        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getCpf()
        {
            return cpf;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
    }
}
