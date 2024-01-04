using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Moto:Estacionamento
    {
        public Moto(decimal precoInicialParaMoto, decimal precoPorHoraParaMoto): base(precoInicialParaMoto, precoPorHoraParaMoto){

        }
    }
}