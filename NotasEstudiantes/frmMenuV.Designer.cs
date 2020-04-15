namespace NotasEstudiantes
{
    partial class frmMenuV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresoEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoNotasEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoEstudiantesToolStripMenuItem,
            this.materiaToolStripMenuItem,
            this.ingresoNotasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresoEstudiantesToolStripMenuItem
            // 
            this.ingresoEstudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosEstudianteToolStripMenuItem});
            this.ingresoEstudiantesToolStripMenuItem.Name = "ingresoEstudiantesToolStripMenuItem";
            this.ingresoEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.ingresoEstudiantesToolStripMenuItem.Text = "Ingreso Estudiantes";
            // 
            // datosEstudianteToolStripMenuItem
            // 
            this.datosEstudianteToolStripMenuItem.Name = "datosEstudianteToolStripMenuItem";
            this.datosEstudianteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datosEstudianteToolStripMenuItem.Text = "Datos Estudiante";
            this.datosEstudianteToolStripMenuItem.Click += new System.EventHandler(this.datosEstudianteToolStripMenuItem_Click);
            // 
            // materiaToolStripMenuItem
            // 
            this.materiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoMateriasToolStripMenuItem});
            this.materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            this.materiaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.materiaToolStripMenuItem.Text = "Materia";
            // 
            // mantenimientoMateriasToolStripMenuItem
            // 
            this.mantenimientoMateriasToolStripMenuItem.Name = "mantenimientoMateriasToolStripMenuItem";
            this.mantenimientoMateriasToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.mantenimientoMateriasToolStripMenuItem.Text = "Mantenimiento Materias";
            this.mantenimientoMateriasToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoMateriasToolStripMenuItem_Click);
            // 
            // ingresoNotasToolStripMenuItem
            // 
            this.ingresoNotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoNotasEstudianteToolStripMenuItem});
            this.ingresoNotasToolStripMenuItem.Name = "ingresoNotasToolStripMenuItem";
            this.ingresoNotasToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.ingresoNotasToolStripMenuItem.Text = "Ingreso Notas";
            // 
            // ingresoNotasEstudianteToolStripMenuItem
            // 
            this.ingresoNotasEstudianteToolStripMenuItem.Name = "ingresoNotasEstudianteToolStripMenuItem";
            this.ingresoNotasEstudianteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ingresoNotasEstudianteToolStripMenuItem.Text = "Ingreso Notas Estudiante";
            this.ingresoNotasEstudianteToolStripMenuItem.Click += new System.EventHandler(this.ingresoNotasEstudianteToolStripMenuItem_Click);
            // 
            // frmMenuV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuV";
            this.Text = "frmMenuV";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresoEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoNotasEstudianteToolStripMenuItem;
    }
}