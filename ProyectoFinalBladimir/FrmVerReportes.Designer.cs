namespace ProyectoFinalBladimir
{
    partial class FrmVerReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerReportes));
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.DGVCanchas = new System.Windows.Forms.DataGridView();
            this.NombreCancha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCanchas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(214, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 43);
            this.label3.TabIndex = 30;
            this.label3.Text = "Soccersoft";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Snow;
            this.BtnSalir.Location = new System.Drawing.Point(895, 608);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(100, 37);
            this.BtnSalir.TabIndex = 29;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // DGVCanchas
            // 
            this.DGVCanchas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCanchas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCancha,
            this.Descripcion,
            this.Precio,
            this.Disponibilidad,
            this.Cancelar,
            this.Editar});
            this.DGVCanchas.Location = new System.Drawing.Point(27, 222);
            this.DGVCanchas.Name = "DGVCanchas";
            this.DGVCanchas.RowHeadersWidth = 51;
            this.DGVCanchas.RowTemplate.Height = 24;
            this.DGVCanchas.Size = new System.Drawing.Size(935, 380);
            this.DGVCanchas.TabIndex = 28;
            this.DGVCanchas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCanchas_CellContentClick);
            // 
            // NombreCancha
            // 
            this.NombreCancha.HeaderText = "Cancha";
            this.NombreCancha.MinimumWidth = 20;
            this.NombreCancha.Name = "NombreCancha";
            this.NombreCancha.Width = 190;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 190;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Disponibilidad
            // 
            this.Disponibilidad.HeaderText = "Disponibilidad";
            this.Disponibilidad.MinimumWidth = 6;
            this.Disponibilidad.Name = "Disponibilidad";
            this.Disponibilidad.Width = 125;
            // 
            // Cancelar
            // 
            this.Cancelar.HeaderText = "Reporte";
            this.Cancelar.MinimumWidth = 6;
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Width = 125;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Fecha";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(294, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 43);
            this.label2.TabIndex = 27;
            this.label2.Text = "Reportes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 139);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // FrmVerReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1034, 679);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.DGVCanchas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVerReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVerReportes";
            ((System.ComponentModel.ISupportInitialize)(this.DGVCanchas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView DGVCanchas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCancha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editar;
    }
}