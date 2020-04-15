namespace NotasEstudiantes
{
    partial class frmNotas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDN = new System.Windows.Forms.TextBox();
            this.txtIDNE = new System.Windows.Forms.TextBox();
            this.txtIDNM = new System.Windows.Forms.TextBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.btnGuardarN = new System.Windows.Forms.Button();
            this.btnActualizarN = new System.Windows.Forms.Button();
            this.btnEliminarN = new System.Windows.Forms.Button();
            this.dtvNotas = new System.Windows.Forms.DataGridView();
            this.IDNotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Notas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Estudiante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Materia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota";
            // 
            // txtIDN
            // 
            this.txtIDN.Location = new System.Drawing.Point(129, 33);
            this.txtIDN.Name = "txtIDN";
            this.txtIDN.Size = new System.Drawing.Size(113, 20);
            this.txtIDN.TabIndex = 4;
            // 
            // txtIDNE
            // 
            this.txtIDNE.Location = new System.Drawing.Point(129, 74);
            this.txtIDNE.Name = "txtIDNE";
            this.txtIDNE.Size = new System.Drawing.Size(113, 20);
            this.txtIDNE.TabIndex = 5;
            // 
            // txtIDNM
            // 
            this.txtIDNM.Location = new System.Drawing.Point(129, 113);
            this.txtIDNM.Name = "txtIDNM";
            this.txtIDNM.Size = new System.Drawing.Size(113, 20);
            this.txtIDNM.TabIndex = 6;
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(129, 151);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(113, 20);
            this.txtNotas.TabIndex = 7;
            // 
            // btnGuardarN
            // 
            this.btnGuardarN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarN.Location = new System.Drawing.Point(424, 33);
            this.btnGuardarN.Name = "btnGuardarN";
            this.btnGuardarN.Size = new System.Drawing.Size(75, 30);
            this.btnGuardarN.TabIndex = 8;
            this.btnGuardarN.Text = "Guardar";
            this.btnGuardarN.UseVisualStyleBackColor = true;
            this.btnGuardarN.Click += new System.EventHandler(this.btnGuardarN_Click);
            // 
            // btnActualizarN
            // 
            this.btnActualizarN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarN.Location = new System.Drawing.Point(424, 88);
            this.btnActualizarN.Name = "btnActualizarN";
            this.btnActualizarN.Size = new System.Drawing.Size(75, 28);
            this.btnActualizarN.TabIndex = 9;
            this.btnActualizarN.Text = "Actualizar";
            this.btnActualizarN.UseVisualStyleBackColor = true;
            // 
            // btnEliminarN
            // 
            this.btnEliminarN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarN.Location = new System.Drawing.Point(424, 142);
            this.btnEliminarN.Name = "btnEliminarN";
            this.btnEliminarN.Size = new System.Drawing.Size(75, 29);
            this.btnEliminarN.TabIndex = 10;
            this.btnEliminarN.Text = "Eliminar";
            this.btnEliminarN.UseVisualStyleBackColor = true;
            // 
            // dtvNotas
            // 
            this.dtvNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvNotas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDNotas,
            this.NombreEstudiante,
            this.NombreMateria,
            this.Nota});
            this.dtvNotas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dtvNotas.Location = new System.Drawing.Point(67, 192);
            this.dtvNotas.Name = "dtvNotas";
            this.dtvNotas.Size = new System.Drawing.Size(416, 150);
            this.dtvNotas.TabIndex = 11;
            // 
            // IDNotas
            // 
            this.IDNotas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IDNotas.HeaderText = "IDNotas";
            this.IDNotas.Name = "IDNotas";
            this.IDNotas.Width = 71;
            // 
            // NombreEstudiante
            // 
            this.NombreEstudiante.HeaderText = "Nombre Estudiante";
            this.NombreEstudiante.Name = "NombreEstudiante";
            // 
            // NombreMateria
            // 
            this.NombreMateria.HeaderText = "Nombre Materia";
            this.NombreMateria.Name = "NombreMateria";
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 377);
            this.Controls.Add(this.dtvNotas);
            this.Controls.Add(this.btnEliminarN);
            this.Controls.Add(this.btnActualizarN);
            this.Controls.Add(this.btnGuardarN);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.txtIDNM);
            this.Controls.Add(this.txtIDNE);
            this.Controls.Add(this.txtIDN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dtvNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDN;
        private System.Windows.Forms.TextBox txtIDNE;
        private System.Windows.Forms.TextBox txtIDNM;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Button btnGuardarN;
        private System.Windows.Forms.Button btnActualizarN;
        private System.Windows.Forms.Button btnEliminarN;
        private System.Windows.Forms.DataGridView dtvNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
    }
}