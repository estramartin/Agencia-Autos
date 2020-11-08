using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_Autos
{
    public partial class Agregar_Vehiculo : Form
    {

        public string path;

        public Agregar_Vehiculo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCarcarImagenAuto_Click(object sender, EventArgs e)
        {

           openFileDialog1.ShowDialog();

            path = openFileDialog1.FileName;
            try
            {
                pictureBox1.Image = Image.FromFile(path);
            }
            catch(System.IO.FileNotFoundException) {

                MessageBox.Show("Error");
            }
               
            

        }

        private void tbModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCapacidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbtipoCombustible_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPatente_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
