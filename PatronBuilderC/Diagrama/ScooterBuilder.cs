using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderC.Diagrama
{
    class ScooterBuilder : MotoBuilder
    {
        public ScooterBuilder()
        {
            moto = new Moto("Scooter");
        }

        public override void construirCarroceria()
        {
            moto["carroceria"] = "Hierro";
        }

        public override void construirMotor()
        {
            moto["motor"] = "50cc";
        }

        public override void construirRuedas()
        {
            moto["ruedas"] = "Rodado 14";
        }
    }
}
