using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Entities
{
     class Person
    {
        public string email { get; set; }
        public string senha { get; set; }

        public Person(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }

        public override string ToString()
        {
            return "Email: " + email +"\n" +"Senha: " + senha +"\n";
        }
    }
}
