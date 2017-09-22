using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderC.Diagrama
{
     abstract class MotoBuilder
    {
        protected Moto moto;

        // Gets vehicle instance
        public Moto Moto
        {
            get { return moto; }
        }

        public abstract void construirMotor();
        public abstract void construirCarroceria();
        public abstract void construirRuedas();

    }
}
