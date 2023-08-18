using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    class COmnibus:CTransportePublico
    {
        public COmnibus():base()
        {
            this.limite = 45;
        }
        public override bool AgregarPasajero(int pasajeros)
        {
            if (pasajeros > this.limite) return false;
            if (this.pasajeros + pasajeros>this.limite)return false;
            this.pasajeros += pasajeros;
            return true;
        }
        public override string ToString()
        {
            return "vehiculo:Omnibus,cantidad pasajeros: "+this.pasajeros.ToString();
        }
    }
}
