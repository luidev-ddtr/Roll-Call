namespace Roll_Call.Historial
{
    partial class ModificarHistoriall
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtpBuscarFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxMateria = new System.Windows.Forms.ComboBox();
            this.btnSalirModificaciones = new System.Windows.Forms.Button();
            this.btnGuardarModificaiones = new System.Windows.Forms.Button();
            this.dvgModificarAsistencias = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgModificarAsistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 51F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(922, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modificar Lista de Asistencias";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Roll_Call.Properties.Resources.decoracion;
            this.pictureBox1.Location = new System.Drawing.Point(20, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 84);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dtpBuscarFecha);
            this.panel5.Controls.Add(this.cbxMateria);
            this.panel5.Controls.Add(this.btnSalirModificaciones);
            this.panel5.Controls.Add(this.btnGuardarModificaiones);
            this.panel5.Controls.Add(this.dvgModificarAsistencias);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(50, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1462, 942);
            this.panel5.TabIndex = 29;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // dtpBuscarFecha
            // 
            this.dtpBuscarFecha.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBuscarFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscarFecha.Location = new System.Drawing.Point(138, 121);
            this.dtpBuscarFecha.Name = "dtpBuscarFecha";
            this.dtpBuscarFecha.Size = new System.Drawing.Size(603, 35);
            this.dtpBuscarFecha.TabIndex = 38;
            this.dtpBuscarFecha.ValueChanged += new System.EventHandler(this.dtpBuscarFecha_ValueChanged);
            // 
            // cbxMateria
            // 
            this.cbxMateria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMateria.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMateria.FormattingEnabled = true;
            this.cbxMateria.Location = new System.Drawing.Point(949, 123);
            this.cbxMateria.Name = "cbxMateria";
            this.cbxMateria.Size = new System.Drawing.Size(491, 33);
            this.cbxMateria.TabIndex = 37;
            this.cbxMateria.SelectedIndexChanged += new System.EventHandler(this.cbxMateria_SelectedIndexChanged);
            // 
            // btnSalirModificaciones
            // 
            this.btnSalirModificaciones.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalirModificaciones.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalirModificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirModificaciones.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirModificaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalirModificaciones.Location = new System.Drawing.Point(786, 813);
            this.btnSalirModificaciones.Name = "btnSalirModificaciones";
            this.btnSalirModificaciones.Size = new System.Drawing.Size(380, 72);
            this.btnSalirModificaciones.TabIndex = 35;
            this.btnSalirModificaciones.Text = "Salir";
            this.btnSalirModificaciones.UseVisualStyleBackColor = false;
            this.btnSalirModificaciones.Click += new System.EventHandler(this.btnSalirModificaciones_Click);
            // 
            // btnGuardarModificaiones
            // 
            this.btnGuardarModificaiones.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuardarModificaiones.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuardarModificaiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarModificaiones.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModificaiones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarModificaiones.Location = new System.Drawing.Point(308, 813);
            this.btnGuardarModificaiones.Name = "btnGuardarModificaiones";
            this.btnGuardarModificaiones.Size = new System.Drawing.Size(380, 72);
            this.btnGuardarModificaiones.TabIndex = 34;
            this.btnGuardarModificaiones.Text = "Guardar";
            this.btnGuardarModificaiones.UseVisualStyleBackColor = false;
            this.btnGuardarModificaiones.Click += new System.EventHandler(this.btnGuardarModificaiones_Click);
            // 
            // dvgModificarAsistencias
            // 
            this.dvgModificarAsistencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgModificarAsistencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dvgModificarAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgModificarAsistencias.DefaultCellStyle = dataGridViewCellStyle12;
            this.dvgModificarAsistencias.Location = new System.Drawing.Point(26, 191);
            this.dvgModificarAsistencias.Name = "dvgModificarAsistencias";
            this.dvgModificarAsistencias.Size = new System.Drawing.Size(1414, 591);
            this.dvgModificarAsistencias.TabIndex = 36;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(829, 162);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(611, 10);
            this.panel4.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 35);
            this.label2.TabIndex = 30;
            this.label2.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(823, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 35);
            this.label5.TabIndex = 32;
            this.label5.Text = "Materia:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(22, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 10);
            this.panel1.TabIndex = 31;
            // 
            // ModificarHistoriall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1554, 1003);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarHistoriall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "btnModificarHistorial";
            this.Load += new System.EventHandler(this.ModificarHistoriall_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModificarHistoriall_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgModificarAsistencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtpBuscarFecha;
        private System.Windows.Forms.ComboBox cbxMateria;
        private System.Windows.Forms.Button btnSalirModificaciones;
        private System.Windows.Forms.Button btnGuardarModificaiones;
        private System.Windows.Forms.DataGridView dvgModificarAsistencias;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}