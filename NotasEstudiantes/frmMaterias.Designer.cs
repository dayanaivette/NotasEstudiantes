namespace NotasEstudiantes
{
    partial class frmMaterias
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomM = new System.Windows.Forms.TextBox();
            this.btnGuardarM = new System.Windows.Forms.Button();
            this.btnActualizarM = new System.Windows.Forms.Button();
            this.dtvMaterias = new System.Windows.Forms.DataGridView();
            this.IdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDM = new System.Windows.Forms.TextBox();
            this.btnEliminarM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Materia";
            // 
            // txtNomM
            // 
            this.txtNomM.Location = new System.Drawing.Point(166, 87);
            this.txtNomM.Name = "txtNomM";
            this.txtNomM.Size = new System.Drawing.Size(158, 20);
            this.txtNomM.TabIndex = 3;
            // 
            // btnGuardarM
            // 
            this.btnGuardarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarM.Location = new System.Drawing.Point(97, 296);
            this.btnGuardarM.Name = "btnGuardarM";
            this.btnGuardarM.Size = new System.Drawing.Size(75, 32);
            this.btnGuardarM.TabIndex = 4;
            this.btnGuardarM.Text = "Guardar";
            this.btnGuardarM.UseVisualStyleBackColor = true;
            this.btnGuardarM.Click += new System.EventHandler(this.btnGuardarM_Click);
            // 
            // btnActualizarM
            // 
            this.btnActualizarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarM.Location = new System.Drawing.Point(201, 296);
            this.btnActualizarM.Name = "btnActualizarM";
            this.btnActualizarM.Size = new System.Drawing.Size(75, 32);
            this.btnActualizarM.TabIndex = 5;
            this.btnActualizarM.Text = "Actualizar";
            this.btnActualizarM.UseVisualStyleBackColor = true;
            this.btnActualizarM.Click += new System.EventHandler(this.btnActualizarM_Click);
            // 
            // dtvMaterias
            // 
            this.dtvMaterias.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMateria,
            this.NombreMateria});
            this.dtvMaterias.Location = new System.Drawing.Point(86, 123);
            this.dtvMaterias.Name = "dtvMaterias";
            this.dtvMaterias.Size = new System.Drawing.Size(312, 157);
            this.dtvMaterias.TabIndex = 6;
            // 
            // IdMateria
            // 
            this.IdMateria.HeaderText = "IdMateria";
            this.IdMateria.Name = "IdMateria";
            // 
            // NombreMateria
            // 
            this.NombreMateria.HeaderText = "NombreMateria";
            this.NombreMateria.Name = "NombreMateria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtIDM
            // 
            this.txtIDM.Location = new System.Drawing.Point(166, 44);
            this.txtIDM.Name = "txtIDM";
            this.txtIDM.Size = new System.Drawing.Size(158, 20);
            this.txtIDM.TabIndex = 2;
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarM.Location = new System.Drawing.Point(311, 296);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(75, 32);
            this.btnEliminarM.TabIndex = 7;
            this.btnEliminarM.Text = "Eliminar";
            this.btnEliminarM.UseVisualStyleBackColor = true;
            this.btnEliminarM.Click += new System.EventHandler(this.btnEliminarM_Click);
            // 
            // frmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.btnEliminarM);
            this.Controls.Add(this.dtvMaterias);
            this.Controls.Add(this.btnActualizarM);
            this.Controls.Add(this.btnGuardarM);
            this.Controls.Add(this.txtNomM);
            this.Controls.Add(this.txtIDM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMaterias";
            this.Text = "frmMaterias";
            ((System.ComponentModel.ISupportInitialize)(this.dtvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomM;
        private System.Windows.Forms.Button btnGuardarM;
        private System.Windows.Forms.Button btnActualizarM;
        private System.Windows.Forms.DataGridView dtvMaterias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMateria;
        private System.Windows.Forms.Button btnEliminarM;
    }
}