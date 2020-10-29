using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Agencia_Autos
{
    [Serializable]
    class Historico: IGuardar
    {

        List<Alquiler> historico = new List<Alquiler>();


        public void IngrearAlquiler(Alquiler unalquiler) {

            historico.Add(unalquiler);
        
        }
              

        public List<Alquiler> GetHistorico() {


            return historico;
        
        }

        public void DeleteItem(int pos, ListBox lb1) {


            historico.RemoveAt(pos);
            lb1.Items.Clear();

            foreach (Alquiler a in historico) {
                lb1.Items.Add(a.GetVehículo().GetVehiculo()+"   "+a.getClinete().DatosPersonales());

            }
           

        
        }

        public void GrabarCSV(string nombreArchivoHistorico) {


            FileStream Archivo;
                                 
            Archivo = new FileStream(nombreArchivoHistorico, FileMode.Create, FileAccess.Write); 

            StreamWriter escribir = new StreamWriter(Archivo);

            string linea = "";

            foreach (Alquiler a in historico) {

                linea = a.Auto.Marca + ';' + a.Auto.Patente + ';' + a.getClinete().DatosPersonales() + ';';

                escribir.WriteLine(linea);

            }
            escribir.Close();
            Archivo.Close();

            

        }





    }
}
