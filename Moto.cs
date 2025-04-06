using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PTI_POO___Hannah
{
    class Moto:Veiculo
    {
        public override double CalcularValorTotal(int numDiarias)
        {
            Console.Write("Taxa total das diárias: \nR$");
            return TaxaDiaria = 25.00 * numDiarias;
        }
    }
}
