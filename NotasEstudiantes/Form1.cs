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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                var lista = from estudiante in db.estudiante
                            where estudiante.Usuario == txtUsuario.Text
                            && estudiante.Clave == txtClave.Text
                            select estudiante;

                if (lista.Count() > 0)
                {
                    frmMenuV menu = new frmMenuV();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("El Usuario no existe");
                }
            }

        }
    }
}
