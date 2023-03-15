using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEscritorio
{
    public partial class CClientes : Form
    {
        

        private void BtnCompras_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            
        }
        public void Desaparecer()
        {
          
        }

        private void BtnCorte_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRProvee_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCProvee_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCClie_Click(object sender, EventArgs e)
        {
            Desaparecer();
        }

        private void BtnCCompras_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCCorte_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BtnCUsuari_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnRMateria_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnRUsuar_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCBalance_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRPintura_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnRClie_Click(object sender, EventArgs e)
        {
            RClientes PantallaRClie = new RClientes();
            this.Close();
            PantallaRClie.ShowDialog();
        }

        private void BtnCPintura_Click(object sender, EventArgs e)
        {
            CPintura CPintura = new CPintura();
            this.Close();
            CPintura.ShowDialog();
        }

        private void BtnCMaterias_Click(object sender, EventArgs e)
        {
            CMateriales CMateriales = new CMateriales();
            this.Close();
            CMateriales.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInventario_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BtnCCompras_Click_1(object sender, EventArgs e)
        {
            CCompras PantallasCCompra = new CCompras();
            this.Close();
            PantallasCCompra.ShowDialog();
        }

        private void BtnCVenta_Click(object sender, EventArgs e)
        {
            CVentas CVentas = new CVentas();
            this.Close();
            CVentas.ShowDialog();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            ReprtesVentas PantallaReprtesVentas = new ReprtesVentas();
            this.Close();
            PantallaReprtesVentas.ShowDialog();
        }

        public CClientes()
        {
            InitializeComponent();
            
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas PantallaVentas = new Ventas();
            this.Close();
            PantallaVentas.ShowDialog();
        }
    }
}
