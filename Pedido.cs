//CODIGO REFATORADO POR FREDERICO LEITE SAUER EM ATIVIDADE PARA FAETERJ-RIO

using Api.LojaTav2021.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.LojaTav2021.Model
{
    public class Pedido
    {
        public int id { get; set; }
        public int idCliente { get; set; }
        public int idPais { get; set; }
        public int idEntrega { get; set; }
        public double valorTotal { get; set; }
        public ICliente Cliente { get; }
        public IFrete Frete { get; }

        public Pedido(int _id, int _cliente, int _idPais, int _idEntrega, double _valorTotal)
        {
            id = _id;
            idCliente = _cliente;
            idPais = _pais;
            idEntrega = _idEntrega;
            valorTotal = _valorTotal;
        }

        public Pedido(int _id, int _idCliente, int _idPais, ICliente cliente, IFrete frete, int _idEntrega, double _valorTotal)
        {
            id = _id;
            Cliente = cliente;
            idPais = _idPais;
            idCliente = _idCliente;
            Frete = frete;
            idEntrega = _idEntrega;
            valorTotal = _valorTotal;
        }

        public bool ValidaEntrega(IEntrega entrega)
        {
            if (entrega == null || idEntrega < 1)
            {
                return false;
            }
            return true;
        }
        public double CalcularFrete()
        {
            int cep = Cliente.getCepById(idCliente);
            double valorFrete = Frete.GetValorFrete(cep);
            return valorFrete;
        }
    }
}
