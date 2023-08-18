using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    class CTaxi:CTransportePublico
    {
        public CTaxi() 
        {
            this.limite = 3;
        }
        public override bool AgregarPasajero(int pasajeros) 
        {
            if (this.pasajeros > 0) return false;
            if(pasajeros > this.limite)return false;

            this.pasajeros = pasajeros;
            return true;
        }
        public override string ToString()
        {
            return "vehiculo:taxi,cantidad pasajeros: "+this.pasajeros.ToString();
        }

    }
}
