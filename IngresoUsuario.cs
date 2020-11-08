using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_Autos
{
    public partial class IngresoUsuario : Form
    {

        public bool superovisor;

        public IngresoUsuario()
        {
            InitializeComponent();
           
            
        }
        private void IngresoUsuario_Load(object sender, EventArgs e)
        {
           
                


        }

        public void btnIngresar_Click(object sender, EventArgs e)
        {


           

           string nombre = tbNombreUsuario.Text;
            string clave = tbClave.Text;
            bool Supervisor;
            if (cbSupervisor.Checked == true) { Supervisor = true; }
            else { Supervisor = false; }

            if (nombre == "Administrador" && clave == "administrar" && Supervisor == false) {

                superovisor = false;
                this.Close();
            
            }
            if (nombre == "Supervisor" && clave == "supervisar" && Supervisor == true)
            {

                superovisor = true;
                this.Close();

            }



        }

        public void btnSalir_Click(object sender, EventArgs e)
        {
       
        }
    }
}
