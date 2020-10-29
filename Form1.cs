﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace Agencia_Autos
{
    public partial class Form1 : Form
    {

        Administracion administracion;
        Persona persona;
        Vehículo vehículo;

        string nombreArchivo = Application.StartupPath+"\\datos.dat";
        string nombreArchivoChoferes = Application.StartupPath + "\\DatosChoferes.csv";
        string nombreArchivoHistorico = Application.StartupPath + "\\DatosChoferes.csv";
        public Form1()
        {
            InitializeComponent();
            if (File.Exists(nombreArchivo))
            {

                FileStream archivo = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
                BinaryFormatter Deserializador = new BinaryFormatter();
                administracion = (Administracion)Deserializador.Deserialize(archivo);
                archivo.Close();
                archivo.Dispose();
            }


            ActualizarListboxs();    


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            bool control = false;
            IngresoUsuario ingresarUsuario = new IngresoUsuario() ;


            DialogResult respuesta = new DialogResult();

           
                if (ingresarUsuario.ShowDialog() == DialogResult.OK)
                {
                
                
                   while (control == false)
                    {

                        string usuario = ingresarUsuario.tbNombreUsuario.Text;
                        string clave = ingresarUsuario.tbClave.Text;
                        bool Supervisor;
                        if (ingresarUsuario.cbSupervisor.Checked == true) Supervisor = true;
                        else { Supervisor = false; }

                        foreach (Usuario u in administracion.GetUsuario())
                        {

                            if (u.Nombreusuario == usuario && (u).Clave == clave && (u).TipoUsuario == Supervisor)
                            {
                                ingresarUsuario.btnIngresar.DialogResult = DialogResult.OK;
                                control = true;
                            }
                            else
                            {
                                MessageBox.Show("Usuario Incorrecto");
                                break;

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
                int kms = Convert.ToInt32(agregar.tbKilometros.Text);
               


                vehículo = new Vehículo(disponible, chofer, patente, marca, modelo, combustible, path, capacidad,unidadDeCobro,kms);

                

                administracion.agregarVehiculo(vehículo);

                ActualizarListboxs();
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

                bool disponible = true, chofer = true;


                string patente = agregar.tbPatente.Text;
                string marca = agregar.tbMarca.Text;
                string modelo = agregar.tbModelo.Text;
                string combustible = agregar.tbtipoCombustible.Text;
                int capacidad = Convert.ToInt32(agregar.tbCapacidad.Text);
                string path = agregar.path;
                int unidadDeCobro = Convert.ToInt32(agregar.tbUnidadDeCobro.Text);
                int kms = Convert.ToInt32(agregar.tbKilometros.Text);

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
                ((Chofer)persona).GrabarCSV(nombreArchivoChoferes);
                vehículo = new VehículoConChofer(disponible, chofer, patente, marca, modelo, combustible, path, capacidad, persona,unidadDeCobro,kms);

                administracion.agregarVehiculo(vehículo);

                ActualizarListboxs();

            }
        }

        private void modificarValoresDeAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarValoresDeAlquiler modificar = new ModificarValoresDeAlquiler();
            modificar.lblMostrarValorActual.Text = administracion.Pesos.ToString();
            if (modificar.ShowDialog() == DialogResult.OK) {

                double valor = Convert.ToDouble(modificar.tbModificarValorDeAlquiler.Text);
               administracion.Pesos = valor;
            
            
            }


        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string ruta = administracion.GetVehículos()[listBox1.SelectedIndex].Imagen;
                GenerarAlquiler VentanaAlquilar = new GenerarAlquiler();
                VentanaAlquilar.label11.Text = administracion.GetVehículos()[listBox1.SelectedIndex].GetVehiculo();
                if (administracion.GetVehículos()[listBox1.SelectedIndex].Disponible == false)
                {

                    VentanaAlquilar.gbCliente.Enabled = false;
                    VentanaAlquilar.btnAlquilar.Enabled = false;

                }
                else
                {

                    VentanaAlquilar.gbCliente.Enabled = true;
                    VentanaAlquilar.btnAlquilar.Enabled = true;

                }

                VentanaAlquilar.pictureBox1.Image = Image.FromFile(ruta);
                VentanaAlquilar.comboBox1.Show();
                if (VentanaAlquilar.ShowDialog() == DialogResult.OK)
                {
                    string nombre = VentanaAlquilar.tbNombreCliente.Text;
                    int Dni = Convert.ToInt32(VentanaAlquilar.tbDniCliente.Text);
                    long cuil = Convert.ToInt64(VentanaAlquilar.tbCuilCliente.Text);
                    string dir = VentanaAlquilar.tbDireccionCliente.Text;
                    int tel = Convert.ToInt32(VentanaAlquilar.tbTelefonoCliente.Text);
                    DateTime fechanac = VentanaAlquilar.dtpFechaNac.Value;
                    string estadocivil = VentanaAlquilar.tbEstadoCivilCliente.Text;
                    string nacionalidad = VentanaAlquilar.tbNacionalidadCliente.Text;
                    long carnet = Convert.ToInt64(VentanaAlquilar.tbCarnetCliente.Text);
                    int diasDeAlquiler = Convert.ToInt32(VentanaAlquilar.tbDiasDeAlquiler.Text);
                    int cantidadConductores = VentanaAlquilar.comboBox1.SelectedIndex;

                    persona = new Cliente(nombre, Dni, cuil, dir, tel, fechanac, estadocivil, nacionalidad, carnet);

                    Alquiler alquiler = new Alquiler(persona);
                    alquiler.DiasDeAlquiler = diasDeAlquiler;
                    alquiler.agregarConductores(persona);

                    switch (cantidadConductores)
                    {

                        case 2:
                            {

                                string nombre1 = VentanaAlquilar.tbNombreAcompañante1.Text;
                                int Dni1 = Convert.ToInt32(VentanaAlquilar.tbDNIAcompañante1.Text);
                                long cuil1 = Convert.ToInt64(VentanaAlquilar.tbCuilAcompañante1.Text);
                                string dir1 = VentanaAlquilar.tbDirAcompañante1.Text;
                                int tel1 = Convert.ToInt32(VentanaAlquilar.tbTelAcompañante1.Text);
                                DateTime fechanac1 = VentanaAlquilar.dtpFechaNacAcompañante1.Value;
                                string estadocivil1 = VentanaAlquilar.tbEstadoCivilAcompañante1.Text;
                                string nacionalidad1 = VentanaAlquilar.tbNacAcompañante1.Text;
                                long carnet1 = Convert.ToInt64(VentanaAlquilar.tbCarnetAcompañante1.Text);
                                persona = new Cliente(nombre1, Dni1, cuil1, dir1, tel1, fechanac1, estadocivil1, nacionalidad1, carnet1);
                                alquiler.agregarConductores(persona);

                                break;
                            }
                        case 3:
                            {

                                string nombre1 = VentanaAlquilar.tbNombreAcompañante1.Text;
                                int Dni1 = Convert.ToInt32(VentanaAlquilar.tbDNIAcompañante1.Text);
                                long cuil1 = Convert.ToInt64(VentanaAlquilar.tbCuilAcompañante1.Text);
                                string dir1 = VentanaAlquilar.tbDirAcompañante1.Text;
                                int tel1 = Convert.ToInt32(VentanaAlquilar.tbTelAcompañante1.Text);
                                DateTime fechanac1 = VentanaAlquilar.dtpFechaNacAcompañante1.Value;
                                string estadocivil1 = VentanaAlquilar.tbEstadoCivilAcompañante1.Text;
                                string nacionalidad1 = VentanaAlquilar.tbNacAcompañante1.Text;
                                long carnet1 = Convert.ToInt64(VentanaAlquilar.tbCarnetAcompañante1.Text);
                                persona = new Cliente(nombre1, Dni1, cuil1, dir1, tel1, fechanac1, estadocivil1, nacionalidad1, carnet1);
                                alquiler.agregarConductores(persona);

                                string nombre2 = VentanaAlquilar.tbNombreAcompañante2.Text;
                                int Dni2 = Convert.ToInt32(VentanaAlquilar.tbDNIAcompañante2.Text);
                                long cuil2 = Convert.ToInt64(VentanaAlquilar.tbCuilAcompañante2.Text);
                                string dir2 = VentanaAlquilar.tbDirAcompañante2.Text;
                                int tel2 = Convert.ToInt32(VentanaAlquilar.tbTelAcompañante2.Text);
                                DateTime fechanac2 = VentanaAlquilar.dtpFechaNacAcompañante2.Value;
                                string estadocivil2 = VentanaAlquilar.tbEstadoCivilAcompañante2.Text;
                                string nacionalidad2 = VentanaAlquilar.tbNacAcompañante2.Text;
                                long carnet2 = Convert.ToInt64(VentanaAlquilar.tbCarnetAcompañante2.Text);
                                persona = new Cliente(nombre2, Dni2, cuil2, dir2, tel2, fechanac2, estadocivil2, nacionalidad2, carnet2);
                                alquiler.agregarConductores(persona);
                                break;

                            }


                    }


                    alquiler.Auto = administracion.GetVehículos()[listBox1.SelectedIndex];
                    alquiler.InicioAlquiler = DateTime.Now;
                    alquiler.Auto.Disponible = false;
                    administracion.CargarAlquiler(alquiler);
                    administracion.VerHistorico().GrabarCSV(nombreArchivoHistorico);

                    listBox1.Items.Clear();
                    ActualizarListboxs();

                }
            }
            catch (Exception){ }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlquileresVigentes veralquileres = new AlquileresVigentes();
            foreach (Alquiler p in administracion.GetAlquileres())

                veralquileres.listBox1.Items.Add(p.getClinete().DatosPersonales() + " " + p.Auto.GetVehiculo()); ;

            if (veralquileres.ShowDialog() == DialogResult.OK) {


                double precio = administracion.Devolucion(veralquileres.listBox1.SelectedIndex, Convert.ToInt32(veralquileres.textBox1.Text),veralquileres.listBox1, veralquileres.dateTimePicker1.Value);

                MessageBox.Show( "precio: " + precio.ToString());

                ActualizarListboxs();
            
            
            }



        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                string ruta = administracion.GetVehiculosConChofer()[listBox2.SelectedIndex].Imagen;

                GenerarAlquiler VentanaAlquilar = new GenerarAlquiler();

                if (administracion.GetVehiculosConChofer()[listBox2.SelectedIndex].Disponible == false)
                {

                    VentanaAlquilar.gbCliente.Enabled = false;
                    VentanaAlquilar.btnAlquilar.Enabled = false;

                }
                else
                {

                    VentanaAlquilar.gbCliente.Enabled = true;
                    VentanaAlquilar.btnAlquilar.Enabled = true;

                }
                VentanaAlquilar.label11.Text = ((VehículoConChofer)(administracion.GetVehiculosConChofer()[listBox2.SelectedIndex])).UnChofer.DatosPersonales();
                VentanaAlquilar.comboBox1.Hide();

                VentanaAlquilar.pictureBox1.Image = Image.FromFile(ruta);

                if (VentanaAlquilar.ShowDialog() == DialogResult.OK)
                {
                    string nombre = VentanaAlquilar.tbNombreCliente.Text;
                    int Dni = Convert.ToInt32(VentanaAlquilar.tbDniCliente.Text);
                    long cuil = Convert.ToInt64(VentanaAlquilar.tbCuilCliente.Text);
                    string dir = VentanaAlquilar.tbDireccionCliente.Text;
                    int tel = Convert.ToInt32(VentanaAlquilar.tbTelefonoCliente.Text);
                    DateTime fechanac = VentanaAlquilar.dtpFechaNac.Value;
                    string estadocivil = VentanaAlquilar.tbEstadoCivilCliente.Text;
                    string nacionalidad = VentanaAlquilar.tbNacionalidadCliente.Text;
                    long carnet = Convert.ToInt64(VentanaAlquilar.tbCarnetCliente.Text);
                    int cantidadConductores = VentanaAlquilar.comboBox1.SelectedIndex;

                    persona = new Cliente(nombre, Dni, cuil, dir, tel, fechanac, estadocivil, nacionalidad, carnet);

                    Alquiler alquiler = new Alquiler(persona);
                    alquiler.Auto = administracion.GetVehiculosConChofer()[listBox2.SelectedIndex];
                    alquiler.InicioAlquiler = DateTime.Now;
                    alquiler.Auto.Disponible = false;
                    administracion.CargarAlquiler(alquiler);
                    administracion.VerHistorico().GrabarCSV(nombreArchivoHistorico);
                    ActualizarListboxs();


                }
            }
            catch (Exception) { }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (File.Exists(nombreArchivo)) File.Delete(nombreArchivo);
            FileStream archivo = new FileStream(nombreArchivo, FileMode.CreateNew, FileAccess.Write);
            BinaryFormatter serializador = new BinaryFormatter();
            serializador.Serialize(archivo, administracion);

            archivo.Close();
           
            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(administracion.GetVehículos()[listBox1.SelectedIndex].Imagen);
            }
            catch (ArgumentOutOfRangeException ) { }
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(administracion.GetVehiculosConChofer()[listBox2.SelectedIndex].Imagen);

            }
            catch (ArgumentOutOfRangeException) { }
        }


        public void ActualizarListboxs() {

            listBox1.Items.Clear();
            listBox2.Items.Clear();


         foreach (Vehículo v in administracion.GetVehículos())
            {
                if (v.Disponible == true) { listBox1.Items.Add(v.GetVehiculo()); }
                else { listBox1.Items.Add(v.GetVehiculo()+" (Alquilado)"); }

            }
            foreach (Vehículo v in administracion.GetVehiculosConChofer())
            {
                if (v.Disponible == true) listBox2.Items.Add(v.GetVehiculo());
                else listBox2.Items.Add(v.GetVehiculo()+" (Alquilado)") ;
            }
        
        }

        private void cbVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehículo.ordenar = (cbVehiculosConChofer.SelectedIndex);
            administracion.GetVehículos().Sort();
            ActualizarListboxs();



        }

        private void cbVehiculosConChofer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehículo.ordenar = (cbVehiculosConChofer.SelectedIndex);
            administracion.GetVehiculosConChofer().Sort();
            ActualizarListboxs();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerHistorico verHistorico = new VerHistorico();
            verHistorico.listBox1.Items.Clear();



            foreach (Alquiler h in administracion.VerHistorico().GetHistorico()) {

               verHistorico.listBox1.Items.Add(h.GetVehículo().GetVehiculo() + "   " + h.getClinete().DatosPersonales());     
                                 
            }


            DialogResult respuesta = new DialogResult();
            respuesta = verHistorico.ShowDialog();


            if (respuesta == DialogResult.OK)
            {

                administracion.VerHistorico().DeleteItem(verHistorico.listBox1.SelectedIndex, verHistorico.listBox1);

                foreach (Alquiler h in administracion.VerHistorico().GetHistorico())
                {

                    verHistorico.listBox1.Items.Add(h.GetVehículo().GetVehiculo() + "   " + h.getClinete().DatosPersonales());

                }



            }         
            



        }
    }
}
