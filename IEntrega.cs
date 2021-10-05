// PROGRAMA REFATORADO POR FREDERICO LEITE SAUER PARA ATIVIDADE NA FAETERJ-RIO

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.LojaTav2021.Interfaces
{
    public interface IEntrega
    {
        public bool ValidaEntrega(IEntrega entrega);
    }
}
