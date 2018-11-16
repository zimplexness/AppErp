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
using Entidades;

namespace ErpGestion
{
    public partial class ProductoFrm : MetroFramework.Forms.MetroForm
    {
        ArticuloController articuloController;
        public int IDArticulo { get; set; }
        Articulos Articulo;
        public ProductoFrm()
        {
            InitializeComponent();
            articuloController = new ArticuloController();
            Articulo = new Articulos();
          
        }

     

        private void ProductosForm_Load(object sender, EventArgs e)
        {


            metroComboBoxCategoria.DataSource = articuloController.Categorias();
            metroComboBoxCategoria.DisplayMember = "Categoria";
            metroComboBoxCategoria.ValueMember = "IDCategoria";



            metroComboBoxUbicacion.DataSource = articuloController.ListarUbicacion();
            metroComboBoxUbicacion.DisplayMember = "Ubicacion1";
            metroComboBoxUbicacion.ValueMember = "IdUbicacion";
            Articulo = articuloController.EncontrarArticulo(IDArticulo);

            if (Articulo!=null)
            {
                metroTextBoxProducto.Text = Articulo.Nombre;
                metroTextBoxCodigo.Text = Articulo.Codigo;
                metroTextBoxDescripcion.Text = Articulo.Descripcion;
                metroTextBoxIva.Text = Articulo.Iva.ToString();
                metroComboBoxUbicacion.SelectedValue = (int)Articulo.IdUbicacion;
                metroComboBoxCategoria.SelectedValue = (int)Articulo.IDCategoria;
            }



        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(metroTextBoxProducto.Text) == true)
                {
                    MessageBox.Show("Debe insertar al menos el nombre del articulo", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (Articulo!=null)
                    {
                        Articulo.Nombre = metroTextBoxProducto.Text;
                        Articulo.Descripcion = metroTextBoxDescripcion.Text;
                        Articulo.Codigo = metroTextBoxCodigo.Text;
                        Articulo.Iva = int.Parse(metroTextBoxIva.Text);
                        Articulo.IDCategoria = (int)metroComboBoxCategoria.SelectedValue;
                        Articulo.IdUbicacion = (int)metroComboBoxUbicacion.SelectedValue;
                        articuloController.InsertarArticulos(Articulo);
                    }
                    else if (Articulo==null)
                    
                    {
                        Articulo = new Articulos();
                        Articulo.Nombre = metroTextBoxProducto.Text;
                        Articulo.Descripcion = metroTextBoxDescripcion.Text;
                        Articulo.Codigo = metroTextBoxCodigo.Text;
                        Articulo.Iva =int.Parse( metroTextBoxIva.Text);
                        Articulo.IDCategoria = (int)metroComboBoxCategoria.SelectedValue;
                        Articulo.IdUbicacion = (int)metroComboBoxUbicacion.SelectedValue;
                        articuloController.InsertarArticulos(Articulo);
                    }

                    MessageBox.Show("Producto agregado con exito", "Sistema de Gestion Integral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ProductoFrm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
