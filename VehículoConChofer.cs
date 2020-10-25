using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Autos
{
    class VehículoConChofer:Vehículo
    {


        private int viaticos = 140;
        private Persona unChofer;

        public VehículoConChofer(bool disponible, bool chofer, string patente, string marca, string modelo, string combustible, string path, int capacidad, Persona chof, int unidadDeCobro,int kms) : base(disponible, chofer, patente, marca, modelo, combustible, path, capacidad,unidadDeCobro,kms) {


           
            unChofer = chof;

           
        
        }


        public int Viaticos { get => viaticos; set => viaticos = value; }

        public Persona UnChofer { get => unChofer; set => unChofer = value; }


    }



    
}
