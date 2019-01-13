using keds.Database;
using keds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace keds.DAO
{
    public class SimuladoDao : IDao<Simulado>
    {
        public Simulado add(Simulado toAdd)
        {
            try
            {
                using (var db = new KedsContext())
                {
                    toAdd.Id = Guid.NewGuid();
                    toAdd.Data = DateTime.Now;

                    if (db.Usuarios.Find(toAdd.UsuarioId) == null) {
                        throw new Exception("Usuário não cadastrado");
                    }

                    if (db.Provas.Find(toAdd.ProvaId) == null)
                    {
                        throw new Exception("Prova não cadastrada");
                    }

                    toAdd.Questoes = db.Questoes.Count<Questao>(q => q.ProvaId == toAdd.ProvaId);
                    toAdd.Ultima = 0;

                    var questoes = db.Questoes.Where<Questao>(q => q.ProvaId == toAdd.ProvaId);
                    foreach (Questao questao in questoes)
                    {
                        Resposta resposta = new Resposta();
                        resposta.Id = Guid.NewGuid();
                        resposta.QuestaoId = questao.Id;
 
                        toAdd.Respostas.Add(resposta);
                    }

                    db.Simulados.Add(toAdd);
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

        public Simulado find(Guid toFind)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Simulado> findAll()
        {
            throw new NotImplementedException();
        }

        public Simulado update(Simulado toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
