namespace Roll_Call
{
    partial class Historiall
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarHistorial = new System.Windows.Forms.Button();
            this.btnEliminarHistorial = new System.Windows.Forms.Button();
            this.dtpBuscarFecha = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 51F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historial de Asistencias";
            // 
            // btnModificarHistorial
            // 
            this.btnModificarHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarHistorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnModificarHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnModificarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarHistorial.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarHistorial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarHistorial.Location = new System.Drawing.Point(224, 896);
            this.btnModificarHistorial.Name = "btnModificarHistorial";
            this.btnModificarHistorial.Size = new System.Drawing.Size(380, 72);
            this.btnModificarHistorial.TabIndex = 2;
            this.btnModificarHistorial.Text = "Modificar";
            this.btnModificarHistorial.UseVisualStyleBackColor = false;
            this.btnModificarHistorial.Click += new System.EventHandler(this.btnModificarHistorial_Click);
            // 
            // btnEliminarHistorial
            // 
            this.btnEliminarHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarHistorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnEliminarHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnEliminarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarHistorial.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHistorial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarHistorial.Location = new System.Drawing.Point(960, 896);
            this.btnEliminarHistorial.Name = "btnEliminarHistorial";
            this.btnEliminarHistorial.Size = new System.Drawing.Size(380, 72);
            this.btnEliminarHistorial.TabIndex = 3;
            this.btnEliminarHistorial.Text = "Eliminar";
            this.btnEliminarHistorial.UseVisualStyleBackColor = false;
            // 
            // dtpBuscarFecha
            // 
            this.dtpBuscarFecha.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBuscarFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscarFecha.Location = new System.Drawing.Point(1000, 87);
            this.dtpBuscarFecha.Name = "dtpBuscarFecha";
            this.dtpBuscarFecha.Size = new System.Drawing.Size(475, 50);
            this.dtpBuscarFecha.TabIndex = 9;
            this.dtpBuscarFecha.ValueChanged += new System.EventHandler(this.dtpBuscarFecha_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Roll_Call.Properties.Resources.BuscadorIcono;
            this.pictureBox1.Location = new System.Drawing.Point(935, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorial.Location = new System.Drawing.Point(76, 158);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(1403, 688);
            this.dgvHistorial.TabIndex = 10;
            // 
            // Historiall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Roll_Call.Properties.Resources.gris_patron;
            this.ClientSize = new System.Drawing.Size(1554, 1004);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.dtpBuscarFecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminarHistorial);
            this.Controls.Add(this.btnModificarHistorial);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historiall";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificarHistorial;
        private System.Windows.Forms.Button btnEliminarHistorial;
        private System.Windows.Forms.DateTimePicker dtpBuscarFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvHistorial;
    }
}