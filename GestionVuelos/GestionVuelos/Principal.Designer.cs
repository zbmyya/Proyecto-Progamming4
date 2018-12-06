namespace GestionVuelos
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itinerarioDeVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idaYVueltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTusVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itinerarioDeVuelosToolStripMenuItem,
            this.verTusVuelosToolStripMenuItem,
            this.cuentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itinerarioDeVuelosToolStripMenuItem
            // 
            this.itinerarioDeVuelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idaToolStripMenuItem,
            this.idaYVueltaToolStripMenuItem});
            this.itinerarioDeVuelosToolStripMenuItem.Name = "itinerarioDeVuelosToolStripMenuItem";
            this.itinerarioDeVuelosToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.itinerarioDeVuelosToolStripMenuItem.Text = "Itinerario de vuelos";
            // 
            // idaToolStripMenuItem
            // 
            this.idaToolStripMenuItem.Name = "idaToolStripMenuItem";
            this.idaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.idaToolStripMenuItem.Text = "Ida";
            this.idaToolStripMenuItem.Click += new System.EventHandler(this.idaToolStripMenuItem_Click);
            // 
            // idaYVueltaToolStripMenuItem
            // 
            this.idaYVueltaToolStripMenuItem.Name = "idaYVueltaToolStripMenuItem";
            this.idaYVueltaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.idaYVueltaToolStripMenuItem.Text = "Ida y Vuelta";
            this.idaYVueltaToolStripMenuItem.Click += new System.EventHandler(this.idaYVueltaToolStripMenuItem_Click);
            // 
            // verTusVuelosToolStripMenuItem
            // 
            this.verTusVuelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem,
            this.comprasToolStripMenuItem});
            this.verTusVuelosToolStripMenuItem.Name = "verTusVuelosToolStripMenuItem";
            this.verTusVuelosToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.verTusVuelosToolStripMenuItem.Text = "Ver tus vuelos";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 297);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itinerarioDeVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idaYVueltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTusVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}