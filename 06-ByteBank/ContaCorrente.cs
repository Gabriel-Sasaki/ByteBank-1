namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 100;

        // Isso é uma propriedade, portanto não recebe argumento diretamente e a letra fica em maiúsculo
        // Definindo o Get e o Set do campo "saldo"
        // O "value" no set representa o valor obtido como argumento
        // No get não é preciso informar o tipo de retorno pois ele usa o tipo do próprio campo "saldo"
        public double Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        // Verifica se o saldo disponível na conta é suficiente para sacar o valor escolhido. Se sim o processo é feito
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;

        }

        // Deposita o valor escolhido no saldo da conta
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        // Verifica se o saldo disponível na contaé suficiente para transferir. Se sim ele deposita o valor na conta destino e remove da conta original
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }
    }
}




