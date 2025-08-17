namespace Roll_Call
{
    partial class Alumnoss
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
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnAñadirAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscadorAlumnos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 51F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 115);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumnos";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(108, 265);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersWidth = 62;
            this.dgvAlumnos.Size = new System.Drawing.Size(2120, 1006);
            this.dgvAlumnos.TabIndex = 1;
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellContentClick);
            // 
            // btnAñadirAlumno
            // 
            this.btnAñadirAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAñadirAlumno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAñadirAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnAñadirAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAñadirAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirAlumno.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirAlumno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAñadirAlumno.Location = new System.Drawing.Point(112, 1386);
            this.btnAñadirAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAñadirAlumno.Name = "btnAñadirAlumno";
            this.btnAñadirAlumno.Size = new System.Drawing.Size(570, 111);
            this.btnAñadirAlumno.TabIndex = 2;
            this.btnAñadirAlumno.Text = "Añadir";
            this.btnAñadirAlumno.UseVisualStyleBackColor = false;
            this.btnAñadirAlumno.Click += new System.EventHandler(this.btnAñadirAlumno_Click);
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarAlumno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnModificarAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnModificarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAlumno.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarAlumno.Location = new System.Drawing.Point(900, 1386);
            this.btnModificarAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(570, 111);
            this.btnModificarAlumno.TabIndex = 3;
            this.btnModificarAlumno.Text = "Modificar";
            this.btnModificarAlumno.UseVisualStyleBackColor = false;
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarAlumno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnEliminarAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnEliminarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarAlumno.Location = new System.Drawing.Point(1658, 1386);
            this.btnEliminarAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(570, 111);
            this.btnEliminarAlumno.TabIndex = 4;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Roll_Call.Properties.Resources.BuscadorIcono;
            this.pictureBox1.Location = new System.Drawing.Point(1342, 105);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 111);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscadorAlumnos
            // 
            this.txtBuscadorAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscadorAlumnos.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscadorAlumnos.Location = new System.Drawing.Point(1473, 129);
            this.txtBuscadorAlumnos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscadorAlumnos.Multiline = true;
            this.txtBuscadorAlumnos.Name = "txtBuscadorAlumnos";
            this.txtBuscadorAlumnos.Size = new System.Drawing.Size(712, 86);
            this.txtBuscadorAlumnos.TabIndex = 6;
            // 
            // Alumnoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Roll_Call.Properties.Resources.gris_patron;
            this.ClientSize = new System.Drawing.Size(2331, 1545);
            this.Controls.Add(this.txtBuscadorAlumnos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminarAlumno);
            this.Controls.Add(this.btnModificarAlumno);
            this.Controls.Add(this.btnAñadirAlumno);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Alumnoss";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnAñadirAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscadorAlumnos;
    }
}