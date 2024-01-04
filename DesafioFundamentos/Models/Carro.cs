using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Carro:Estacionamento
    {
        public Carro(decimal precoInicialParaCarro, decimal precoPorHoraParaCarro): base(precoInicialParaCarro, precoPorHoraParaCarro){

        }
    }
}