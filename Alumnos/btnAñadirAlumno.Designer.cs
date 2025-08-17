namespace Roll_Call.Alumnos
{
    partial class btnAñadirAlumno
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
            this.panelbtnAlumno = new System.Windows.Forms.Panel();
            this.checkMateria = new System.Windows.Forms.CheckedListBox();
            this.btnSalirAlumno = new System.Windows.Forms.Button();
            this.btnGuardarAlumno = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.panelbtnAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelbtnAlumno
            // 
            this.panelbtnAlumno.BackColor = System.Drawing.Color.White;
            this.panelbtnAlumno.Controls.Add(this.txtFechaNac);
            this.panelbtnAlumno.Controls.Add(this.checkMateria);
            this.panelbtnAlumno.Controls.Add(this.btnSalirAlumno);
            this.panelbtnAlumno.Controls.Add(this.btnGuardarAlumno);
            this.panelbtnAlumno.Controls.Add(this.txtCorreo);
            this.panelbtnAlumno.Controls.Add(this.txtApellidos);
            this.panelbtnAlumno.Controls.Add(this.txtNombre);
            this.panelbtnAlumno.Controls.Add(this.label7);
            this.panelbtnAlumno.Controls.Add(this.label6);
            this.panelbtnAlumno.Controls.Add(this.label5);
            this.panelbtnAlumno.Controls.Add(this.label4);
            this.panelbtnAlumno.Controls.Add(this.label3);
            this.panelbtnAlumno.Controls.Add(this.label1);
            this.panelbtnAlumno.Location = new System.Drawing.Point(48, 118);
            this.panelbtnAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelbtnAlumno.Name = "panelbtnAlumno";
            this.panelbtnAlumno.Size = new System.Drawing.Size(652, 846);
            this.panelbtnAlumno.TabIndex = 0;
            this.panelbtnAlumno.Paint += new System.Windows.Forms.PaintEventHandler(this.panelbtnAlumno_Paint);
            this.panelbtnAlumno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelbtnAlumno_MouseDown);
            // 
            // checkMateria
            // 
            this.checkMateria.FormattingEnabled = true;
            this.checkMateria.Location = new System.Drawing.Point(87, 586);
            this.checkMateria.Name = "checkMateria";
            this.checkMateria.Size = new System.Drawing.Size(480, 96);
            this.checkMateria.TabIndex = 15;
            this.checkMateria.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnSalirAlumno
            // 
            this.btnSalirAlumno.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalirAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirAlumno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAlumno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalirAlumno.Location = new System.Drawing.Point(368, 760);
            this.btnSalirAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalirAlumno.Name = "btnSalirAlumno";
            this.btnSalirAlumno.Size = new System.Drawing.Size(240, 58);
            this.btnSalirAlumno.TabIndex = 14;
            this.btnSalirAlumno.Text = "Salir";
            this.btnSalirAlumno.UseVisualStyleBackColor = false;
            this.btnSalirAlumno.Click += new System.EventHandler(this.btnSalirAlumno_Click);
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuardarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAlumno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAlumno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarAlumno.Location = new System.Drawing.Point(66, 760);
            this.btnGuardarAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(240, 58);
            this.btnGuardarAlumno.TabIndex = 13;
            this.btnGuardarAlumno.Text = "Guardar";
            this.btnGuardarAlumno.UseVisualStyleBackColor = false;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(87, 484);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(482, 43);
            this.txtCorreo.TabIndex = 11;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(87, 283);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(482, 43);
            this.txtApellidos.TabIndex = 9;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(90, 185);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(482, 43);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 545);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Materias:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 443);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de nacimiento:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellidos:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Añadir alumno";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Roll_Call.Properties.Resources.decoracion;
            this.pictureBox1.Location = new System.Drawing.Point(256, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 123);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtFechaNac.Location = new System.Drawing.Point(100, 374);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(472, 26);
            this.txtFechaNac.TabIndex = 16;
            this.txtFechaNac.ValueChanged += new System.EventHandler(this.txtFechaNac_ValueChanged);
            // 
            // btnAñadirAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(753, 1000);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelbtnAlumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "btnAñadirAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "btnAñadirAlumno";
            this.Load += new System.EventHandler(this.btnAñadirAlumno_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAñadirAlumno_MouseDown);
            this.panelbtnAlumno.ResumeLayout(false);
            this.panelbtnAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelbtnAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalirAlumno;
        private System.Windows.Forms.Button btnGuardarAlumno;
        private System.Windows.Forms.CheckedListBox checkMateria;
        private System.Windows.Forms.DateTimePicker txtFechaNac;
    }
}