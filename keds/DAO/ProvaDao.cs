using keds.Database;
using keds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace keds.DAO
{
    public class ProvaDao : IDao<Prova>
    {
        public Prova add(Prova toAdd)
        {
            try
            {
                using (var db = new KedsContext())
                {
                    toAdd.Id = Guid.NewGuid();
                    db.Provas.Add(toAdd);
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

        public Prova find(Guid toFind)
        {
            try
            {
                using (var db = new KedsContext())
                {
                    return db.Provas.Find(toFind);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Não foi possível realizar a operação.");
            }
        }

        public IEnumerable<Prova> findAll()
        {
            try
            {
                using (var db = new KedsContext())
                {
                    return db.Provas.ToArray<Prova>();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Não foi possível realizar a operação.");
            }
        }

        public Prova update(Prova toUpdate)
        {
            throw new NotImplementedException();
        }


        public List<Prova> findByInstituicao(Guid toFind)
        {
            try
            {
                using (var db = new KedsContext())
                {
                    return db.Provas.Where(pr => pr.InstituicaoId == toFind).ToList<Prova>();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Não foi possível realizar a operação.");
            }
        }
    }
}
