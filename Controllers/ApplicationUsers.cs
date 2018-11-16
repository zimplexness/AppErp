using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL.Identity;
using Entidades;
using DL.Repositories;

namespace Controllers
{
  public  class ApplicationUsers
    {

        private AplicationUser _AplicationUser;
        private PermisionRepository _permisionRepository;

        public ApplicationUsers()
        {
            _AplicationUser = new AplicationUser();
            _permisionRepository = new PermisionRepository();


        }

        public NetUser StoreUser(string username, string password)
        {
            return _AplicationUser.StoreUser(username,password);
        }

        public bool Autenticar(string username, string password)
        {
          return  _AplicationUser.Autenticar(username,password);
        }
        public IEnumerable<string> GetUsersName()
        {
           return _AplicationUser.GetUsersName();

        }

        public NetUser GetUser(string username)
        {
            return _AplicationUser.GetUser(username);

        }

        public bool VerifyMatchPassword(string username, string password, string repeatedpassword)
        {
           return _AplicationUser.VerifyMatchPassword(username,password,repeatedpassword);

        }

        public List<NetUser> GetUsers()
        {
            return _AplicationUser.GetUsers().ToList();

        }

        public IEnumerable<Menus> GetMainMenu()
        {
            return _AplicationUser.GetMainMenu();
        }

        public IEnumerable<SubMenus> GetSubmenus(int ID)
        {
            return _permisionRepository.GetSubmenus(ID);
        }

    }
}
