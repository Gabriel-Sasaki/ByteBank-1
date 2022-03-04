namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        // Verifica se o saldo disponível na conta é suficiente para sacar o valor escolhido. Se sim o processo é feito
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;

        }

        // Deposita o valor escolhido no saldo da conta
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        // Verifica se o saldo disponível na contaé suficiente para transferir. Se sim ele deposita o valor na conta destino e remove da conta original
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }
    }
}




