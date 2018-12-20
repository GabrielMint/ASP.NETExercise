using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExercicioUm.Models
{
    public class Pessoa
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public Pessoa(string nome, DateTime nascimento, string cpf, string email, string tel)
        {
            Nome = nome;
            DataNascimento = nascimento;
            Cpf = cpf;
            Email = email;
            Telefone = tel;
        }

        public Pessoa()
        {

        }


    }

    public class PessoaDBContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}