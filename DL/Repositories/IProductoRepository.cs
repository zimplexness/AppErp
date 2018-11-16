using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DL.Repositories
{
  public interface IProductoRepository
    {

        IEnumerable<Articulos> GetProductos();
        Articulos AddorUpdateProducto(Articulos articulos);
        IEnumerable< Ubicacion> GetUbicacionProducto();
        Articulos DeleteArticulo(int Idarticulo);
        IEnumerable<Articulos> FiltrarArticulo(string nombre);
        Articulos GetArticulo(int IdArticulo);
        IEnumerable<string> GetNombreArticulos();
        IEnumerable<Categorias> GetCategoriasProductos();
        Articulos GetArticuloByNombre(string nombre);
    }
}
