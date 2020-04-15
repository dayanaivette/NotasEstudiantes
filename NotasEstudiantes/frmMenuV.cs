using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotasEstudiantes
{
    public partial class frmMenuV : Form
    {
        public frmMenuV()

        {
            InitializeComponent();
        }

        private void datosEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstudiantes alumno = new frmEstudiantes();
            alumno.Show();
        }

        private void mantenimientoMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterias materia = new frmMaterias();
            materia.Show();
        }

        private void ingresoNotasEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotas nota = new frmNotas();
            nota.Show();
        }
    }
}
