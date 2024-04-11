namespace ContaCorrente.ConsoleApp
{
    public class Cliente
    {
        private string nome;
        private string sobrenome;
        private string cpf;

        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
    }
}
