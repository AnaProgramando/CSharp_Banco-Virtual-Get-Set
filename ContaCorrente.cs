using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_BancoVirtualGetSet
{
    public class ContaCorrente
    {
        public Cliente Titular {get; set;}
        public int Agencia { get; set; }
        public int NumConta { get; set; }

        //Valor padrão do saldo inicial da conta é de 100 e não 0
        private double _saldo = 100;


        // Propriedade Saldo
        public double Saldo
        {
            get
            {
                // O [saldo] é um campo privado que pode ser usado em uma propriedade.
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

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            return true;
        }


        //Void, pois a função não tem retorno
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

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
