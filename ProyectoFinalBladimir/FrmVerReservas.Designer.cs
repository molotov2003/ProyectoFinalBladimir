namespace ProyectoFinalBladimir
{
    partial class FrmVerReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerReservas));
            this.BtnSalir = new System.Windows.Forms.Button();
            this.DGVCanchas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.NombreCancha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCanchas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Snow;
            this.BtnSalir.Location = new System.Drawing.Point(880, 586);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(100, 37);
            this.BtnSalir.TabIndex = 24;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // DGVCanchas
            // 
            this.DGVCanchas.AllowUserToOrderColumns = true;
            this.DGVCanchas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCanchas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCancha,
            this.Descripcion,
            this.Precio,
            this.Disponibilidad,
            this.Asistencia});
            this.DGVCanchas.Location = new System.Drawing.Point(12, 200);
            this.DGVCanchas.Name = "DGVCanchas";
            this.DGVCanchas.RowHeadersWidth = 51;
            this.DGVCanchas.RowTemplate.Height = 24;
            this.DGVCanchas.Size = new System.Drawing.Size(915, 380);
            this.DGVCanchas.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(279, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 43);
            this.label2.TabIndex = 19;
            this.label2.Text = "Lista de Reservas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(131, -61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 43);
            this.label1.TabIndex = 18;
            this.label1.Text = "Soccersoft";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 139);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(199, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 43);
            this.label3.TabIndex = 25;
            this.label3.Text = "Soccersoft";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Snow;
            this.BtnEliminar.Location = new System.Drawing.Point(942, 231);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 37);
            this.BtnEliminar.TabIndex = 26;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Snow;
            this.BtnEditar.Location = new System.Drawing.Point(942, 316);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(100, 37);
            this.BtnEditar.TabIndex = 27;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // NombreCancha
            // 
            this.NombreCancha.HeaderText = "Cancha";
            this.NombreCancha.MinimumWidth = 20;
            this.NombreCancha.Name = "NombreCancha";
            this.NombreCancha.Width = 170;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Fecha";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 160;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Hora";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            // 
            // Disponibilidad
            // 
            this.Disponibilidad.HeaderText = "Pago";
            this.Disponibilidad.MinimumWidth = 6;
            this.Disponibilidad.Name = "Disponibilidad";
            this.Disponibilidad.Width = 125;
            // 
            // Asistencia
            // 
            this.Asistencia.HeaderText = "Asistencia";
            this.Asistencia.MinimumWidth = 6;
            this.Asistencia.Name = "Asistencia";
            // 
            // FrmVerReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1141, 646);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.DGVCanchas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVerReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVerReservas";
            ((System.ComponentModel.ISupportInitialize)(this.DGVCanchas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView DGVCanchas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCancha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asistencia;
    }
}