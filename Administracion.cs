using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_Autos
{
    [Serializable]
    class Administracion
    {
        private double pesos; 
        public List<Persona> Usuario = new List<Persona>();
        List<Alquiler> alquilerVigente = new List<Alquiler>();
        List<Vehículo> vehículos = new List<Vehículo>();
        List<Vehículo> vehículoConChofers = new List<Vehículo>();
        Historico unHistorico;
        Empresa unaEmpresa;
        Persona unUsuario;

       
        public Administracion(Empresa unaEmpresa, Historico unHistorico)
        {

           
            this.unaEmpresa = unaEmpresa;
            this.unHistorico = new Historico();
            this.unHistorico = unHistorico;
            unUsuario = new Usuario("Supervisor", "supervisar", true);
            Usuario.Add(unUsuario);
            unUsuario = new Usuario("Administrador", "administrar", false);
            Usuario.Add(unUsuario);
        }

        public double Pesos {
            get { return pesos; }
            set { pesos = value; }
        }

        public void agregarVehiculo(Vehículo v) {
            if (v != null)
            {
                if (v.Conchofer == false)
                {

                    vehículos.Add(v);
                    

                }
                else
                {
                    vehículoConChofers.Add(v);
                    
                }
            }
            else throw new NullReferenceException();


        }

        public void agregarUsuario(Persona usuario) {
            
            Usuario.Add(usuario);
        
        
        }
        public void CargarAlquiler(Alquiler unAlquiler) {

            Alquiler alquiler = new Alquiler(unAlquiler.getClinete());

            alquiler = unAlquiler;

            alquilerVigente.Add(alquiler);
        
        }

        public double Devolucion(int pos, int kms, DataGridView lbAlquileres, DateTime finalizar) {

           // paso un parametro DateTime para que no sea siempre valor 1
            
            double preciofinal=0;
            double aCobrar = 0;
           // DateTime finalizar = DateTime.Now; //tiempo exacto en el que termina el alquiler
           
            
            
            TimeSpan periodoAlquiler = finalizar.Subtract(alquilerVigente[pos].InicioAlquiler); // intervalo en el que el vehiculo permanecio alquilado

            if (finalizar < DateTime.Now) {
               
                throw new Exception("Fecha mal ingresada");
            
            }


            int kilometrosPermitidos = 500;
                 
            
                   
            int diasdealquiler =Convert.ToInt32(Math.Ceiling( periodoAlquiler.TotalDays));            
            double diasDeAlquilerEnMintos = periodoAlquiler.TotalMinutes;
            double DiasSolicitadosAMinutos = ((alquilerVigente[pos].DiasDeAlquiler * 1440) - 120);

           

                int recorrido = kms - alquilerVigente[pos].Auto.Kms;
            

            if (recorrido < 0)
            {
                throw new Exception("Error al ingresar el Kilometraje");                

            }
            
            
                int recorridoPermitido = diasdealquiler * kilometrosPermitidos;



                if ((diasDeAlquilerEnMintos <= DiasSolicitadosAMinutos) && (recorrido <= recorridoPermitido))
                {

                    aCobrar = diasdealquiler * alquilerVigente[pos].Auto.PrecioAlquiladoEnUDC; //Sin Multa
                }
            if ((diasDeAlquilerEnMintos <= DiasSolicitadosAMinutos) && (recorrido > recorridoPermitido))
            {


                int exedente = recorrido - recorridoPermitido;

                if (exedente <= 100)
                {


                    aCobrar = (diasdealquiler * alquilerVigente[pos].Auto.PrecioAlquiladoEnUDC) + (exedente * 3);// multa medos de 100kms
                    alquilerVigente[pos].Multa = (exedente * 3) * alquilerVigente[pos].PrecioAlquilado;

                }
                else
                {
                    aCobrar = (diasdealquiler * alquilerVigente[pos].Auto.PrecioAlquiladoEnUDC) + (exedente * 5); // multa mas de 100kms
                    alquilerVigente[pos].Multa = (exedente * 5) * alquilerVigente[pos].PrecioAlquilado;
                }
            }
            if ((diasDeAlquilerEnMintos > DiasSolicitadosAMinutos) && (recorrido <= recorridoPermitido))
            {

                    int exedente = diasdealquiler - alquilerVigente[pos].DiasDeAlquiler;
                    alquilerVigente[pos].Multa = exedente * alquilerVigente[pos].Auto.PrecioAlquiladoEnUDC * 1.1 * alquilerVigente[pos].PrecioAlquilado;

                    aCobrar = (alquilerVigente[pos].DiasDeAlquiler * alquilerVigente[pos].Auto.PrecioAlquiladoEnUDC) + (exedente * alquilerVigente[pos].Auto.PrecioAlquiladoEnUDC * 1.1);

            }
             if ((diasDeAlquilerEnMintos > DiasSolicitadosAMinutos) && (recorrido > recorridoPermitido))
             {
                    double multa = 0;

                    int exedenteKms = recorrido - recorridoPermitido;
                    if (exedenteKms <= 100) multa = (diasdealquiler * alquilerVigente[pos].Auto.PrecioAlquiladoEnUDC) + (exedenteKms * 3); // multa medos de 100kms
                    else multa = (diasdealquiler * alquilerVigente[pos].Auto.PrecioAlquiladoEnUDC) + (exedenteKms * 5); // multa mas de 100kms
                    
                    double exedenteDias = diasdealquiler - alquilerVigente[pos].DiasDeAlquiler;

                    aCobrar = (diasdealquiler * alquilerVigente[pos].Auto.PrecioAlquiladoEnUDC) + multa + (exedenteDias * alquilerVigente[pos].Auto.PrecioAlquiladoEnUDC * 1.1);
                     alquilerVigente[pos].Multa = (multa * (exedenteDias * alquilerVigente[pos].Auto.PrecioAlquiladoEnUDC * 1.1)* alquilerVigente[pos].PrecioAlquilado);
            }

                if (alquilerVigente[pos].Auto.Conchofer == false) preciofinal = aCobrar * alquilerVigente[pos].PrecioAlquilado;
                else
                {
                    aCobrar = aCobrar + (Chofer.viatico * diasdealquiler);
                    preciofinal = aCobrar * alquilerVigente[pos].PrecioAlquilado;


                }
  
                unHistorico.IngrearAlquiler(alquilerVigente[pos]);
                alquilerVigente[pos].Auto.Kms = kms;
                alquilerVigente[pos].Auto.Disponible = true;


                alquilerVigente.RemoveAt(pos);

                lbAlquileres.Rows.Clear();

                foreach (Alquiler a in alquilerVigente)
                {

                    lbAlquileres.Rows.Add(a.getClinete().Nombre + " " + a.getClinete().Dni + " " + a.getClinete().Telefono + " " + Convert.ToString(a.getAcompañantes().Length) + " " + a.Auto.Marca + " " + a.Auto.Patente + " " + a.Auto.Kms);

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

        public Historico VerHistorico() {

            return unHistorico;
        
        }
        public Empresa GetEmpresa()
        {

            return unaEmpresa;

        }

    }
}
