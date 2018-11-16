using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DL.Repositories;


namespace Controllers
{
   public class ArticuloController
    {
        //declaracion del datacontext de todas las entities
        ProductoRepository productoRepository;

        public ArticuloController()
        {
            productoRepository = new ProductoRepository();
        }

        public IEnumerable<Categorias> Categorias()
        {
            return productoRepository.GetCategoriasProductos();
        }

        
        public Articulos InsertarArticulos(Articulos articulos )
        {
            return productoRepository.AddorUpdateProducto(articulos);
        }

        public IEnumerable<Articulos> ListarArticulos()
        {

            return productoRepository.GetProductos();
           

        }


        public Articulos EliminarArticulo(int Idarticulo)
        {
           return productoRepository.DeleteArticulo(Idarticulo);
        }

        public IEnumerable<Articulos> FiltrarArticulos(string nombre)
        {
            return productoRepository.FiltrarArticulo(nombre);
        }

        public Articulos EncontrarArticulo(int idarticulo)
        {
           return productoRepository.GetArticulo(idarticulo);


        }

       

        public Articulos DevolverIDporNombre(string nombre)
        {
            return productoRepository.GetArticuloByNombre(nombre);

        }

        

        public IEnumerable<Ubicacion> ListarUbicacion()
        {
            return productoRepository.GetUbicacionProducto();
        }

     

        public IEnumerable<string> ListarNombresArticulos()
        {
            return productoRepository.GetNombreArticulos();
        }


    }
}
