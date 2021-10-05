using Api.LojaTav2021.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.LojaTav2021.Model
{
    public class Entrega : IEntrega
    {
        public int idEntrega { get; set; }
        public int idPais { get; set; }
        public int idEndereco { get; set; }
        public DateTime agendamento { get; set; }
        public bool ValidaEntrega(IEntrega entrega)
        {
            return true;
        }
    }
}
