using System.Windows.Forms;

namespace MatriculaUPC.Presentacion
{
    partial class FormReportes
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
            this.btnCursoMasAlumnos = new System.Windows.Forms.Button();
            this.btnBuscarCurso = new System.Windows.Forms.Button();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.txtBuscarCurso = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCursoMasAlumnos
            // 
            this.btnCursoMasAlumnos.Location = new System.Drawing.Point(20, 20);
            this.btnCursoMasAlumnos.Name = "btnCursoMasAlumnos";
            this.btnCursoMasAlumnos.Size = new System.Drawing.Size(200, 40);
            this.btnCursoMasAlumnos.TabIndex = 0;
            this.btnCursoMasAlumnos.Text = "Curso con Más Alumnos";
            this.btnCursoMasAlumnos.UseVisualStyleBackColor = true;
            this.btnCursoMasAlumnos.Click += new System.EventHandler(this.btnCursoMasAlumnos_Click);
            // 
            // btnBuscarCurso
            // 
            this.btnBuscarCurso.Location = new System.Drawing.Point(340, 75);
            this.btnBuscarCurso.Name = "btnBuscarCurso";
            this.btnBuscarCurso.Size = new System.Drawing.Size(100, 30);
            this.btnBuscarCurso.TabIndex = 3;
            this.btnBuscarCurso.Text = "Buscar";
            this.btnBuscarCurso.UseVisualStyleBackColor = true;
            this.btnBuscarCurso.Click += new System.EventHandler(this.btnBuscarCurso_Click);
            // 
            // dgvReportes
            // 
            this.dgvReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportes.ColumnHeadersHeight = 29;
            this.dgvReportes.Location = new System.Drawing.Point(20, 130);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.RowHeadersWidth = 51;
            this.dgvReportes.Size = new System.Drawing.Size(420, 200);
            this.dgvReportes.TabIndex = 4;
            // 
            // txtBuscarCurso
            // 
            this.txtBuscarCurso.Location = new System.Drawing.Point(180, 80);
            this.txtBuscarCurso.Name = "txtBuscarCurso";
            this.txtBuscarCurso.Size = new System.Drawing.Size(150, 22);
            this.txtBuscarCurso.TabIndex = 2;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Location = new System.Drawing.Point(20, 80);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(150, 20);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Código:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(340, 354);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 34);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormReportes
            // 
            this.ClientSize = new System.Drawing.Size(470, 400);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCursoMasAlumnos);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscarCurso);
            this.Controls.Add(this.btnBuscarCurso);
            this.Controls.Add(this.dgvReportes);
            this.Name = "FormReportes";
            this.Text = "Reportes de Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCursoMasAlumnos;
        private System.Windows.Forms.Button btnBuscarCurso;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.TextBox txtBuscarCurso;
        private System.Windows.Forms.Label lblBuscar;
        private Button btnSalir;
    }
}