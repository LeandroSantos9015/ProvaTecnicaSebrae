using ProvaTecnicaSebrae.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaTecnicaSebrae.Interfaces
{
    public interface IContaContext
    {
        DbSet<ContaDTO> Conta { get; }

        int Salvar();


    }
}
