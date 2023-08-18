using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    abstract class CTransportePublico
    {
        protected int pasajeros { get; set; }
        protected int limite { get;set; }
        private bool enMovimiento { get;set; }  
        
        public CTransportePublico() 
        {
            this.pasajeros = 0;
        }
        public void Avanzar()
        {
            this.enMovimiento=true;
        }
        public void Detenerse()
        {
            this.enMovimiento = false;
        }
        public int CantidadPasajeros()
        {
            return this.pasajeros;
        }
        public abstract bool AgregarPasajero(int pasajero);
    }
}
