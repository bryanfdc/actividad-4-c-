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

namespace actividad_4_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApelido.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
            txtEstatus.Clear();
            txtNombre.Clear();
            rbFemenino.Checked = false;
            rbOtro.Checked = false;
            rbMasculino.Checked = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombre.Text;
            string apellido = txtApelido.Text;
            string telefono = txtTelefono.Text;
            string edad = txtEdad.Text;
            string estatus = txtEstatus.Text;
            string genero = "";
            if (rbMasculino.Checked)
            {
                genero = "masculino";
            }
            else if (rbFemenino.Checked)
            {
                genero = "femenino";
            }
            else if (rbOtro.Checked)
            {
                genero = "pinche jochis";
            }
            string mensaje = $"Nombres: {nombres}\nApellidos: {apellido}\n" +
        $"Genero: {genero}\nEdad: {edad}\nTelefono: {telefono}\nEstatura:{estatus}\n\n";

            //Ruta del almacenamiento de archivo TXT
            //string rutaFile = "C:/Users/diazc/Documents/Datos.txt";
            string rutaFile = "C:\\Users\\diazc\\Documents\\trabajosc#\\Datos.txt";

            //Valor de verificación de archivo existen
            bool ArchivoExiste = File.Exists(rutaFile);

            /// Instanciacion de la Clase/objeto StreamWriter para escribir archivo TXT
            using (StreamWriter Escritor = new StreamWriter(rutaFile, true))
            {
                if (ArchivoExiste)
                {
                    Escritor.WriteLine();
                }
                Escritor.WriteLine(mensaje);
            }

            MessageBox.Show(mensaje, "Registros de Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
