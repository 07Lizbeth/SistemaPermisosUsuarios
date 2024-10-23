namespace SistemaPermisosUsuarios
{
    partial class FrmAddPermisos
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
            this.label5 = new System.Windows.Forms.Label();
            this.brnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFormulario = new System.Windows.Forms.ComboBox();
            this.cboxLectura = new System.Windows.Forms.CheckBox();
            this.cboxEscritura = new System.Windows.Forms.CheckBox();
            this.cboxActualizacion = new System.Windows.Forms.CheckBox();
            this.cboxEliminacion = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 55);
            this.label5.TabIndex = 22;
            this.label5.Text = "Permisos";
            // 
            // brnGuardar
            // 
            this.brnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnGuardar.Location = new System.Drawing.Point(318, 526);
            this.brnGuardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.brnGuardar.Name = "brnGuardar";
            this.brnGuardar.Size = new System.Drawing.Size(144, 47);
            this.brnGuardar.TabIndex = 24;
            this.brnGuardar.Text = "Guardar";
            this.brnGuardar.UseVisualStyleBackColor = true;
            this.brnGuardar.Click += new System.EventHandler(this.brnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(157, 525);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 47);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "Usuario";
            // 
            // cbUsuario
            // 
            this.cbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(114, 154);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(426, 44);
            this.cbUsuario.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 36);
            this.label2.TabIndex = 27;
            this.label2.Text = "Formulario";
            // 
            // cbFormulario
            // 
            this.cbFormulario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormulario.FormattingEnabled = true;
            this.cbFormulario.Items.AddRange(new object[] {
            "Usuarios",
            "Permisos",
            "Refacciones",
            "Taller"});
            this.cbFormulario.Location = new System.Drawing.Point(114, 255);
            this.cbFormulario.Name = "cbFormulario";
            this.cbFormulario.Size = new System.Drawing.Size(426, 44);
            this.cbFormulario.TabIndex = 28;
            // 
            // cboxLectura
            // 
            this.cboxLectura.AutoSize = true;
            this.cboxLectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxLectura.Location = new System.Drawing.Point(114, 338);
            this.cboxLectura.Name = "cboxLectura";
            this.cboxLectura.Size = new System.Drawing.Size(146, 40);
            this.cboxLectura.TabIndex = 29;
            this.cboxLectura.Text = "Lectura";
            this.cboxLectura.UseVisualStyleBackColor = true;
            // 
            // cboxEscritura
            // 
            this.cboxEscritura.AutoSize = true;
            this.cboxEscritura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEscritura.Location = new System.Drawing.Point(335, 338);
            this.cboxEscritura.Name = "cboxEscritura";
            this.cboxEscritura.Size = new System.Drawing.Size(165, 40);
            this.cboxEscritura.TabIndex = 30;
            this.cboxEscritura.Text = "Escritura";
            this.cboxEscritura.UseVisualStyleBackColor = true;
            // 
            // cboxActualizacion
            // 
            this.cboxActualizacion.AutoSize = true;
            this.cboxActualizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxActualizacion.Location = new System.Drawing.Point(115, 422);
            this.cboxActualizacion.Name = "cboxActualizacion";
            this.cboxActualizacion.Size = new System.Drawing.Size(225, 40);
            this.cboxActualizacion.TabIndex = 31;
            this.cboxActualizacion.Text = "Actualizacion";
            this.cboxActualizacion.UseVisualStyleBackColor = true;
            // 
            // cboxEliminacion
            // 
            this.cboxEliminacion.AutoSize = true;
            this.cboxEliminacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEliminacion.Location = new System.Drawing.Point(335, 422);
            this.cboxEliminacion.Name = "cboxEliminacion";
            this.cboxEliminacion.Size = new System.Drawing.Size(200, 40);
            this.cboxEliminacion.TabIndex = 32;
            this.cboxEliminacion.Text = "Eliminacion";
            this.cboxEliminacion.UseVisualStyleBackColor = true;
            // 
            // FrmAddPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 612);
            this.Controls.Add(this.cboxEliminacion);
            this.Controls.Add(this.cboxActualizacion);
            this.Controls.Add(this.cboxEscritura);
            this.Controls.Add(this.cboxLectura);
            this.Controls.Add(this.cbFormulario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAddPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddPermisos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button brnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFormulario;
        private System.Windows.Forms.CheckBox cboxLectura;
        private System.Windows.Forms.CheckBox cboxEscritura;
        private System.Windows.Forms.CheckBox cboxActualizacion;
        private System.Windows.Forms.CheckBox cboxEliminacion;
    }
}