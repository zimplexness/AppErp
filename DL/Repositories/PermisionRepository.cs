using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DL;

namespace DL.Repositories
{
  public  class PermisionRepository:IPermisionRepositories
    {
        private readonly Entities _context;

      

        public PermisionRepository()
        {
            this._context = new Entities();
        }


        public IEnumerable<SubMenus> GetSubmenus(int ID)
        {
            return _context.SubMenus.Where(x => x.MenuID == ID).ToList();
        }
    }
}
