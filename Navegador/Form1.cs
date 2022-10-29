using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            navegador.GoHome();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            navegador.Navigate(cuadroBusqueda.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            navegador.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            navegador.GoForward();
        }

        private void navegador_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            navegador.Refresh();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
    }
}
