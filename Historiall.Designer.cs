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
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarHistorial = new System.Windows.Forms.Button();
            this.btnEliminarHistorial = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(72, 159);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(1403, 688);
            this.dgvHistorial.TabIndex = 0;
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
            // txtBuscador
            // 
            this.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscador.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.Location = new System.Drawing.Point(1000, 79);
            this.txtBuscador.Multiline = true;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(475, 56);
            this.txtBuscador.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Roll_Call.Properties.Resources.BuscadorIcono;
            this.pictureBox1.Location = new System.Drawing.Point(918, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 72);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Historiall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Roll_Call.Properties.Resources.gris_patron;
            this.ClientSize = new System.Drawing.Size(1554, 1004);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.btnEliminarHistorial);
            this.Controls.Add(this.btnModificarHistorial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHistorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historiall";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificarHistorial;
        private System.Windows.Forms.Button btnEliminarHistorial;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}