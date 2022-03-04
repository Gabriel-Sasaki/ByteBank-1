namespace _07_ByteBank
{
    public class ContaCorrente
    {
// PROPRIEDADES E ATRIBUTOS

        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        private int _agencia;

        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            } 
        }
        public int Numero { get; set; }

        private double _saldo = 100;

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

// CONSTRUTORES

        // O construtor da ContaCorrente, onde obriga a informar o valor da agencia e do número no main. Ele também incrementa o total de contas criadas de um em um toda vez que o construtor é chamado
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

// MÉTODOS E FUNÇÕES

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




