using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;

namespace DL.Repositories
{
   public class ProductoRepository:IProductoRepository
    {

        private readonly Entities _context;
        public ProductoRepository()
        {
            _context = new Entities();
        }

        public Articulos AddorUpdateProducto(Articulos articulos)
        {
            try
            {
                if (_context.Articulos.Where(x=>x.IDArticulo==articulos.IDArticulo).FirstOrDefault()!=null)
                {
                    _context.Articulos.Attach(articulos);
                    _context.Entry(articulos).State = EntityState.Modified;
                   

                }
                else 
                {

                    _context.Articulos.Add(articulos);

                }
                if (_context.SaveChanges() > 0)
                    return articulos;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return articulos = null;
        }

        public Articulos DeleteArticulo(int Idarticulo)
        {
            var Articulo = _context.Articulos.Where(x => x.IDArticulo == Idarticulo).FirstOrDefault();

            _context.Articulos.Remove(Articulo);
            _context.SaveChanges();
            return Articulo;
        }

        public IEnumerable<Articulos> FiltrarArticulo(string nombre)
        {
            return _context.Articulos.Include(x => x.Ubicacion).
                                      Include(x => x.Categorias).
                                      Where(x => x.Nombre.Contains(nombre.ToUpper())).ToList();
        }

        public Articulos GetArticulo(int IdArticulo)
        {
            return _context.Articulos.Where(x => x.IDArticulo == IdArticulo).FirstOrDefault();
        }

        public Articulos GetArticuloByNombre(string nombre)
        {
            return _context.Articulos.Where(x => x.Nombre == nombre).FirstOrDefault();
        }

        public IEnumerable<Categorias> GetCategoriasProductos()
        {
            return _context.Categorias.ToList();
        }

        public IEnumerable<string> GetNombreArticulos()
        {
            return _context.Articulos.Select(x => x.Nombre).ToList();
        }

        public IEnumerable<Articulos> GetProductos()
        {
            return _context.Articulos.Include(x => x.Ubicacion).
                                    Include(x => x.Categorias).
                                    ToList();
        }

        public IEnumerable< Ubicacion> GetUbicacionProducto()
        {
            return _context.Ubicacion.ToList();
        }
    }
}
