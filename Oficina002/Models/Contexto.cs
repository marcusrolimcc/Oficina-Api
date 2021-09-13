using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina002.Models
{
    
    public class Contexto : DbContext
    {
        public DbSet<Atendimento> Atendimentos { get; set; }
        public DbSet<Cadastro_Atendimento> Cadastro_Atendimentos { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Oficina> Oficinas { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Tipo_Pagamento> Tipo_Pagamentos { get; set; }
        public DbSet<Tipo_Servico> Tipo_Servicos { get; set; }

    public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }
    }
}

