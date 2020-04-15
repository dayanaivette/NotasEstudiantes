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
    public partial class frmMaterias : Form
    {
        public frmMaterias()
        {
            InitializeComponent();
        }

        materia Materia = new materia();

        void cargardatos()
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                var Materia = db.materia;

                foreach (var iterardatosMateria in Materia)
                {
                    dtvMaterias.Rows.Add(iterardatosMateria.IdMateria, iterardatosMateria.nombre_materia);
                }
            }
        }

        void limpiardatos()
        {
            txtIDM.Text = "";
            txtNomM.Text = "";
        }
        private void btnGuardarM_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                Materia.nombre_materia = txtNomM.Text;
         
                db.materia.Add(Materia);
                db.SaveChanges();
            }
            dtvMaterias.Rows.Clear();
            cargardatos();
            limpiardatos();
        }

        private void btnActualizarM_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                String Id = dtvMaterias.CurrentRow.Cells[0].Value.ToString();
                int idC = int.Parse(Id);
                Materia = db.materia.Where(VerificarId => VerificarId.IdMateria == idC).First();
                Materia.nombre_materia = txtNomM.Text;
                db.Entry(Materia).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                string Id = dtvMaterias.CurrentRow.Cells[0].Value.ToString();
                int IdC = int.Parse(Id);
                Materia = db.materia.Where(VerificarId => VerificarId.IdMateria == IdC).First();
                Materia.nombre_materia = txtNomM.Text;
                db.Entry(Materia).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }





        //private void frmMaterias_Load(object sender, EventArgs e)
        //{
        //    using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
        //    {
        //        var JoinTablas = from mate in db.materia
        //                         where mate.IdMateria == mate.IdMateria

        //                         select new
        //                         {
        //                             IdMateria = mate.IdMateria,
        //                             NombreMateria = mate.nombre_materia
        //                         };
        //    }
        //}    
    }
}
