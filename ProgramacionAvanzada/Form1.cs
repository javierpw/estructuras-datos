using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregar:
using System.Collections;

namespace ProgramacionAvanzada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            List<string> personas = new List<string>();

            //LISTA. Agregar, eliminar y ordenar.
            //Agregar con Add
            personas.Add("Kevin");
            personas.Add("Aba");
            personas.Add("Maria");

            //agregar elementos mediante: Insert. Nos pide la posición
            personas.Insert(0, "Pepe");
            
            //eliminar elemento
            personas.Remove("Maria");

            personas.Sort();

            foreach (string persona in personas)
            {
                listBox1.Items.Add(persona);
            }
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            //Al ser una pila solo podemos quitar el elemento superior
            Stack miPila = new Stack();
            //Agregar
            miPila.Push("Jorge");
            miPila.Push("Maria");
            miPila.Push("Tresh");
            miPila.Pop();


            foreach (string persona in miPila)
            {
                listBox2.Items.Add(persona);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ubicacion = Environment.CurrentDirectory + "\\imagen.gif";
            pictureBox1.Image = Image.FromFile(ubicacion);
        }

    }
}
