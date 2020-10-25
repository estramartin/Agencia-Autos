using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Autos   
{
    [Serializable]
    class VehículoConChofer:Vehículo
    {


        private int viaticos = 140;
        private Persona unChofer;

        public VehículoConChofer(bool disponible, bool chofer, string patente, string marca, string modelo, string combustible, string path, int capacidad, Persona chof, int unidadDeCobro, int kms) : base(disponible, chofer, patente, marca, modelo, combustible, path, capacidad, unidadDeCobro, kms) {



            unChofer = new Chofer(((Chofer)chof).Nombre, ((Chofer)chof).Dni, ((Chofer)chof).Cuit, ((Chofer)chof).Direccion, ((Chofer)chof).Telefono, ((Chofer)chof).Fechanac, ((Chofer)chof).Estadocivil, ((Chofer)chof).Nacionalidad, ((Chofer)chof).Carnet);

           
        
        }


        public int Viaticos { get => viaticos; set => viaticos = value; }

        public Persona UnChofer { get => unChofer; set => unChofer = value; }


    }



    
}
