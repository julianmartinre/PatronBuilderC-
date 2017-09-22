using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderC.Diagrama
{
    class PisteroBuilder : MotoBuilder
    {
        public PisteroBuilder()
        {
            moto = new Moto("Pistero");
        }

        public override void construirCarroceria()
        {
            moto["carroceria"] = "Carbono";
        }

        public override void construirMotor()
        {
            moto["motor"] = "500cc";
        }

        public override void construirRuedas()
        {
            moto["ruedas"] = "Rodado 19";
        }
    }
}
