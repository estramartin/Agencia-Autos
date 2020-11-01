using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Autos
{
    [Serializable]
    class Alquiler
    {
        private Persona cliente;
        private Vehículo vehiculo;
        private int cantAcompañantes = 0;
        private Persona[] acompañantes = new Cliente[2];
        private int diasDeAlquiler;
        private DateTime inicioAlquiler;
        

        public Alquiler(Persona cliente) {


            this.cliente = new Cliente(((Cliente)cliente).Nombre, ((Cliente)cliente).Dni, ((Cliente)cliente).Cuit, ((Cliente)cliente).Direccion, ((Cliente)cliente).Telefono, ((Cliente)cliente).Fechanac, ((Cliente)cliente).Estadocivil, ((Cliente)cliente).Nacionalidad, ((Cliente)cliente).Carnet);
            
            
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
