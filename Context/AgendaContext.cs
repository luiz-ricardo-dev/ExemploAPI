using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExemploAPI.Context
{
    public class AgendaContext : DbContext
    {   //Context para representar o banco de dados
        public AgendaContext(DbContextOptions<AgendaContext> options): base( options )
        {

        }
        //DbSet para representar uma tabela (entidade)
        public DbSet<Contato> contatos{get ; set;}
    }
}