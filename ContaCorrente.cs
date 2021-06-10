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
        private double saldoPrivado = 100;


        // Propriedade Saldo
        public double Saldo
        {
            get
            {
                // O [saldo] é um campo privado que pode ser usado em uma propriedade.
                return saldoPrivado;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                saldoPrivado = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (saldoPrivado < valor)
            {
                return false;
            }
            saldoPrivado -= valor;
            return true;
        }


        //Void, pois a função não tem retorno
        public void Depositar(double valor)
        {
            saldoPrivado += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldoPrivado < valor)
            {
                return false;
            }
            saldoPrivado -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}