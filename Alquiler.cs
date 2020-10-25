using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Autos
{
    class Alquiler
    {
        private Persona cliente;
        private Vehículo vehiculo;
        private int cantAcompañantes = 0;
        private Persona[] acompañantes = new Cliente[3];
        private int diasDeAlquiler;
        private DateTime inicioAlquiler;

        public Alquiler(Persona cliente) {


            this.cliente = cliente;

            
        }

        public Vehículo Auto {

            get { return vehiculo; }
            set { vehiculo = value; }
        
        }

        public DateTime InicioAlquiler
        {
            get { return inicioAlquiler; }
            set { inicioAlquiler = value; }
        
        }

        public int DiasDeAlquiler
        {
            get { return diasDeAlquiler; }
            set { diasDeAlquiler = value; }

        }


        public Persona getClinete() {


            return cliente;
        }


        public Vehículo GetVehículo() {

            return vehiculo;
        
        }

        public void agregarConductores(Persona cliente) {



            acompañantes[cantAcompañantes] = cliente;
            cantAcompañantes++;


               
        }

        public Persona [] getAcompañantes() {


            return acompañantes;
        
        }



    }
}
