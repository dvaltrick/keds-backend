using keds.Database;
using keds.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace keds.DAO
{
    public class QuestaoDao : IDao<Questao>
    {
        public Questao add(Questao toAdd)
        {
            try
            {
                using (var db = new KedsContext())
                {
                    toAdd.Id = Guid.NewGuid();
                    db.Questoes.Add(toAdd);
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

        public Questao find(Guid toFind)
        {
            try
            {
                using (var db = new KedsContext())
                {
                    return db.Questoes.Find(toFind);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Não foi possível realizar a operação.");
            }
        }

        public IEnumerable<Questao> findAll()
        {
            try
            {
                using (var db = new KedsContext())
                {
                    return db.Questoes.Include(alt => alt.Alternativas).ToArray<Questao>();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Não foi possível realizar a operação.");
            }
        }

        public Questao update(Questao toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
