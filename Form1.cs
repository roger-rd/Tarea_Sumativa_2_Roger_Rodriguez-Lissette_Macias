using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Sumativa_2_Roger_Rodriguez_Lissette_Macias
{
    public partial class IngresoEstudiantes : Form
    {
        public IngresoEstudiantes()
        {
            InitializeComponent();
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "1234")
            {
                this.Hide();
                FormRUT cargar = new FormRUT();
                cargar.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "ADVERTENCIA");
            }
        }
    }
}
