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

             
        private long carnet;
        

        public Cliente(string nombreCompleto, int dni, long cuil, string dir, int tel, DateTime fechanac, string estadoCiv, string nac, long carnet)
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

        public string Nombre { get => nombre; set => nombre = value; }
        public int Dni { get => dni; set => dni = value; }
        public long Cuit { get => cuit; set => cuit = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public DateTime Fechanac { get => fechanac; set => fechanac = value; }
        public string Estadocivil { get => estadocivil; set => estadocivil = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public long Carnet { get => carnet; set => carnet = value; }

        public override string DatosPersonales()
        {


            return Nombre + " " + Dni + " " + Cuit + " " + Direccion + " " + Telefono + " " + Fechanac + " " + Estadocivil + " " + Carnet;



        }





    }
}
