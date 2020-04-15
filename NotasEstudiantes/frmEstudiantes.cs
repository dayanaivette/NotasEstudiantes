using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotasEstudiantes.MODEL;

namespace NotasEstudiantes
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
        {
            InitializeComponent();
        }

        estudiante alumno = new estudiante();

        void cargardatos()
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                dtvEstudiantes.DataSource = db.estudiante.ToList();
            }
        }
        void limpiardatos()
        {
            txtNomEstudiante.Text = "";
            txtApeEstudiante.Text = "";
            txtUsuE.Text = "";
            txtClaveE.Text = "";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                alumno.NombreEstudiante = txtNomEstudiante.Text;
                alumno.Apellido = txtApeEstudiante.Text;
                alumno.Usuario = txtUsuE.Text;
                alumno.Clave = txtClaveE.Text;
                db.estudiante.Add(alumno);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {

                alumno.NombreEstudiante = txtNomEstudiante.Text;
                alumno.Apellido = txtApeEstudiante.Text;
                alumno.Usuario = txtUsuE.Text;
                alumno.Clave = txtClaveE.Text;

                db.Entry(alumno).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void btnEliminarE_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                string Id = dtvEstudiantes.CurrentRow.Cells[0].Value.ToString();

                alumno = db.estudiante.Find(int.Parse(Id));
                db.estudiante.Remove(alumno);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }
    }
}
