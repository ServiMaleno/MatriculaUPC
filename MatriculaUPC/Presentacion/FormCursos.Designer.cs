namespace MatriculaUPC.Presentacion
{
    partial class FormCursos
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.txtCodigoCurso = new System.Windows.Forms.TextBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.txtCreditosCurso = new System.Windows.Forms.TextBox();
            this.btnAgregarCurso = new System.Windows.Forms.Button();
            this.dgvListarCursos = new System.Windows.Forms.DataGridView();
            this.btnAgregarAlumnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(114, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código del Curso:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(119, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del Curso:";
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Location = new System.Drawing.Point(20, 100);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(120, 16);
            this.lblCreditos.TabIndex = 2;
            this.lblCreditos.Text = "Créditos del Curso:";
            // 
            // txtCodigoCurso
            // 
            this.txtCodigoCurso.Location = new System.Drawing.Point(149, 17);
            this.txtCodigoCurso.Name = "txtCodigoCurso";
            this.txtCodigoCurso.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoCurso.TabIndex = 3;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(149, 57);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(208, 22);
            this.txtNombreCurso.TabIndex = 4;
            // 
            // txtCreditosCurso
            // 
            this.txtCreditosCurso.Location = new System.Drawing.Point(149, 97);
            this.txtCreditosCurso.Name = "txtCreditosCurso";
            this.txtCreditosCurso.Size = new System.Drawing.Size(57, 22);
            this.txtCreditosCurso.TabIndex = 5;
            // 
            // btnAgregarCurso
            // 
            this.btnAgregarCurso.Location = new System.Drawing.Point(119, 134);
            this.btnAgregarCurso.Name = "btnAgregarCurso";
            this.btnAgregarCurso.Size = new System.Drawing.Size(156, 40);
            this.btnAgregarCurso.TabIndex = 6;
            this.btnAgregarCurso.Text = "Agregar Curso";
            this.btnAgregarCurso.UseVisualStyleBackColor = true;
            this.btnAgregarCurso.Click += new System.EventHandler(this.btnAgregarCurso_Click);
            // 
            // dgvListarCursos
            // 
            this.dgvListarCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarCursos.Location = new System.Drawing.Point(20, 190);
            this.dgvListarCursos.Name = "dgvListarCursos";
            this.dgvListarCursos.RowHeadersWidth = 51;
            this.dgvListarCursos.Size = new System.Drawing.Size(400, 150);
            this.dgvListarCursos.TabIndex = 7;
            // 
            // btnAgregarAlumnos
            // 
            this.btnAgregarAlumnos.Location = new System.Drawing.Point(262, 357);
            this.btnAgregarAlumnos.Name = "btnAgregarAlumnos";
            this.btnAgregarAlumnos.Size = new System.Drawing.Size(158, 39);
            this.btnAgregarAlumnos.TabIndex = 8;
            this.btnAgregarAlumnos.Text = "Agregar Alumnos";
            this.btnAgregarAlumnos.UseVisualStyleBackColor = true;
            this.btnAgregarAlumnos.Click += new System.EventHandler(this.btnAgregarAlumnos_Click);
            // 
            // FormCursos
            // 
            this.ClientSize = new System.Drawing.Size(450, 411);
            this.Controls.Add(this.btnAgregarAlumnos);
            this.Controls.Add(this.dgvListarCursos);
            this.Controls.Add(this.btnAgregarCurso);
            this.Controls.Add(this.txtCreditosCurso);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.txtCodigoCurso);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FormCursos";
            this.Text = "Gestión de Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.TextBox txtCodigoCurso;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.TextBox txtCreditosCurso;
        private System.Windows.Forms.Button btnAgregarCurso;
        private System.Windows.Forms.DataGridView dgvListarCursos;
        private System.Windows.Forms.Button btnAgregarAlumnos;
    }
}