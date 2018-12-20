using ExercicioUm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExercicioUm.Controllers.DAO
{
    public class PessoaDao
    {
        PessoaDBContext db = new PessoaDBContext();


        public bool Create(Pessoa pessoa)
        {
            try
            {
                db.Pessoas.Add(pessoa);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        public Pessoa Find(int id)
        {
            Pessoa pessoa = db.Pessoas.Find(id);
            return pessoa;
        }





    }
}