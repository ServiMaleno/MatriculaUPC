namespace MatriculaUPC.Presentacion
{
    partial class FormInicio
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
            this.registroDeCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarYCursoMasAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeCursosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroDeCursosToolStripMenuItem
            // 
            this.registroDeCursosToolStripMenuItem.Name = "registroDeCursosToolStripMenuItem";
            this.registroDeCursosToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.registroDeCursosToolStripMenuItem.Text = "Registro de Cursos";
            this.registroDeCursosToolStripMenuItem.Click += new System.EventHandler(this.registroDeCursosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarYCursoMasAlumnosToolStripMenuItem,
            this.ordenarAlumnosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // buscarYCursoMasAlumnosToolStripMenuItem
            // 
            this.buscarYCursoMasAlumnosToolStripMenuItem.Name = "buscarYCursoMasAlumnosToolStripMenuItem";
            this.buscarYCursoMasAlumnosToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.buscarYCursoMasAlumnosToolStripMenuItem.Text = "Buscar y CursoMasAlumnos";
            this.buscarYCursoMasAlumnosToolStripMenuItem.Click += new System.EventHandler(this.buscarYCursoMasAlumnosToolStripMenuItem_Click);
            // 
            // ordenarAlumnosToolStripMenuItem
            // 
            this.ordenarAlumnosToolStripMenuItem.Name = "ordenarAlumnosToolStripMenuItem";
            this.ordenarAlumnosToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.ordenarAlumnosToolStripMenuItem.Text = "Ordenar Alumnos";
            this.ordenarAlumnosToolStripMenuItem.Click += new System.EventHandler(this.ordenarAlumnosToolStripMenuItem_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 272);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInicio";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroDeCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarYCursoMasAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarAlumnosToolStripMenuItem;
    }
}

