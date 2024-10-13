namespace SistemaPermisosUsuarios
{
    partial class FrmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tmsiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiRefacciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiTaller = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.tmsiMUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 1016);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiUsuarios,
            this.tmsiRefacciones,
            this.tmsiTaller});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.menuStrip1.Size = new System.Drawing.Size(364, 1016);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tmsiUsuarios
            // 
            this.tmsiUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiMUsuarios,
            this.permisosToolStripMenuItem});
            this.tmsiUsuarios.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.tmsiUsuarios.Name = "tmsiUsuarios";
            this.tmsiUsuarios.Size = new System.Drawing.Size(327, 65);
            this.tmsiUsuarios.Text = "Usuarios";
            // 
            // tmsiRefacciones
            // 
            this.tmsiRefacciones.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.tmsiRefacciones.Name = "tmsiRefacciones";
            this.tmsiRefacciones.Size = new System.Drawing.Size(327, 65);
            this.tmsiRefacciones.Text = "Refacciones";
            this.tmsiRefacciones.Click += new System.EventHandler(this.tmsiRefacciones_Click);
            // 
            // tmsiTaller
            // 
            this.tmsiTaller.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.tmsiTaller.Name = "tmsiTaller";
            this.tmsiTaller.Size = new System.Drawing.Size(327, 65);
            this.tmsiTaller.Text = "Taller";
            this.tmsiTaller.Click += new System.EventHandler(this.tmsiTaller_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrincipal.Location = new System.Drawing.Point(505, 5);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1149, 1037);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // tmsiMUsuarios
            // 
            this.tmsiMUsuarios.Name = "tmsiMUsuarios";
            this.tmsiMUsuarios.Size = new System.Drawing.Size(413, 70);
            this.tmsiMUsuarios.Text = "Usuarios";
            this.tmsiMUsuarios.Click += new System.EventHandler(this.tmsiMUsuarios_Click);
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(413, 70);
            this.permisosToolStripMenuItem.Text = "Permisos";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 1038);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tmsiUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tmsiRefacciones;
        private System.Windows.Forms.ToolStripMenuItem tmsiTaller;
        private System.Windows.Forms.ToolStripMenuItem tmsiMUsuarios;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
    }
}