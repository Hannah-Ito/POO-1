using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTI_POO___Hannah
{
    class Carro:Veiculo
    {
        
        public override double CalcularValorTotal(int numDiarias)
        {
            Console.Write("Taxa total das diárias: \nR$");
            return TaxaDiaria = 50.00 * numDiarias;
        }
    }
}
