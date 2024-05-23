using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventandasybd.Data.DataAccess;

namespace ventandasybd
{
    public partial class Form1 : Form
    {
        //instancia ref a la clase personajeDB
        private PersonajeDB personaje;
        // Lista de razas
        private string[] razasDragonBall = {
    "Android",
    "Bio-Android",
    "Humana",
    "Humano",
    "Majin",
    "Namekuseijin",
    "Saiyajin",
    "Saiyajin/Humano",
    "Saiyajin/Saiyajin"
};
        public Form1()
        {
            InitializeComponent();
            personaje = new PersonajeDB();
        }

        private void botonPrueba_Click(object sender, EventArgs e)
        {
           if (personaje.ProbarConexion())
            {
                MessageBox.Show("good ending");
            }
            else
            {
                MessageBox.Show("Bad ending");
            }

        }

        private void cargar_Click(object sender, EventArgs e)
        {
            DataTable dt = personaje.LeerPersonajes();
            personajesdatos.DataSource = dt;
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNOMBRE.Text;
            string raza = comboBoxRaza.Text;
            int nivelpoder = (int)numericUpDownNIVELPODER.Value;
            DateTime fecha_creacion = DateTime.Now;
            string historia = historychanel.Text;

            int respuesta = personaje.CrearPersonaje(nombre, raza, nivelpoder, fecha_creacion, historia);
            if (respuesta > 0)
            {
                MessageBox.Show("Good ending x2");
                personajesdatos.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("BAD ENDING DE NUEVO");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxRaza.Items.AddRange(razasDragonBall);
        }

        private void BuscarPorId()
        {
            int idPersonajeBuscar = int.Parse(textBoxID.Text);
            DataTable personajeEncontrado = personaje.BuscarPersonajePorId(idPersonajeBuscar);
            if (personajeEncontrado.Rows.Count>0)
            {
                string nombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string raza = personajeEncontrado.Rows[0]["raza"].ToString();
                int nivelPoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());
                DateTime fecha_creacion = (DateTime)personajeEncontrado.Rows[0]["fecha_creacion"];
                string historia = personajeEncontrado.Rows[0]["historia"].ToString();


                textBoxNOMBRE.Text = nombre;
                comboBoxRaza.Text = raza;
                numericUpDownNIVELPODER.Value = nivelPoder;
                dateTimePickerfecha.Value = fecha_creacion;
                historychanel.Text = historia;
            }
            else
            {
                MessageBox.Show("No se encontro codigo");
            }
        }
        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            BuscarPorId();
        }

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            BuscarPorId();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            int respuesta = personaje.EliminarPersonaje(id);
            if (respuesta > 0)
            {
                MessageBox.Show("Personaje eliminado exitosamente.");
                personajesdatos.DataSource = personaje.LeerPersonajes(); 
            }
            else
            {
                MessageBox.Show("No se encontró el personaje con el ID proporcionado.");
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            string nombre = textBoxNOMBRE.Text;
            string raza = comboBoxRaza.Text;
            int nivelPoder = (int)numericUpDownNIVELPODER.Value;
            string historia = historychanel.Text;
            int respuesta = personaje.ActualizarPersonaje(id, nombre, raza, nivelPoder, historia);
            if (respuesta > 0)
            {
                MessageBox.Show("Good ending x3");
                personajesdatos.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("Bad ending por feo");
            }
        }
    }
}
