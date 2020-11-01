using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Autos
{
    [Serializable]
    class Cliente: Persona
    {

             
        private string carnet;
        

        public Cliente(string nombreCompleto, int dni, long cuil, string dir, int tel, DateTime fechanac, string estadoCiv, string nac, string carnet)
        {

             Nombre = nombreCompleto;
            this.Dni = dni;
            this.Cuit = cuil;
            Direccion = dir;
            Telefono = tel;
            this.Fechanac = fechanac;
            Estadocivil = estadoCiv;
            Nacionalidad = nac;
            this.Carnet = carnet;




        }

        
        public string Carnet { get => carnet; set => carnet = value; }

        public override string DatosPersonales()
        {


            return Nombre + " " + Dni + " " + Cuit + " " + Direccion + " " + Telefono + " " + Fechanac + " " + Estadocivil + " " + Carnet;



        }





    }
}
