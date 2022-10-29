namespace Navegador
{
    partial class Browser
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnretroceder = new System.Windows.Forms.ToolStripButton();
            this.btnavanzar = new System.Windows.Forms.ToolStripButton();
            this.btnhome = new System.Windows.Forms.ToolStripButton();
            this.cuadroBusqueda = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.navegador = new System.Windows.Forms.WebBrowser();
            this.btnrefrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnretroceder,
            this.btnavanzar,
            this.btnrefrescar,
            this.btnhome,
            this.cuadroBusqueda,
            this.btnBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnretroceder
            // 
            this.btnretroceder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnretroceder.Image = ((System.Drawing.Image)(resources.GetObject("btnretroceder.Image")));
            this.btnretroceder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnretroceder.Name = "btnretroceder";
            this.btnretroceder.Size = new System.Drawing.Size(23, 22);
            this.btnretroceder.Text = "toolStripButton1";
            this.btnretroceder.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnavanzar
            // 
            this.btnavanzar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnavanzar.Image = ((System.Drawing.Image)(resources.GetObject("btnavanzar.Image")));
            this.btnavanzar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnavanzar.Name = "btnavanzar";
            this.btnavanzar.Size = new System.Drawing.Size(23, 22);
            this.btnavanzar.Text = "toolStripButton2";
            this.btnavanzar.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnhome
            // 
            this.btnhome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(23, 22);
            this.btnhome.Text = "toolStripButton3";
            this.btnhome.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // cuadroBusqueda
            // 
            this.cuadroBusqueda.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cuadroBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cuadroBusqueda.Name = "cuadroBusqueda";
            this.cuadroBusqueda.Size = new System.Drawing.Size(635, 25);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // navegador
            // 
            this.navegador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navegador.Location = new System.Drawing.Point(0, 25);
            this.navegador.MinimumSize = new System.Drawing.Size(20, 20);
            this.navegador.Name = "navegador";
            this.navegador.Size = new System.Drawing.Size(1264, 704);
            this.navegador.TabIndex = 1;
            this.navegador.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.navegador_DocumentCompleted);
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnrefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnrefrescar.Image")));
            this.btnrefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(23, 22);
            this.btnrefrescar.Text = "toolStripButton1";
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.navegador);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navegador";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnretroceder;
        private System.Windows.Forms.ToolStripButton btnavanzar;
        private System.Windows.Forms.ToolStripButton btnhome;
        private System.Windows.Forms.ToolStripTextBox cuadroBusqueda;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.WebBrowser navegador;
        private System.Windows.Forms.ToolStripButton btnrefrescar;
    }
}

