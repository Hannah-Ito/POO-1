using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PTI_POO___Hannah
{
    public abstract class Veiculo
    {
        //atributos
        protected double TaxaDiaria { get; set; }
        //métodos

        public abstract double CalcularValorTotal(int numDiarias);
    }
}
