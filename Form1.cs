using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_Autos
{
    public partial class Form1 : Form
    {
        Administracion administracion = new Administracion();
        Persona persona;
        Vehículo vehículo;
        FileStream archivo;

        


        public Form1()
        {
            InitializeComponent();
            persona = new Usuario("Alejandro", "1111", true);
            administracion.agregarUsuario(persona);
            persona = new Usuario("Facundo", "2222", false);
            administracion.agregarUsuario(persona);
            persona = new Usuario("Martin", "3333", false);
            administracion.agregarUsuario(persona);
            persona = new Usuario("Pablo", "4444", false);
            administracion.agregarUsuario(persona);
            vehículo = new Vehículo(true, false, "ppk891", "Toyota Etios", "2016", "Nafta", @"D:\Martin\TSP\Laboratorio 2\TP 2\Agencia Autos\Resources\Etios.jpg", 5, 43);
            administracion.agregarVehiculo(vehículo);
            vehículo = new Vehículo(true, false, "hbp564", "Peugueot 206", "2008", "Nafta", @"D:\Martin\TSP\Laboratorio 2\TP 2\Agencia Autos\Resources\206.jpg", 5,48);
            administracion.agregarVehiculo(vehículo);

            DateTime fechanac = DateTime.Now;
            persona = new Chofer("Marios Sanchez", 34565789, 20345657899, "Corrientes 234", 4232425, fechanac, "Casado", "Argentino", 23234234);
            vehículo = new VehículoConChofer(true, true, "grd454", "Renault Clio", "2017", "nafta", @"D:\Martin\TSP\Laboratorio 2\TP 2\Agencia Autos\Resources\Clio.jpg", 5,persona,40);
            administracion.agregarVehiculo(vehículo);

            


            foreach (Vehículo v in administracion.GetVehículos())
            {
                listBox1.Items.Add(v.GetVehiculo());

            }
            foreach (Vehículo v in administracion.GetVehiculosConChofer())
            {
                listBox2.Items.Add(v.GetVehiculo());

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            IngresoUsuario ingresarUsuario = new IngresoUsuario();


            if (ingresarUsuario.ShowDialog() == DialogResult.OK)
            {

                bool control = false;


                while (control == false)
                {

                    string usuario = ingresarUsuario.tbNombreUsuario.Text;
                    string clave = ingresarUsuario.tbClave.Text;
                    bool Supervisor = false;
                    if (ingresarUsuario.rbSuperovisor.Checked == true) Supervisor = true;


                    persona = new Usuario(usuario, clave, Supervisor);
                    foreach (Persona u in administracion.GetUsuario())
                    {

                        if (((Usuario)u).Nombreusuario == usuario && ((Usuario)u).Clave == clave && ((Usuario)u).TipoUsuario == Supervisor)
                        {
                            control = true;

                            DialogResult = DialogResult.OK;
                        }
                        else
                        {

                            DialogResult = DialogResult.None;

                        }

                    }



                }

            }




        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] asd = new int[2];
            asd[7] = 2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void sinChoferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Vehiculo agregar = new Agregar_Vehiculo();

            agregar.Size = new Size(816, 370);
            agregar.btnCargar.Location = new Point(657, 296);
            agregar.btnSalir.Location = new Point(59, 300);
            if (agregar.ShowDialog() == DialogResult.OK)
            {

                bool disponible = true, chofer = false;


                string patente = agregar.tbPatente.Text;
                string marca = agregar.tbMarca.Text;
                string modelo = agregar.tbModelo.Text;
                string combustible = agregar.tbtipoCombustible.Text;
                int capacidad = Convert.ToInt32(agregar.tbCapacidad.Text);
                string path = agregar.path;
                int unidadDeCobro = Convert.ToInt32(agregar.tbUnidadDeCobro.Text);

                //Agregando Vehiculo ver como seguir


                vehículo = new Vehículo(disponible, false, patente, marca, modelo, combustible, path, capacidad,unidadDeCobro);

                

                administracion.agregarVehiculo(vehículo);

                listBox1.Items.Clear();
                foreach (Vehículo v in administracion.GetVehículos())
                {
                    listBox1.Items.Add(v.GetVehiculo());

                }




            }
        }

        private void conChoferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Vehiculo agregar = new Agregar_Vehiculo();

            agregar.Size = new Size(816, 706);
            agregar.btnCargar.Location = new Point(565, 636);
            agregar.btnSalir.Location = new Point(35, 641);
            
            if (agregar.ShowDialog() == DialogResult.OK)
            {

                bool disponible = true, chofer = false;


                string patente = agregar.tbPatente.Text;
                string marca = agregar.tbMarca.Text;
                string modelo = agregar.tbModelo.Text;
                string combustible = agregar.tbtipoCombustible.Text;
                int capacidad = Convert.ToInt32(agregar.tbCapacidad.Text);
                string path = agregar.path;
                int unidadDeCobro = Convert.ToInt32(agregar.tbUnidadDeCobro.Text);

                string nombre = agregar.tbNombreChofer.Text;
                int Dni = Convert.ToInt32(agregar.tbDniChofer.Text);
                long cuil = Convert.ToInt64(agregar.tbCuit.Text);
                string dir = agregar.tbDireccion.Text;
                int tel = Convert.ToInt32(agregar.tbTelefono.Text);
                DateTime fechanac = agregar.dtpFechaNac.Value;
                string estadocivil = agregar.tbEstadoCivil.Text;
                string nacionalidad = agregar.tbNacionalidad.Text;
                long carnet = Convert.ToInt64(agregar.tbCarnet.Text);

                persona = new Chofer(nombre, Dni, cuil, dir, tel, fechanac, estadocivil, nacionalidad,carnet);
                vehículo = new VehículoConChofer(disponible, true, patente, marca, modelo, combustible, path, capacidad, persona,unidadDeCobro);

                administracion.agregarVehiculo(vehículo);

                listBox2.Items.Clear();
                foreach (Vehículo v in administracion.GetVehiculosConChofer())
                {
                    listBox2.Items.Add(v.GetVehiculo());

                }

            }
        }

        private void modificarValoresDeAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarValoresDeAlquiler modificar = new ModificarValoresDeAlquiler();

            if (modificar.ShowDialog() == DialogResult.OK) { 
            
            
            
            
            }


        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string ruta = administracion.GetVehículos()[listBox1.SelectedIndex].Imagen;
           
            GenerarAlquiler alquilar = new GenerarAlquiler();

            

            alquilar.pictureBox1.Image = Image.FromFile(ruta);
            alquilar.comboBox1.Show();
            if (alquilar.ShowDialog() == DialogResult.OK)
            {
                string nombre = alquilar.tbNombreCliente.Text;
                int Dni = Convert.ToInt32(alquilar.tbDniCliente.Text);
                long cuil = Convert.ToInt64(alquilar.tbCuilCliente.Text);
                string dir = alquilar.tbDireccionCliente.Text;
                int tel = Convert.ToInt32(alquilar.tbTelefonoCliente.Text);
                DateTime fechanac = alquilar.dtpFechaNac.Value;
                string estadocivil = alquilar.tbEstadoCivilCliente.Text;
                string nacionalidad = alquilar.tbNacionalidadCliente.Text;
                long carnet = Convert.ToInt64(alquilar.tbCarnetCliente.Text);
                int cantidadConductores = alquilar.comboBox1.SelectedIndex;

                persona = new Cliente(nombre, Dni, cuil, dir, tel, fechanac, estadocivil, nacionalidad, carnet);

                Alquiler alquiler = new Alquiler(persona);

                switch (cantidadConductores) {

                    case 1: {
                            string nombre1 = alquilar.tbNombreAcompañante1.Text;
                            int Dni1 = Convert.ToInt32(alquilar.tbDNIAcompañante1.Text);
                            long cuil1 = Convert.ToInt64(alquilar.tbCuilAcompañante1.Text);
                            string dir1 = alquilar.tbDirAcompañante1.Text;
                            int tel1 = Convert.ToInt32(alquilar.tbTelAcompañante1.Text);
                            DateTime fechanac1 = alquilar.dtpFechaNacAcompañante1.Value;
                            string estadocivil1 = alquilar.tbEstadoCivilAcompañante1.Text;
                            string nacionalidad1 = alquilar.tbNacAcompañante1.Text;
                            long carnet1 = Convert.ToInt64(alquilar.tbCarnetAcompañante1.Text);
                            persona = new Cliente(nombre1, Dni1, cuil1, dir1, tel1, fechanac1, estadocivil1, nacionalidad1, carnet1);
                            alquiler.agregarConductores(persona);

                            break;
                        }
                    case 2: {

                            string nombre1 = alquilar.tbNombreAcompañante1.Text;
                            int Dni1 = Convert.ToInt32(alquilar.tbDNIAcompañante1.Text);
                            long cuil1 = Convert.ToInt64(alquilar.tbCuilAcompañante1.Text);
                            string dir1 = alquilar.tbDirAcompañante1.Text;
                            int tel1 = Convert.ToInt32(alquilar.tbTelAcompañante1.Text);
                            DateTime fechanac1 = alquilar.dtpFechaNacAcompañante1.Value;
                            string estadocivil1 = alquilar.tbEstadoCivilAcompañante1.Text;
                            string nacionalidad1 = alquilar.tbNacAcompañante1.Text;
                            long carnet1 = Convert.ToInt64(alquilar.tbCarnetAcompañante1.Text);
                            persona = new Cliente(nombre1, Dni1, cuil1, dir1, tel1, fechanac1, estadocivil1, nacionalidad1, carnet1);
                            alquiler.agregarConductores(persona);

                            string nombre2 = alquilar.tbNombreAcompañante2.Text;
                            int Dni2 = Convert.ToInt32(alquilar.tbDNIAcompañante2.Text);
                            long cuil2 = Convert.ToInt64(alquilar.tbCuilAcompañante2.Text);
                            string dir2 = alquilar.tbDirAcompañante2.Text;
                            int tel2 = Convert.ToInt32(alquilar.tbTelAcompañante2.Text);
                            DateTime fechanac2 = alquilar.dtpFechaNacAcompañante2.Value;
                            string estadocivil2 = alquilar.tbEstadoCivilAcompañante2.Text;
                            string nacionalidad2 = alquilar.tbNacAcompañante2.Text;
                            long carnet2 = Convert.ToInt64(alquilar.tbCarnetAcompañante2.Text);
                            persona = new Cliente(nombre2, Dni2, cuil2, dir2, tel2, fechanac2, estadocivil2, nacionalidad2, carnet2);
                            alquiler.agregarConductores(persona);
                            break;

                        }
                    case 3: {

                            string nombre1 = alquilar.tbNombreAcompañante1.Text;
                            int Dni1 = Convert.ToInt32(alquilar.tbDNIAcompañante1.Text);
                            long cuil1 = Convert.ToInt64(alquilar.tbCuilAcompañante1.Text);
                            string dir1 = alquilar.tbDirAcompañante1.Text;
                            int tel1 = Convert.ToInt32(alquilar.tbTelAcompañante1.Text);
                            DateTime fechanac1 = alquilar.dtpFechaNacAcompañante1.Value;
                            string estadocivil1 = alquilar.tbEstadoCivilAcompañante1.Text;
                            string nacionalidad1 = alquilar.tbNacAcompañante1.Text;
                            long carnet1 = Convert.ToInt64(alquilar.tbCarnetAcompañante1.Text);
                            persona = new Cliente(nombre1, Dni1, cuil1, dir1, tel1, fechanac1, estadocivil1, nacionalidad1, carnet1);
                            alquiler.agregarConductores(persona);

                            string nombre2 = alquilar.tbNombreAcompañante2.Text;
                            int Dni2 = Convert.ToInt32(alquilar.tbDNIAcompañante2.Text);
                            long cuil2 = Convert.ToInt64(alquilar.tbCuilAcompañante2.Text);
                            string dir2 = alquilar.tbDirAcompañante2.Text;
                            int tel2 = Convert.ToInt32(alquilar.tbTelAcompañante2.Text);
                            DateTime fechanac2 = alquilar.dtpFechaNacAcompañante2.Value;
                            string estadocivil2 = alquilar.tbEstadoCivilAcompañante2.Text;
                            string nacionalidad2 = alquilar.tbNacAcompañante2.Text;
                            long carnet2 = Convert.ToInt64(alquilar.tbCarnetAcompañante2.Text);
                            persona = new Cliente(nombre2, Dni2, cuil2, dir2, tel2, fechanac2, estadocivil2, nacionalidad2, carnet2);
                            alquiler.agregarConductores(persona);
                            
                           
                            string nombre3 = alquilar.tbNombreAcompañante3.Text;
                            int Dni3 = Convert.ToInt32(alquilar.tbDNIAcompañante3.Text);
                            long cuil3 = Convert.ToInt64(alquilar.tbCuilAcompañante3.Text);
                            string dir3 = alquilar.tbDirAcompañante3.Text;
                            int tel3 = Convert.ToInt32(alquilar.tbTelAcompañante3.Text);
                            DateTime fechanac3 = alquilar.dtpFechaNacAcompañante3.Value;
                            string estadocivil3 = alquilar.tbEstadoCivilAcompañante3.Text;
                            string nacionalidad3 = alquilar.tbNacAcompañante3.Text;
                            long carnet3 = Convert.ToInt64(alquilar.tbCarnetAcompañante3.Text);
                            persona = new Cliente(nombre3, Dni3, cuil3, dir3, tel3, fechanac3, estadocivil3, nacionalidad3, carnet3);
                            alquiler.agregarConductores(persona);
                            break;
                        }
                

                       

                }

                alquiler.Auto = administracion.GetVehículos()[listBox1.SelectedIndex];
                alquiler.InicioAlquiler = DateTime.Now;
                alquiler.Auto.Disponible = false;
                administracion.CargarAlquiler(alquiler);



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlquileresVigentes veralquileres = new AlquileresVigentes();
            foreach (Alquiler p in administracion.GetAlquileres())

                veralquileres.listBox1.Items.Add(p.getClinete().DatosPersonales() + " " + p.Auto.GetVehiculo()); ;

            if (veralquileres.ShowDialog() == DialogResult.OK) {

                
                
            
            
            
            }



        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            string ruta = administracion.GetVehiculosConChofer()[listBox2.SelectedIndex].Imagen;

            GenerarAlquiler alquilar = new GenerarAlquiler();
            alquilar.label11.Text = ((VehículoConChofer)(administracion.GetVehiculosConChofer()[listBox2.SelectedIndex])).UnChofer.DatosPersonales() ;
            alquilar.comboBox1.Hide();

            alquilar.pictureBox1.Image = Image.FromFile(ruta);

            if (alquilar.ShowDialog() == DialogResult.OK)
            {
                string nombre = alquilar.tbNombreCliente.Text;
                int Dni = Convert.ToInt32(alquilar.tbDniCliente.Text);
                long cuil = Convert.ToInt64(alquilar.tbCuilCliente.Text);
                string dir = alquilar.tbDireccionCliente.Text;
                int tel = Convert.ToInt32(alquilar.tbTelefonoCliente.Text);
                DateTime fechanac = alquilar.dtpFechaNac.Value;
                string estadocivil = alquilar.tbEstadoCivilCliente.Text;
                string nacionalidad = alquilar.tbNacionalidadCliente.Text;
                long carnet = Convert.ToInt64(alquilar.tbCarnetCliente.Text);
                int cantidadConductores = alquilar.comboBox1.SelectedIndex;

                persona = new Cliente(nombre, Dni, cuil, dir, tel, fechanac, estadocivil, nacionalidad, carnet);

                Alquiler alquiler = new Alquiler(persona);
                alquiler.Auto = administracion.GetVehiculosConChofer()[listBox2.SelectedIndex];
                alquiler.InicioAlquiler = DateTime.Now;
                
                administracion.CargarAlquiler(alquiler);



            }
        }
    }
}
