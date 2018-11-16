using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;

namespace ErpGestion
{
    public partial class AdminProductosFrm : MetroFramework.Forms.MetroForm
    {
        ArticuloController articuloController;
        public AdminProductosFrm()
        {
            InitializeComponent();
            articuloController = new ArticuloController();
        }

        private void AdminProductosFrm_Load(object sender, EventArgs e)
        {
           

            bindingSourceProductos.DataSource = articuloController.ListarArticulos();

            metroGridProductos.AutoGenerateColumns = false;
            metroGridProductos.DataSource = bindingSourceProductos;
            metroGridProductos.AutoSize = false;

           

        }

        private void bindingSourceProductos_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ProductoFrm))
                {
                    f.Activate();
                    return;
                }
            }
          
            ProductoFrm frmEditProducto = new ProductoFrm();

         

            frmEditProducto.FormClosed += AdminProductosFrm_FormClosed;
            frmEditProducto.Show();
        }

        private void metroGridProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ProductoFrm))
                {
                    f.Activate();
                    return;
                }
            }
            int IdArticulo = (int)metroGridProductos.CurrentRow.Cells["iDArticuloDataGridViewTextBoxColumn"].Value;
            ProductoFrm frmEditProducto = new ProductoFrm();

            frmEditProducto.IDArticulo = IdArticulo;

            frmEditProducto.FormClosed += AdminProductosFrm_FormClosed;
            frmEditProducto.Show();
        }

        private void AdminProductosFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            bindingSourceProductos.ResetBindings(true);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ProductoFrm))
                {
                    f.Activate();
                    return;
                }
            }
            int IdArticulo = (int)metroGridProductos.CurrentRow.Cells["iDArticuloDataGridViewTextBoxColumn"].Value;
            ProductoFrm frmEditProducto = new ProductoFrm();

            frmEditProducto.IDArticulo = IdArticulo;

            frmEditProducto.FormClosed += AdminProductosFrm_FormClosed;
            frmEditProducto.Show();
        }

        private void metroTextBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBoxNombre.Text=="")
            {
                bindingSourceProductos.ResetBindings(true);
            }
            else

            metroGridProductos.DataSource = articuloController.FiltrarArticulos(metroTextBoxNombre.Text);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, "Estas seguro que quieres eliminar el Producto seleccionado?", "Sistema de Gestion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation & MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    articuloController.EliminarArticulo((int)metroGridProductos.CurrentRow.Cells["iDArticuloDataGridViewTextBoxColumn"].Value);
                    MetroFramework.MetroMessageBox.Show(this, "Producto elimminado con exito", "Sistema de Gestiòn", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
            catch (Exception EX)
            {

                throw new Exception(EX.Message);
            }
        }
    }
}
