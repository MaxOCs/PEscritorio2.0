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
    public partial class Form1 : Form
    {
        byte ce = 0, re = 0, ipm = 0;
        public Form1()
        {
            InitializeComponent();
            Login PantallaLogin = new Login();
            PantallaLogin.ShowDialog();
            rjDropdownMenu1.IsMainMenu = true;
        }
        private Form active = null;
        private void opening(Form child)
        {
            if (active != null)
                active.Close();
            active = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel11.Controls.Add(child);
            panel11.Tag = child;
            child.BringToFront();
            child.Show();

        }
        public void Desaparecer()
        {

        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(BtnCatalogo, BtnCatalogo.Width, 0);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            opening(new Ventas());
            LBubicacion.Text = "VENTAS";
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            opening(new Compras());
            LBubicacion.Text = "COMPRAS";
        }

        private void BtnCorte_Click(object sender, EventArgs e)
        {
            opening(new Corte());
            LBubicacion.Text = "CORTE";
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            opening(new Factura());
            LBubicacion.Text = "FACTURA";
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCProvee_Click(object sender, EventArgs e)
        {
            CProveedores PantallaCProveedores = new CProveedores();
            PantallaCProveedores.ShowDialog();
        }

        private void BtnRProvee_Click(object sender, EventArgs e)
        {
            RProveedor PantallaRProveerdor = new RProveedor();
            PantallaRProveerdor.ShowDialog();
        }

        private void BtnCCompras_Click(object sender, EventArgs e)
        {
            CCompras PantallasCCompra = new CCompras();
            PantallasCCompra.ShowDialog();
        }

        private void BtnCCorte_Click(object sender, EventArgs e)
        {
            CCorte PantallaCCorte = new CCorte();
            PantallaCCorte.ShowDialog();
        }

        private void BtnCClie_Click(object sender, EventArgs e)
        {
            CClientes PantallaCClie = new CClientes();
            PantallaCClie.ShowDialog();
        }

        private void BtnCUsuari_Click(object sender, EventArgs e)
        {
            CUsuarios PantallaCUsuari = new CUsuarios();
            PantallaCUsuari.ShowDialog();
        }

        private void BtnRMateria_Click(object sender, EventArgs e)
        {
            RMateriales RMateria = new RMateriales();
            RMateria.ShowDialog();
        }

        private void BtnRUsuar_Click(object sender, EventArgs e)
        {
            RUsuario PantallaRUsuario = new RUsuario();
            PantallaRUsuario.ShowDialog();
        }

        private void BtnCBalance_Click(object sender, EventArgs e)
        {
            CBalance PantallaCBalance = new CBalance();
            PantallaCBalance.ShowDialog();
        }

        private void BtnRPintura_Click(object sender, EventArgs e)
        {
            RPintura PantallaRPintura = new RPintura();
            PantallaRPintura.ShowDialog();
        }

        private void BtnRClie_Click(object sender, EventArgs e)
        {
            RClientes PantallaRClie = new RClientes();
            PantallaRClie.ShowDialog();
        }

        private void BtnCPintura_Click(object sender, EventArgs e)
        {
            CPintura CPintura = new CPintura();
            CPintura.ShowDialog();
        }

        private void BtnCMaterias_Click(object sender, EventArgs e)
        {
            CMateriales CMateriales = new CMateriales();
            CMateriales.ShowDialog();
        }

        private void BtnCVenta_Click(object sender, EventArgs e)
        {
            CVentas CVentas = new CVentas();
            CVentas.ShowDialog();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            ReprtesVentas PantallaReprtesVentas = new ReprtesVentas();
            PantallaReprtesVentas.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rjDropdownMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void pROVEEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening(new CProveedores());
            LBubicacion.Text= "CATALOGO PROVEEDORES";
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening(new CUsuarios ());
            LBubicacion.Text = "CATALOGO USUARIOS";
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening(new CClientes());
            LBubicacion.Text = "CATALOGO CLIENTES";
        }

        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening(new CVentas());
            LBubicacion.Text = "CATALOGO VENTAS";
        }

        private void cOMPRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening(new CCompras());
            LBubicacion.Text = "CATALOGO COMPRAS";
        }

        private void iNVENTARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void pINTURASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening(new CPintura());
            LBubicacion.Text = "CATALOGO Pintura";
        }

        private void mATERIALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opening(new CMateriales());
            LBubicacion.Text = "CATALOGO MATERIALES";
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    

