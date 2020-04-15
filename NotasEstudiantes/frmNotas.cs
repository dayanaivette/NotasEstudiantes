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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        notas N = new notas();

        void cargardatos()
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            { 
                

                    db.notas.Add(N);
                    db.SaveChanges();
                
                cargardatos();
                limpiardatos();
                dtvNotas.Rows.Clear();

            }
        }
        void limpiardatos()
        {
            txtIDN.Text = "";
            txtIDNE.Text = "";
            txtIDNM.Text = "";
            txtNotas.Text = "";
        }

        private void btnGuardarN_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                //Double nota = dtvNotas.CurrentRow.Cells[0].Value.ToDouble();
                //string notaC = int.Parse(nota);
                //N = db.notas.Where(Verificarnota => Verificarnota.nota == notaC).First();
                //N.nota = txtNotas.Text;

                db.notas.Add(N);
                db.SaveChanges();
            }
            dtvNotas.Rows.Clear();
            cargardatos();
            limpiardatos();
        }


    }
}
