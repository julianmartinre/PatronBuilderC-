using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderC.Diagrama
{
    class Concecionaria
    {
        public void Construct(MotoBuilder motoBuilder)
        {
            motoBuilder.construirMotor();
            motoBuilder.construirCarroceria();
            motoBuilder.construirRuedas();
        }
    }
}
