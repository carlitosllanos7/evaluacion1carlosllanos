using gestion.BSS;
using gestion.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gestion.VISTAS.PersonasVistas
{
    public partial class PersonaInsertarVista : Form
    {
        public PersonaInsertarVista()
        {
            InitializeComponent();
        }
        personasbss bss = new personasbss();
        private void button1_Click_1(object sender, EventArgs e)
        {
            Personas p = new Personas();
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;

            bss.InsertarPersonaBss(p);
            MessageBox.Show("Se Guardo Correctamente");
        }
    }
}
