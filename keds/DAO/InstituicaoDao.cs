using keds.Database;
using keds.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace keds.DAO
{
    public class InstituicaoDao : IDao<Instituicao>
    {
        public Instituicao add(Instituicao toAdd)
        {
            try
            {
                using (var db = new KedsContext())
                {
                    toAdd.Id = Guid.NewGuid();
                    db.Instituicoes.Add(toAdd);
                    db.SaveChanges();

                    return toAdd;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Não foi possível realizar a operação.");
            }
        }

        public void delete(Guid toDelete)
        {
            throw new NotImplementedException();
        }

        public Instituicao find(Guid toFind)
        {
            try
            {
                using (var db = new KedsContext())
                {
                    return db.Instituicoes.Find(toFind);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Não foi possível realizar a operação.");
            }
        }

        public IEnumerable<Instituicao> findAll()
        {
            try
            {
                using (var db = new KedsContext())
                {
                    return db.Instituicoes.ToArray<Instituicao>();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Não foi possível realizar a operação.");
            }
        }

        public Instituicao update(Instituicao toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
