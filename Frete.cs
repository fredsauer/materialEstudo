\\PROGRAMA REFATORADO POR FREDERICO LEITE SAUER EM ATIVIDADE PARA FAETERJ-RIO

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.LojaTav2021.Model
{
    public class Frete
    {
        public int idFrete { get; set; }
        public string paisDestino { get; set; }
        public int cep { get; set; }
        public double valorFrete { get; set; }
    }
}
