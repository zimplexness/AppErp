using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;

namespace DL.Identity
{
   public class AplicationUser
    {
        Entities _context;
        NetUser NetUser;

        public AplicationUser()
        {
            _context = new Entities();
            NetUser = new NetUser();
        }


        public bool Autenticar(string username, string password)
        {
                 string pass = Helper.EncodePassword(string.Concat(username, password));
                 NetUser = _context.NetUser.Where(u => u.PasswordHash == pass && u.UserName == username).FirstOrDefault();
                if (NetUser != null)
                    return true;
                else return false;
           
        }

        public NetUser StoreUser(string  username,string password)
        {

                string pass = Helper.EncodePassword(string.Concat(username, password));
                var user = _context.NetUser.Where(u => u.PasswordHash == pass && u.UserName == username).FirstOrDefault();
                NetUser.UserName = username;
                NetUser.PasswordHash = pass;
                NetUser.SecurityStamp = pass;


                if (user != null)
                {

                    _context.NetUser.Attach(NetUser);
                    _context.Entry(NetUser).State = EntityState.Modified;

                }
                else
                {

                    _context.NetUser.Add(NetUser);
                }

                _context.SaveChanges();
                return NetUser;
        }

        public bool VerifyMatchPassword(string username,string password, string repeatedpassword) {

            string pass = Helper.EncodePassword(string.Concat(username, password));
            string repeated = Helper.EncodePassword(string.Concat(username,repeatedpassword));

            if (pass==repeatedpassword)
            {
                return true;
            }
            else
            {
                return false;

            }

            

        }

        public IEnumerable<string> GetUsersName() {
            using (_context)
            {
                return _context.NetUser.Select(x=>x.UserName).ToList();
            }

        }

        public IEnumerable<NetUser> GetUsers()
        {
           
                return _context.NetUser.ToList();
            
        }

        public NetUser GetUser(string username)
        {
            using (_context)
            {
                return _context.NetUser.Where(x => x.UserName == username).FirstOrDefault();
            }

        }

        public IEnumerable<Menus> GetMainMenu() {
            using (_context=new Entities())
            {
                return _context.Menus.ToList();
            }
        }

    }
}
