namespace ProyectoFinalBladimir
{
    partial class FrmAgregarCancha
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
            this.AgregarCancha = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNombreCancha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtprecio = new System.Windows.Forms.TextBox();
            this.Txtdes = new System.Windows.Forms.TextBox();
            this.Txtimagen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtdis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AgregarCancha
            // 
            this.AgregarCancha.Location = new System.Drawing.Point(339, 372);
            this.AgregarCancha.Name = "AgregarCancha";
            this.AgregarCancha.Size = new System.Drawing.Size(107, 34);
            this.AgregarCancha.TabIndex = 0;
            this.AgregarCancha.Text = "Agregar";
            this.AgregarCancha.UseVisualStyleBackColor = true;
            this.AgregarCancha.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(196, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Nombre:";
            // 
            // TxtNombreCancha
            // 
            this.TxtNombreCancha.Location = new System.Drawing.Point(306, 138);
            this.TxtNombreCancha.Name = "TxtNombreCancha";
            this.TxtNombreCancha.Size = new System.Drawing.Size(238, 22);
            this.TxtNombreCancha.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(200, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Imagen";
            // 
            // Txtprecio
            // 
            this.Txtprecio.Location = new System.Drawing.Point(306, 264);
            this.Txtprecio.Name = "Txtprecio";
            this.Txtprecio.Size = new System.Drawing.Size(238, 22);
            this.Txtprecio.TabIndex = 35;
            // 
            // Txtdes
            // 
            this.Txtdes.Location = new System.Drawing.Point(306, 183);
            this.Txtdes.Name = "Txtdes";
            this.Txtdes.Size = new System.Drawing.Size(238, 22);
            this.Txtdes.TabIndex = 34;
            // 
            // Txtimagen
            // 
            this.Txtimagen.Location = new System.Drawing.Point(306, 224);
            this.Txtimagen.Name = "Txtimagen";
            this.Txtimagen.Size = new System.Drawing.Size(238, 22);
            this.Txtimagen.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(200, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(200, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(289, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 43);
            this.label1.TabIndex = 30;
            this.label1.Text = "Agregar Cancha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(200, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Disponibilidad";
            // 
            // Txtdis
            // 
            this.Txtdis.Location = new System.Drawing.Point(306, 307);
            this.Txtdis.Name = "Txtdis";
            this.Txtdis.Size = new System.Drawing.Size(238, 22);
            this.Txtdis.TabIndex = 40;
            // 
            // FrmAgregarCancha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtdis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtNombreCancha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txtprecio);
            this.Controls.Add(this.Txtdes);
            this.Controls.Add(this.Txtimagen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgregarCancha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarCancha";
            this.Text = "FrmAgregarCancha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarCancha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNombreCancha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtprecio;
        private System.Windows.Forms.TextBox Txtdes;
        private System.Windows.Forms.TextBox Txtimagen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtdis;
    }
}