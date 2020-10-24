﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Autos
{
    class Administracion
    {

        List<Persona> Usuario = new List<Persona>();
        List<Alquiler> alquilerVigente = new List<Alquiler>();
        List<Vehículo> vehículos = new List<Vehículo>();
        List<Vehículo> vehículoConChofers = new List<Vehículo>();

        Alquiler unAlquiler;
        /* public Administracion(Alquiler unAlquiler, Historico unHistorico, Empresa unaEmpresa) {






         }*/

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

           
            alquilerVigente.Add(unAlquiler);
        
        }

        public void Devolucion() {
        
        

        
        
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
