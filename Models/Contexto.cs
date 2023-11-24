using Microsoft.EntityFrameworkCore;

namespace SistemaLaboratorio.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        {
            //public Dbset<Paciente> Paciente {get; set;}
            //public Dbset<Profissional> Profissional {get; set;}
            //public Dbset<Cargo> Cargo {get; set;}
            //public Dbset<Estado> Estado {get; set;}
            //public Dbset<Cidade> Cidade {get; set;}
            //public Dbset<Resultado> Resultado {get; set;}
            //public Dbset<Exame> Exame {get; set;}
        }
    }
}

   