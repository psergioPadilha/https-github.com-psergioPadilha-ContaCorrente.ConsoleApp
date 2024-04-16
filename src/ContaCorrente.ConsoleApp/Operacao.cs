namespace ContaCorrente.ConsoleApp
{
    public class Operacao
    {
        Movimentacao movimentacoes = new Movimentacao();
        public List<Movimentacao> listMovimentacoes = new List<Movimentacao>();
        private string tipoDeOperacao;

        public string getTipoDeOperacao()
        {
            return tipoDeOperacao;
        }

        public void setTipoDeOperacao(string tipoDeOperacao)
        {
            this.tipoDeOperacao = tipoDeOperacao;
        }

        public void VerificaTipoOperacao(Operacao operacao, Conta[] contas)
        {
            if (operacao.getTipoDeOperacao() == "1")
            {
                Apresentacao apresentacao = new Apresentacao();
                apresentacao.Menu();

                Console.WriteLine("Informe o número da conta e o valor do saque!");
                Console.WriteLine();
                Console.Write("Conta: ");
                int consultaNumeroConta = int.Parse(Console.ReadLine());

                for (int i = 0; i < contas.Length; i++)
                {
                    if (consultaNumeroConta == contas[i].getNumero())
                    {
                        Console.Write("Valor R$: ");
                        decimal valorDoSaque = decimal.Parse(Console.ReadLine());
                        while (!VerificaSaldoLimiteDisponivel(contas[i], valorDoSaque))
                        {
                            Console.Write("Limite insuficiente para realizar a operação...");
                            Console.WriteLine();
                            Console.Write("Valor R$: ");
                            valorDoSaque = decimal.Parse(Console.ReadLine());
                        }
                        OperacaoSaque(contas[i], valorDoSaque);
                    }
                }
            }
            if (operacao.getTipoDeOperacao() == "2")
            {

            }
            if (operacao.getTipoDeOperacao() == "3")
            {

            }
            if (operacao.getTipoDeOperacao() == "4")
            {
                Apresentacao apresentacao = new Apresentacao();
                apresentacao.Menu();

                Console.WriteLine("Informe o número da conta!");
                Console.WriteLine();
                Console.Write("Conta: ");

                int consultaNumeroConta = int.Parse(Console.ReadLine());

                for (int i = 0; i < contas.Length; i++)
                {
                    if (consultaNumeroConta == contas[i].getNumero())
                    {
                        OperacaoConsultaSaldo(contas[i]);
                    }
                }

            }
            if (operacao.getTipoDeOperacao() == "5")
            {
                Apresentacao apresentacao = new Apresentacao();
                apresentacao.Menu();

                Console.WriteLine("Informe o número da conta!");
                Console.WriteLine();
                Console.Write("Conta: ");

                int consultaNumeroConta = int.Parse(Console.ReadLine());

                for (int i = 0; i < contas.Length; i++)
                {
                    if (consultaNumeroConta == contas[i].getNumero())
                    {
                        OperacaoConsultaExtrato(contas[i]);
                    }
                }
            }
        }

        public void OperacaoSaque(Conta conta, decimal valorDoSaque)
        {
            if (valorDoSaque <= conta.getSaldo())
            {
                conta.setSaldo(conta.getSaldo() - valorDoSaque);
            }
            else if (valorDoSaque <= conta.getSaldo() + conta.getLimite())
            {
                decimal aux = valorDoSaque - conta.getSaldo();
                conta.setSaldo(conta.getSaldo() - conta.getSaldo());
                conta.setLimite(conta.getLimite() - aux);
            }

            listMovimentacoes.Add(new Movimentacao()
            {
                numeroConta = conta.getNumero(),
                tipoMovimentacao = "SAQUE",
                valorMovimentacao = valorDoSaque.ToString(),
                saldoConta = conta.getSaldo(),
            });

            Console.WriteLine("A quantidade de elementos da lista é " + listMovimentacoes.Count());
            foreach (Movimentacao movimentacao in listMovimentacoes)
            {
                Console.WriteLine("Tipo Movimentação: " + movimentacao.getTipoMovimentacao());
                Console.WriteLine("Valor Movimentação: R$" + movimentacao.getValorMovimentacao());
                Console.WriteLine("Saldo restante da conta: R$" + movimentacao.getSaldoConta());
                Console.WriteLine("----------------------------------------");
            }
        }

        static void OperacaoConsultaSaldo(Conta conta)
        {
            Apresentacao apresentacao = new Apresentacao();
            apresentacao.Menu();

            Console.WriteLine("Cliente: " + conta.cliente.getNome());
            Console.WriteLine("Conta: " + conta.getNumero());
            Console.WriteLine("CPF: " + conta.cliente.getCpf());
            Console.WriteLine("Saldo: R$" + conta.getSaldo());
            Console.WriteLine("Limite: R$" + conta.getLimite());
        }

        public void OperacaoConsultaExtrato(Conta conta)
        {
            Apresentacao apresentacao = new Apresentacao();
            apresentacao.Menu();

            Console.WriteLine("Extrato de conta para conferência!");
            Console.WriteLine();
            Console.WriteLine("Conta Nº" + conta.getNumero());
            Console.WriteLine("***********************************");
            Console.WriteLine();

            Console.WriteLine("A quantidade de elmentos da lista é " + listMovimentacoes.Count());
            foreach (Movimentacao movimentacao in listMovimentacoes)
            {
                if (movimentacao.getNumeroConta() == conta.getNumero())
                {
                    Console.WriteLine("Tipo Movimentação: " + movimentacoes.getTipoMovimentacao());
                    Console.WriteLine("Valor Movimentação: R$" + movimentacoes.getValorMovimentacao());
                    Console.WriteLine("Saldo restante da conta: R$" + movimentacoes.getSaldoConta());
                    Console.WriteLine("----------------------------------------");
                }
            }
        }

        static bool VerificaSaldoLimiteDisponivel(Conta conta, decimal valorDoSaque)
        {
            if (conta.getSaldo() + conta.getLimite() <= valorDoSaque)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
