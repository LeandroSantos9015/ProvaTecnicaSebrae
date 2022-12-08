using ProvaTecnicaSebrae.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaTecnicaSebrae.Interfaces
{
    public interface IContaService
    {
        int Create(ContaDTO conta);

        string Read();

        int Update(ContaDTO conta);

        int Delete(Int64 id);

    }
}
