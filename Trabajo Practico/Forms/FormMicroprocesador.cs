using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico.Forms
{
    public partial class FormMicroprocesador : Form
    {
        public FormMicroprocesador()
        {
            InitializeComponent();
        }

        //Agregar evento right click y despliegue un menu con detalles, copiar los que aparecen en Hardcore al principio

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
