using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaTecnicaSebrae.Interfaces
{
    public interface IEnderecoService
    {
        Task<string> RetornaEndereco(string cep);

    }
}
