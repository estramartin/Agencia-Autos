using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Autos
{
    [Serializable]
    class Historico
    {

        List<Alquiler> historico = new List<Alquiler>();


        public void agregarAlHistorico(Alquiler unAlquiler) {


            historico.Add(unAlquiler);
        
        
        }

        public List<Alquiler> GetHistorico() {


            return historico;
        
        }





    }
}
