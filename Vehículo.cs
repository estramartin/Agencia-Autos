using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_Autos
{
    [Serializable]
    class Vehículo: IComparable
    {
       
        private bool disponible, conchofer;
        private string patente, marca, modelo, tipocombustible, imagen;
        private int capacidad, unidadDeCobro, kms, precioAlquiladoEnUDC;
        //public static int ordenar;
       

        public Vehículo(bool disponible, bool chofer, string patente, string marca, string modelo, string combustible, string path, int capacidad, int unidadCobro,int kms) {


            this.Disponible = disponible;
            this.Conchofer = chofer;
            this.Patente = patente;
            this.Marca = marca;
            this.Modelo = modelo;
            Tipocombustible = combustible;
            Imagen = path;
            this.Capacidad = capacidad;
            this.unidadDeCobro = unidadCobro;
            this.kms = kms;
        
        }

        public bool Disponible { get => disponible; set => disponible = value; }
        public bool Conchofer { get => conchofer; set => conchofer = value; }
        public string Patente { get => patente; set => patente = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Tipocombustible { get => tipocombustible; set => tipocombustible = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public int UnidadDeCobro { get => unidadDeCobro; set => unidadDeCobro = value; }
        public int Kms { get => kms; set => kms = value; }
        public int PrecioAlquiladoEnUDC { get => precioAlquiladoEnUDC; set => precioAlquiladoEnUDC = value; }

        public string GetVehiculo() {           

            return marca + " " + modelo + " " + tipocombustible + " " + patente + " " + capacidad+ " "+kms; 
        
        }
               
        public int CompareTo(object obj) {


            return Marca.CompareTo(((Vehículo)obj).Marca);
           /* switch (ordenar) {

                case 0: { return Marca.CompareTo(((Vehículo)obj).Marca);  }
                case 1: { return Capacidad.CompareTo(((Vehículo)obj).Capacidad); }
                case 2: { return tipocombustible.CompareTo(((Vehículo)obj).tipocombustible); }
                default: return -1;
            }
        */
        
        }
        
    }
}
