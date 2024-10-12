namespace SistemaPermisosUsuarios
{
    partial class FrmRefacciones
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
            this.dgvRefacciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRefacciones
            // 
            this.dgvRefacciones.AllowUserToAddRows = false;
            this.dgvRefacciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRefacciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRefacciones.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRefacciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRefacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefacciones.Location = new System.Drawing.Point(75, 160);
            this.dgvRefacciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRefacciones.Name = "dgvRefacciones";
            this.dgvRefacciones.ReadOnly = true;
            this.dgvRefacciones.RowHeadersVisible = false;
            this.dgvRefacciones.RowHeadersWidth = 92;
            this.dgvRefacciones.RowTemplate.Height = 37;
            this.dgvRefacciones.Size = new System.Drawing.Size(1020, 523);
            this.dgvRefacciones.TabIndex = 0;
            this.dgvRefacciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRefacciones_CellClick);
            this.dgvRefacciones.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRefacciones_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Refacciones";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(1027, 95);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(68, 57);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(75, 95);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(188, 57);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmRefacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 839);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRefacciones);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRefacciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRefacciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefacciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRefacciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
    }
}