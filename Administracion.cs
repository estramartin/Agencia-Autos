﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_Autos
{
    [Serializable]
    class Administracion
    {
        public static double pesos; 
        List<Persona> Usuario = new List<Persona>();
        List<Alquiler> alquilerVigente = new List<Alquiler>();
        List<Vehículo> vehículos = new List<Vehículo>();
        List<Vehículo> vehículoConChofers = new List<Vehículo>();
        Historico historico = new Historico();
        Empresa unaEmpresa;
       // Alquiler unAlquiler;
         public Administracion(Empresa unaEmpresa) {

            this.unaEmpresa = unaEmpresa;




         }

        public void agregarVehiculo(Vehículo v) {

            if (v.Conchofer == false) {

                vehículos.Add(v);
            
            
            }
            else
            {
                vehículoConChofers.Add(v);
            }    
        
        }

        public void agregarUsuario(Persona usuario) {
            
            Usuario.Add(usuario);
        
        
        }
        public void CargarAlquiler(Alquiler unAlquiler) {

            Alquiler alquiler = new Alquiler(unAlquiler.getClinete());

            alquiler = unAlquiler;

            alquilerVigente.Add(alquiler);
        
        }

        public double Devolucion(int pos, int kms, ListBox lbAlquileres, DateTime finalizar) {

            double preciofinal = 0;
            double aCobrar = 0;
           // DateTime finalizar = DateTime.Now; //tiempo exacto en el que termina el alquiler
            int horaDevolucion = finalizar.Hour;          //hora de finalizacion
            int mindevolucion = finalizar.Minute;
            TimeSpan periodoAlquiler = alquilerVigente[pos].InicioAlquiler.Subtract(finalizar); // intervalo en el que el vehiculo permanecio alquilado

            int kilometrosPermitidos = 500;
           
            int diasalquilados = periodoAlquiler.Days;
            double diasdealquiler = periodoAlquiler.TotalDays;
            if (diasalquilados < 1) diasalquilados = 1;

            int recorrido = kms - alquilerVigente[pos].Auto.Kms;

            int recorridoPermitido = diasalquilados * kilometrosPermitidos;

            if ((diasalquilados <= alquilerVigente[pos].DiasDeAlquiler) && (recorrido <= recorridoPermitido))
            {
               
                aCobrar = diasalquilados * alquilerVigente[pos].Auto.UnidadDeCobro; //Sin Multa
            }
            if ((diasalquilados <= alquilerVigente[pos].DiasDeAlquiler) && (recorrido > recorridoPermitido)) {

                int exedente = recorrido - recorridoPermitido;
                              
                if (exedente <= 100) aCobrar = (diasalquilados * alquilerVigente[pos].Auto.UnidadDeCobro) + (exedente * 3); // multa medos de 100kms
                else aCobrar = (diasalquilados * alquilerVigente[pos].Auto.UnidadDeCobro) + (exedente * 5); // multa mas de 100kms

            }

            if((diasalquilados > alquilerVigente[pos].DiasDeAlquiler)&& (recorrido <= recorridoPermitido)){

                double exedente = diasdealquiler - alquilerVigente[pos].DiasDeAlquiler;
                exedente = Math.Ceiling(exedente);

                aCobrar = (alquilerVigente[pos].DiasDeAlquiler * alquilerVigente[pos].Auto.UnidadDeCobro) + (exedente * alquilerVigente[pos].Auto.UnidadDeCobro * 1.1);
            }
            if ((diasalquilados > alquilerVigente[pos].DiasDeAlquiler) && (recorrido > recorridoPermitido)) {
                int multa = 0;
                
                int exedenteKms = recorrido - recorridoPermitido;
               if (exedenteKms <= 100) multa = (diasalquilados * alquilerVigente[pos].Auto.UnidadDeCobro) + (exedenteKms * 3); // multa medos de 100kms
                else multa = (diasalquilados * alquilerVigente[pos].Auto.UnidadDeCobro) + (exedenteKms * 5); // multa mas de 100kms
                
                double exedenteDias = diasdealquiler - alquilerVigente[pos].DiasDeAlquiler;

                aCobrar = (diasalquilados * alquilerVigente[pos].Auto.UnidadDeCobro)+ multa+ (exedenteDias * alquilerVigente[pos].Auto.UnidadDeCobro * 1.1);

            }

            if (alquilerVigente[pos].Auto.Conchofer == false) preciofinal = aCobrar * pesos;
            else {
                aCobrar = aCobrar + Chofer.viatico;
                preciofinal = aCobrar* pesos;


            }

           // historico.agregarAlHistorico(alquilerVigente[pos]);
            alquilerVigente[pos].Auto.Kms = kms;
            alquilerVigente[pos].Auto.Disponible = true;
            

            alquilerVigente.RemoveAt(pos);

            lbAlquileres.Items.Clear();

            foreach (Alquiler a in alquilerVigente) {

                lbAlquileres.Items.Add(a.getClinete() +" "+ GetVehículos()) ;
            
            }

            return preciofinal;




        }

        public List<Vehículo> GetVehículos() {

            return vehículos;
        
        }
        public List<Vehículo> GetVehiculosConChofer() {

            return vehículoConChofers;
        
        }

        public List<Persona> GetUsuario()
        {

            return Usuario;

        }

        public List<Alquiler> GetAlquileres() {


            return alquilerVigente;
        
        }




    }
}
