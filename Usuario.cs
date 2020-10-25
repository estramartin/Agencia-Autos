using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Autos
{
    [Serializable]
    class Usuario: Persona
    {

        private bool tipoUsuario;
        private string nombreusuario;
        private string clave;

      

        public Usuario(string nombre, string clave, bool tipo) {

            Nombreusuario = nombre;
            this.Clave = clave;
            TipoUsuario = tipo;
        
        }

        public bool TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public string Nombreusuario { get => nombreusuario; set => nombreusuario = value; }
        public string Clave { get => clave; set => clave = value; }

       
        
        public override string DatosPersonales()
        {


            return Nombreusuario + " " + TipoUsuario;



        }

        



    }
}
