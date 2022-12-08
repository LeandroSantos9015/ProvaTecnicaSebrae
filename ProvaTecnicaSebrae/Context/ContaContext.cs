using ProvaTecnicaSebrae.Interfaces;
using ProvaTecnicaSebrae.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaTecnicaSebrae.Context
{
    public class ContaContext : DbContext, IContaContext
    {
        private const string NOMEBANCO = "BancoConta";

        public ContaContext() : base(NOMEBANCO) { }

        public DbSet<ContaDTO> Conta { get; set; }

        public int Salvar() { return this.SaveChanges(); }
    }
}
