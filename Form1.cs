﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        double precio;
        string nombreArchivo = Application.StartupPath+"\\datos.dat";
        string nombreArchivoChoferes = Application.StartupPath + "\\DatosChoferes.csv";
        string nombreArchivoHistorico = Application.StartupPath + "\\DatosHistorico.csv";
        List<Vehículo> SinChof = new List<Vehículo>();
        List<Vehículo> ConChof = new List<Vehículo>();
        Alquiler devolucion;

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
            else {

                Empresa unaEmpresa = new Empresa();
                unaEmpresa.RazonSocial = "ALQUILAUTO";
                unaEmpresa.DireccionFiscal = "LOS EUCALIPTUS 1234";
                unaEmpresa.Cuil = 465698568;
                Historico unHistorico = new Historico();
                administracion = new Administracion(unaEmpresa,unHistorico);

            }

            ActualizarListboxs();    


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           label3.Text = administracion.GetEmpresa().RazonSocial;
            IngresoUsuario ingresarUsuario = new IngresoUsuario();
            ingresarUsuario.ShowDialog();

            if (ingresarUsuario.superovisor == true){ menuStrip1.Show(); }
            else { menuStrip1.Hide(); }


            ingresarUsuario.Dispose();

            SinChof.AddRange(administracion.GetVehículos());
            ConChof.AddRange(administracion.GetVehiculosConChofer());
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
                administracion.GetVehículos().Sort();
               

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
                administracion.GetVehiculosConChofer().Sort();
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
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            AlquileresVigentes veralquileres = new AlquileresVigentes();
            Ticket unTicket = new Ticket();

            veralquileres.dgvAlquileres.AllowUserToAddRows =false;
            string[] alquileres = new string[6];
            

            foreach (Alquiler p in administracion.GetAlquileres())
            {       
               
                
                string datos = p.getClinete().Nombre + ";" + p.getClinete().Dni + ";" + p.getClinete().Telefono + ";" + Convert.ToString(p.getAcompañantes().Length) + ";" + p.Auto.Marca + ";" + p.Auto.Patente + ";" + p.Auto.Kms;
               
                alquileres= datos.Split(';');
                veralquileres.dgvAlquileres.ColumnCount = alquileres.Length;
                veralquileres.dgvAlquileres.Rows.Add(alquileres);

                
            }

            if (veralquileres.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    devolucion = new Alquiler();
                    devolucion = administracion.GetAlquileres()[veralquileres.dgvAlquileres.CurrentRow.Index];
                    precio = administracion.Devolucion(veralquileres.dgvAlquileres.CurrentRow.Index, Convert.ToInt32(veralquileres.textBox1.Text), veralquileres.dgvAlquileres, veralquileres.dateTimePicker1.Value);

                    

                    unTicket.printPreviewControl1.Document = PrintTicket;
                    ActualizarListboxs();





                    if (unTicket.ShowDialog() == DialogResult.OK)
                    {

                        PrintTicket.Print();


                    }


                }
                catch (Exception) { }



            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
           
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
           
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
           
        }


        public void ActualizarListboxs() {
            DGV1.Rows.Clear();
          
            DataGridViewRow fila;

            if (cbChofer.SelectedIndex == 1)
            {
                foreach (Vehículo v in administracion.GetVehículos())
                {
                   
                    fila = new DataGridViewRow();
                    fila.CreateCells(DGV1);
                    fila.Cells[CMARCA.Index].Value = v.Marca;
                    fila.Cells[CMOODELO.Index].Value = v.Modelo;
                    fila.Cells[CCAPACIDAD.Index].Value = v.Capacidad;
                    fila.Cells[CKMS.Index].Value = v.Kms;
                    fila.Cells[CPRECIO.Index].Value = ((v.UnidadDeCobro) * (administracion.Pesos));
                    if (v.Disponible == true)
                    {
                        fila.Cells[CDISPONIBILE.Index].Value = "Disponible";
                    }
                    else { fila.Cells[CDISPONIBILE.Index].Value = "Alquilado"; }


                    fila.Cells[CCOMBUSTIBLE.Index].Value = v.Tipocombustible;

                    DGV1.Rows.Add(fila);
                }
            }
            else
            {
                foreach (Vehículo v in administracion.GetVehiculosConChofer())
                {
                    
                    fila = new DataGridViewRow();
                    fila.CreateCells(DGV1);
                    fila.Cells[CMARCA.Index].Value = v.Marca;
                    fila.Cells[CMOODELO.Index].Value = v.Modelo;
                    fila.Cells[CCAPACIDAD.Index].Value = v.Capacidad;
                    fila.Cells[CKMS.Index].Value = v.Kms;
                    fila.Cells[CPRECIO.Index].Value = ((v.UnidadDeCobro) * (administracion.Pesos));
                    if (v.Disponible == true)
                    {
                        fila.Cells[CDISPONIBILE.Index].Value = "Disponible";
                    }
                    else { fila.Cells[CDISPONIBILE.Index].Value = "Alquilado"; }


                    fila.Cells[CCOMBUSTIBLE.Index].Value = v.Tipocombustible;

                    DGV1.Rows.Add(fila);
                }

            }

           
        }

        private void cbVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (cbChofer.SelectedIndex == 1)
            {

                Vehículo.ordenar = (cbVehiculos.SelectedIndex);
                administracion.GetVehículos().Sort();
                ActualizarListboxs();
            }
            else {

                Vehículo.ordenar = (cbVehiculos.SelectedIndex);
                administracion.GetVehiculosConChofer().Sort();
                ActualizarListboxs();
            }*/
            


        }

        private void cbVehiculosConChofer_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerHistorico verHistorico = new VerHistorico();
            verHistorico.dgvHistorico.Rows.Clear();
            verHistorico.btnBorrar.Hide();

            verHistorico.dgvHistorico.AllowUserToAddRows = false;
            string[] historico = new string[6];


            foreach (Alquiler p in administracion.GetAlquileres())
            {


                string datos = p.getClinete().Nombre + ";" + p.getClinete().Dni + ";" + p.getClinete().Telefono + ";" + Convert.ToString(p.getAcompañantes().Length) + ";" + p.Auto.Marca + ";" + p.Auto.Patente + ";" + p.Auto.Kms;

                historico = datos.Split(';');
                verHistorico.dgvHistorico.ColumnCount = historico.Length;
                verHistorico.dgvHistorico.Rows.Add(historico);

                //
                
                
                verHistorico.dgvHistorico.Rows.Add(p.getClinete().Nombre + " " + p.getClinete().Dni + " " + p.getClinete().Telefono + " " + Convert.ToString(p.getAcompañantes().Length) + " " + p.Auto.Marca + " " + p.Auto.Patente + " " + p.Auto.Kms);



            }

                   
            
            DialogResult respuesta = new DialogResult();
            respuesta = verHistorico.ShowDialog();


            if (respuesta == DialogResult.Cancel)
            {

                



            }         
            



        }

        private void borrarRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerHistorico verHistorico = new VerHistorico();
            verHistorico.dgvHistorico.Rows.Clear();
            verHistorico.btnBorrar.Hide();

            verHistorico.dgvHistorico.AllowUserToAddRows = false;
            string[] historico = new string[6];


            foreach (Alquiler p in administracion.GetAlquileres())
            {


                string datos = p.getClinete().Nombre + ";" + p.getClinete().Dni + ";" + p.getClinete().Telefono + ";" + Convert.ToString(p.getAcompañantes().Length) + ";" + p.Auto.Marca + ";" + p.Auto.Patente + ";" + p.Auto.Kms;

                historico = datos.Split(';');
                verHistorico.dgvHistorico.ColumnCount = historico.Length;
                verHistorico.dgvHistorico.Rows.Add(historico);

                verHistorico.dgvHistorico.Rows.Add(p.getClinete().Nombre + " " + p.getClinete().Dni + " " + p.getClinete().Telefono + " " + Convert.ToString(p.getAcompañantes().Length) + " " + p.Auto.Marca + " " + p.Auto.Patente + " " + p.Auto.Kms);



            }


            DialogResult respuesta = new DialogResult();
            respuesta = verHistorico.ShowDialog();


            if (respuesta == DialogResult.OK)
            {

                administracion.VerHistorico().DeleteItem(verHistorico.dgvHistorico.CurrentRow.Index, verHistorico.dgvHistorico);

                foreach (Alquiler p in administracion.VerHistorico().GetHistorico())
                {

                    verHistorico.dgvHistorico.Rows.Add(p.getClinete().Nombre + " " + p.getClinete().Dni + " " + p.getClinete().Telefono + " " + Convert.ToString(p.getAcompañantes().Length) + " " + p.Auto.Marca + " " + p.Auto.Patente + " " + p.Auto.Kms);

                }



            }
        }

        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (cbChofer.SelectedIndex == 1)
                try
                {
                    pictureBox1.Image = Image.FromFile(SinChof[DGV1.CurrentRow.Index].Imagen);
                }
                catch (ArgumentOutOfRangeException) { }
            else {
                try
                {
                    pictureBox1.Image = Image.FromFile(ConChof[DGV1.CurrentRow.Index].Imagen);
                }
                catch (ArgumentOutOfRangeException) { }
            }
        }

        private void DGV1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           if(cbChofer.SelectedIndex == 1) {

                

                string ruta = SinChof[DGV1.CurrentRow.Index].Imagen;
                GenerarAlquiler VentanaAlquilar = new GenerarAlquiler();
                VentanaAlquilar.label11.Text = SinChof[DGV1.CurrentRow.Index].GetVehiculo();
                if (SinChof[DGV1.CurrentRow.Index].Disponible == false)
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
                    try
                    {
                        string nombre = VentanaAlquilar.tbNombreCliente.Text;
                        int Dni = Convert.ToInt32(VentanaAlquilar.tbDniCliente.Text);
                        long cuil = Convert.ToInt64(VentanaAlquilar.tbCuilCliente.Text);
                        string dir = VentanaAlquilar.tbDireccionCliente.Text;
                        int tel = Convert.ToInt32(VentanaAlquilar.tbTelefonoCliente.Text);
                        DateTime fechanac = VentanaAlquilar.dtpFechaNac.Value;
                        string estadocivil = VentanaAlquilar.tbEstadoCivilCliente.Text;
                        string nacionalidad = VentanaAlquilar.tbNacionalidadCliente.Text;
                        string carnet =VentanaAlquilar.tbCarnetCliente.Text;
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
                                    string carnet1 = (VentanaAlquilar.tbCarnetAcompañante1.Text);
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
                                    string carnet1 = (VentanaAlquilar.tbCarnetAcompañante1.Text);
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
                                    string carnet2 = (VentanaAlquilar.tbCarnetAcompañante2.Text);
                                    persona = new Cliente(nombre2, Dni2, cuil2, dir2, tel2, fechanac2, estadocivil2, nacionalidad2, carnet2);
                                    alquiler.agregarConductores(persona);
                                    break;

                                }


                        }


                        alquiler.Auto = SinChof[DGV1.CurrentRow.Index];
                        alquiler.InicioAlquiler = DateTime.Now;
                        alquiler.Auto.Disponible = false;
                        administracion.CargarAlquiler(alquiler);
                        administracion.VerHistorico().GrabarCSV(nombreArchivoHistorico);
                        DGV1.Rows.Clear();
                        
                        ActualizarListboxs();

                    }
                    catch (FormatException) { }

                }   


            }
            else {

                string ruta = ConChof[DGV1.CurrentRow.Index].Imagen;

                GenerarAlquiler VentanaAlquilar = new GenerarAlquiler();

                if (ConChof[DGV1.CurrentRow.Index].Disponible == false)
                {

                    VentanaAlquilar.gbCliente.Enabled = false;
                    VentanaAlquilar.btnAlquilar.Enabled = false;

                }
                else
                {

                    VentanaAlquilar.gbCliente.Enabled = true;
                    VentanaAlquilar.btnAlquilar.Enabled = true;

                }
                VentanaAlquilar.label11.Text = ((VehículoConChofer)(ConChof[DGV1.CurrentRow.Index])).UnChofer.DatosPersonales();
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
                    string carnet = (VentanaAlquilar.tbCarnetCliente.Text);
                    int cantidadConductores = VentanaAlquilar.comboBox1.SelectedIndex;

                    persona = new Cliente(nombre, Dni, cuil, dir, tel, fechanac, estadocivil, nacionalidad, carnet);

                    Alquiler alquiler = new Alquiler(persona);
                    alquiler.Auto = ConChof[DGV1.CurrentRow.Index];
                    alquiler.InicioAlquiler = DateTime.Now;
                    alquiler.Auto.Disponible = false;
                    administracion.CargarAlquiler(alquiler);
                    administracion.VerHistorico().GrabarCSV(nombreArchivoHistorico);
                    ActualizarListboxs();


                }


            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarListboxs();
           
        }

        private void PrintTicket_PrintPage(object sender, PrintPageEventArgs e)
        {
             AlquileresVigentes veralquileres = new AlquileresVigentes();

            try
            {
                /*string auto = administracion.GetAlquileres()[veralquileres.dgvAlquileres.CurrentRow.Index].Auto.Marca;
                string cliente = administracion.GetAlquileres()[veralquileres.dgvAlquileres.CurrentRow.Index].getClinete().Nombre;
                string dni = Convert.ToString(administracion.GetAlquileres()[veralquileres.dgvAlquileres.CurrentRow.Index].getClinete().Dni);
                string dias = Convert.ToString(administracion.GetAlquileres()[veralquileres.dgvAlquileres.CurrentRow.Index].DiasDeAlquiler);*/
                string preciofinal = Convert.ToString(precio);

                PaperSize paperSize = new PaperSize("My Envelope", 990, 500);
                paperSize.RawKind = (int)PaperKind.Custom;
                e.Graphics.DrawString(administracion.GetEmpresa().RazonSocial, new Font("MV Boli", 50, FontStyle.Bold), Brushes.Blue, new PointF(200, 100));
                e.Graphics.DrawString(administracion.GetEmpresa().DireccionFiscal, new Font("Times new Roman", 20, FontStyle.Bold), Brushes.Black, new PointF(30, 200));
                e.Graphics.DrawString("CUIL: " + administracion.GetEmpresa().Cuil.ToString(), new Font("Times new Roman", 20, FontStyle.Bold), Brushes.Black, new PointF(30, 250));
                e.Graphics.DrawString(devolucion.getClinete().Nombre, new Font("Times new Roman", 50, FontStyle.Bold), Brushes.Black, new PointF(30, 300));
                e.Graphics.DrawString(devolucion.Auto.Marca, new Font("Times new Roman", 50, FontStyle.Bold), Brushes.Black, new PointF(30, 400));
                e.Graphics.DrawString("Desde: "+devolucion.InicioAlquiler.ToShortDateString().ToString(), new Font("Times new Roman", 50, FontStyle.Bold), Brushes.Black, new PointF(30, 500));
                e.Graphics.DrawString("Hasta: "+DateTime.Now.ToShortDateString().ToString(), new Font("Times new Roman", 50, FontStyle.Bold), Brushes.Black, new PointF(30, 600));
                e.Graphics.DrawString("POR " + devolucion.DiasDeAlquiler + " DIAS", new Font("Times new Roman", 50, FontStyle.Bold), Brushes.Black, new PointF(30, 800));
                e.Graphics.DrawString("A PAGAR: " + preciofinal, new Font("Times new Roman", 50, FontStyle.Bold), Brushes.Black, new PointF(30, 900));
            }
            catch (NullReferenceException) { }
            }

        private void tbFiltro_TextChanged(object sender, EventArgs e)
        {

            DGV1.Rows.Clear();
            DataGridViewRow fila;
            
            try
            {
                if (cbChofer.SelectedIndex == 1)
                {
                    if (cbVehiculos.SelectedIndex == 0)
                    {
                        SinChof = (from v in administracion.GetVehículos() where ((v.Marca != null) && (v.Marca.StartsWith(tbFiltro.Text))) select v).ToList();

                    }
                    if (cbVehiculos.SelectedIndex == 1)
                    {
                        SinChof = (from v in administracion.GetVehículos() where (((v.Capacidad).ToString() != null) && ((v.Capacidad).ToString().StartsWith(tbFiltro.Text))) select v).ToList();

                    }
                    if (cbVehiculos.SelectedIndex == 2)
                    {
                        SinChof = (from v in administracion.GetVehículos() where ((v.Tipocombustible != null) && (v.Tipocombustible.StartsWith(tbFiltro.Text))) select v).ToList();

                    }




                    foreach (Vehículo v in SinChof)
                    {

                        fila = new DataGridViewRow();
                        fila.CreateCells(DGV1);
                        fila.Cells[CMARCA.Index].Value = v.Marca;
                        fila.Cells[CMOODELO.Index].Value = v.Modelo;
                        fila.Cells[CCAPACIDAD.Index].Value = v.Capacidad;
                        fila.Cells[CKMS.Index].Value = v.Kms;
                        fila.Cells[CPRECIO.Index].Value = ((v.UnidadDeCobro) * (administracion.Pesos));
                        if (v.Disponible == true)
                        {
                            fila.Cells[CDISPONIBILE.Index].Value = "Disponible";
                        }
                        else { fila.Cells[CDISPONIBILE.Index].Value = "Alquilado"; }


                        fila.Cells[CCOMBUSTIBLE.Index].Value = v.Tipocombustible;

                        DGV1.Rows.Add(fila);
                    }
                }
                else {
                    if (cbVehiculos.SelectedIndex == 0)
                    {
                        ConChof = (from v in administracion.GetVehiculosConChofer() where ((v.Marca != null) && (v.Marca.StartsWith(tbFiltro.Text))) select v).ToList();

                    }
                    if (cbVehiculos.SelectedIndex == 1)
                    {
                        ConChof = (from v in administracion.GetVehiculosConChofer() where (((v.Capacidad).ToString() != null) && ((v.Capacidad).ToString().StartsWith(tbFiltro.Text))) select v).ToList();

                    }
                    if (cbVehiculos.SelectedIndex == 2)
                    {
                        ConChof = (from v in administracion.GetVehiculosConChofer() where ((v.Tipocombustible != null) && (v.Tipocombustible.StartsWith(tbFiltro.Text))) select v).ToList();

                    }


                }

                foreach (Vehículo v in ConChof)
                {

                    fila = new DataGridViewRow();
                    fila.CreateCells(DGV1);
                    fila.Cells[CMARCA.Index].Value = v.Marca;
                    fila.Cells[CMOODELO.Index].Value = v.Modelo;
                    fila.Cells[CCAPACIDAD.Index].Value = v.Capacidad;
                    fila.Cells[CKMS.Index].Value = v.Kms;
                    fila.Cells[CPRECIO.Index].Value = ((v.UnidadDeCobro) * (administracion.Pesos));
                    if (v.Disponible == true)
                    {
                        fila.Cells[CDISPONIBILE.Index].Value = "Disponible";
                    }
                    else { fila.Cells[CDISPONIBILE.Index].Value = "Alquilado"; }


                    fila.Cells[CCOMBUSTIBLE.Index].Value = v.Tipocombustible;

                    DGV1.Rows.Add(fila);




                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }
    }
}
