using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteAPI.Model
{
    [Table("employee")]
    public class Employee
    {
        [Key]

        public int id { get; set; }

        public string? nome { get; set; }

        public int? idade { get; set; }

        public string? photo { get;  set; }

        public Employee()
    {
    }


        public Employee(string nome, int idade, string foto)
    {
        this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
        this.idade = idade;
        this.photo = foto;
    }

    }


    

}