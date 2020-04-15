namespace NotasEstudiantes
{
    partial class frmEstudiantes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNomEstudiante = new System.Windows.Forms.TextBox();
            this.txtApeEstudiante = new System.Windows.Forms.TextBox();
            this.txtUsuE = new System.Windows.Forms.TextBox();
            this.txtClaveE = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtvEstudiantes = new System.Windows.Forms.DataGridView();
            this.IdEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomEstudiante
            // 
            this.txtNomEstudiante.Location = new System.Drawing.Point(164, 42);
            this.txtNomEstudiante.Name = "txtNomEstudiante";
            this.txtNomEstudiante.Size = new System.Drawing.Size(187, 20);
            this.txtNomEstudiante.TabIndex = 0;
            // 
            // txtApeEstudiante
            // 
            this.txtApeEstudiante.Location = new System.Drawing.Point(164, 94);
            this.txtApeEstudiante.Name = "txtApeEstudiante";
            this.txtApeEstudiante.Size = new System.Drawing.Size(187, 20);
            this.txtApeEstudiante.TabIndex = 1;
            // 
            // txtUsuE
            // 
            this.txtUsuE.Location = new System.Drawing.Point(164, 144);
            this.txtUsuE.Name = "txtUsuE";
            this.txtUsuE.Size = new System.Drawing.Size(187, 20);
            this.txtUsuE.TabIndex = 2;
            // 
            // txtClaveE
            // 
            this.txtClaveE.Location = new System.Drawing.Point(164, 192);
            this.txtClaveE.Name = "txtClaveE";
            this.txtClaveE.Size = new System.Drawing.Size(187, 20);
            this.txtClaveE.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(462, 63);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 31);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(462, 115);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 31);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido Estudiante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Clave";
            // 
            // dtvEstudiantes
            // 
            this.dtvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtvEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEstudiante,
            this.NombreEstudiante,
            this.ApellidoEstudiante,
            this.Usu,
            this.Usuario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvEstudiantes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtvEstudiantes.Location = new System.Drawing.Point(23, 231);
            this.dtvEstudiantes.Name = "dtvEstudiantes";
            this.dtvEstudiantes.Size = new System.Drawing.Size(538, 187);
            this.dtvEstudiantes.TabIndex = 10;
            // 
            // IdEstudiante
            // 
            this.IdEstudiante.HeaderText = "IdEstudiante";
            this.IdEstudiante.Name = "IdEstudiante";
            // 
            // NombreEstudiante
            // 
            this.NombreEstudiante.HeaderText = "NombreEstudiante";
            this.NombreEstudiante.Name = "NombreEstudiante";
            // 
            // ApellidoEstudiante
            // 
            this.ApellidoEstudiante.HeaderText = "ApellidoEstudiante";
            this.ApellidoEstudiante.Name = "ApellidoEstudiante";
            // 
            // Usu
            // 
            this.Usu.HeaderText = "Usuario";
            this.Usu.Name = "Usu";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Clave";
            this.Usuario.Name = "Usuario";
            // 
            // btnEliminarE
            // 
            this.btnEliminarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarE.Location = new System.Drawing.Point(462, 165);
            this.btnEliminarE.Name = "btnEliminarE";
            this.btnEliminarE.Size = new System.Drawing.Size(75, 31);
            this.btnEliminarE.TabIndex = 11;
            this.btnEliminarE.Text = "Eliminar";
            this.btnEliminarE.UseVisualStyleBackColor = true;
            this.btnEliminarE.Click += new System.EventHandler(this.btnEliminarE_Click);
            // 
            // frmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 445);
            this.Controls.Add(this.btnEliminarE);
            this.Controls.Add(this.dtvEstudiantes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtClaveE);
            this.Controls.Add(this.txtUsuE);
            this.Controls.Add(this.txtApeEstudiante);
            this.Controls.Add(this.txtNomEstudiante);
            this.Name = "frmEstudiantes";
            this.Text = "frmEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.dtvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomEstudiante;
        private System.Windows.Forms.TextBox txtApeEstudiante;
        private System.Windows.Forms.TextBox txtUsuE;
        private System.Windows.Forms.TextBox txtClaveE;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtvEstudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.Button btnEliminarE;
    }
}