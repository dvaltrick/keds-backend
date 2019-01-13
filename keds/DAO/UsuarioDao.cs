using keds.Database;
using keds.Models;
using keds.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace keds.DAO
{
    public class UsuarioDao : IDao<Usuario>
    {
        private IUserService _userService;

        public UsuarioDao([FromServices] IUserService userService)
        {
            this._userService = userService;
        }

        public Usuario add(Usuario toSave)
        {
            try
            {
                using (var db = new KedsContext())
                {
                    toSave.Id = Guid.NewGuid();
                    db.Usuarios.Add(toSave);
                    db.SaveChanges();

                    return toSave;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Não foi possível realizar a operação.");
            }
        }

        public Usuario Auth(Usuario toLoggin)
        {
            using (var db = new KedsContext())
            {
                return _userService.Authenticate(_userService, db, toLoggin.Login, toLoggin.Senha);
            }
        }

        public void delete(Guid toDelete)
        {
            throw new NotImplementedException();
        }

        public Usuario find(Guid toFind)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> findAll()
        {
            using (var db = new KedsContext())
            {
                return db.Usuarios.ToList<Usuario>();
            }
        }

        public Usuario update(Usuario toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
