using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Autos
{
    [Serializable]
    class Chofer : Persona, IGuardar
    {

        public static int viatico = 140;

        protected long carnet;
        private string linea;
        public Chofer(string nombreCompleto, int dni, long cuil, string dir, int tel, DateTime fechanac, string estadoCiv, string nac, long carnet)
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

            linea = Nombre + ";" + Dni + ";" + Cuit + ";" + Direccion + ";" + Telefono + ";" + Fechanac + ";" + Estadocivil + ";" + Carnet;


        }

       
        public long Carnet { get => carnet; set => carnet = value; }

        public override string DatosPersonales()
        {

            
            return "Chofer: "+Nombre +" - Carnet: "+ Carnet+ "- Telefono: "+ Telefono;



        }

        public void GrabarCSV(string nombreArchivo)
        {
            FileStream Archivo;



            if (File.Exists(nombreArchivo))
            {
                Archivo = new FileStream(nombreArchivo, FileMode.Append, FileAccess.Write);
            }
            else { 
                Archivo = new FileStream(nombreArchivo, FileMode.CreateNew, FileAccess.Write);
            }

             StreamWriter escribir = new StreamWriter(Archivo);
            
            escribir.WriteLine(linea);
            escribir.Close();
            Archivo.Close();
            

        }



    }
}
