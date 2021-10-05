//PROGRAMA REFATORADO POR FREDERICO LEITE SAUER PARA ATIVIDADE NA FAETERJ-RIO

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.LojaTav2021.Model
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string paisOrigem { get; set; }
        public string endereco { get; set; }
        public int cep { get; set; }
    }
}
