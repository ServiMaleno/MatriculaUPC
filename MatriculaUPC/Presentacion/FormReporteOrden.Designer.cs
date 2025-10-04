namespace MatriculaUPC.Presentacion
{
    partial class FormReporteOrden
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
            this.btnAscendente = new System.Windows.Forms.Button();
            this.btnDescendente = new System.Windows.Forms.Button();
            this.dgvAlumnosOrdenados = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosOrdenados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAscendente
            // 
            this.btnAscendente.Location = new System.Drawing.Point(57, 33);
            this.btnAscendente.Name = "btnAscendente";
            this.btnAscendente.Size = new System.Drawing.Size(215, 35);
            this.btnAscendente.TabIndex = 0;
            this.btnAscendente.Text = "Ordenar Ascendentemente";
            this.btnAscendente.UseVisualStyleBackColor = true;
            this.btnAscendente.Click += new System.EventHandler(this.btnAscendente_Click);
            // 
            // btnDescendente
            // 
            this.btnDescendente.Location = new System.Drawing.Point(315, 33);
            this.btnDescendente.Name = "btnDescendente";
            this.btnDescendente.Size = new System.Drawing.Size(215, 35);
            this.btnDescendente.TabIndex = 1;
            this.btnDescendente.Text = "Ordenar Descendentemente";
            this.btnDescendente.UseVisualStyleBackColor = true;
            this.btnDescendente.Click += new System.EventHandler(this.btnDescendente_Click);
            // 
            // dgvAlumnosOrdenados
            // 
            this.dgvAlumnosOrdenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosOrdenados.Location = new System.Drawing.Point(57, 108);
            this.dgvAlumnosOrdenados.Name = "dgvAlumnosOrdenados";
            this.dgvAlumnosOrdenados.RowHeadersWidth = 51;
            this.dgvAlumnosOrdenados.RowTemplate.Height = 24;
            this.dgvAlumnosOrdenados.Size = new System.Drawing.Size(473, 246);
            this.dgvAlumnosOrdenados.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(236, 372);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 36);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormReporteOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 431);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvAlumnosOrdenados);
            this.Controls.Add(this.btnDescendente);
            this.Controls.Add(this.btnAscendente);
            this.Name = "FormReporteOrden";
            this.Text = "Ordenar Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosOrdenados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAscendente;
        private System.Windows.Forms.Button btnDescendente;
        private System.Windows.Forms.DataGridView dgvAlumnosOrdenados;
        private System.Windows.Forms.Button btnSalir;
    }
}