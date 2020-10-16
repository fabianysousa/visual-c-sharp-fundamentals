using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Conta
    {
        public int numero;
        public float saldo;
        public float conta;
        public Cliente cliente;
        public void criarPedido(int numero, float saldo, Cliente cliente)
        {
            this.numero = numero;
            this.saldo = saldo;
            this.cliente = cliente;

        }

        public void depositar(float valor) 
        {
            this.saldo = valor;
        }

        public Boolean sacar(float valor)
        {
            if(this.saldo >= valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
