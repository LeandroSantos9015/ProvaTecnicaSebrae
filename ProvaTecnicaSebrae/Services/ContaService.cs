using Newtonsoft.Json;
using ProvaTecnicaSebrae.Interfaces;
using ProvaTecnicaSebrae.Models;
using System;
using System.Linq;

namespace ProvaTecnicaSebrae.Services
{
    public class ContaService : IContaService
    {
        private IContaContext _contaContext;

        public ContaService(IContaContext contaContext)
        {
            _contaContext = contaContext;
        }

        public int Create(ContaDTO conta)
        {
            Validacao(conta, OperacaoCadastro.Create);

            _contaContext.Conta.Add(conta);

            return _contaContext.Salvar();
        }

        public int Delete(long id)
        {
            Validacao(id, OperacaoCadastro.Delete);

            var contaRemovida = _contaContext.Conta.FirstOrDefault(x => x.Id == id);

            if (contaRemovida != null)
                _contaContext.Conta.Remove(contaRemovida);

            return _contaContext.Salvar();
        }

        public string Read()
        {
            var retorno = _contaContext.Conta.ToList();

            var settings = new JsonSerializerSettings { Formatting = Formatting.Indented };

            return JsonConvert.SerializeObject(retorno, settings);
        }

        public int Update(ContaDTO conta)
        {
            Validacao(conta, OperacaoCadastro.Update);

            var corrente = _contaContext.Conta.FirstOrDefault(x => x.Id == conta.Id);

            if (corrente != null)
            {
                corrente.Nome = conta.Nome;
                corrente.Descricao = conta.Descricao;

                return _contaContext.Salvar();
            }

            return 0;
        }


        private void Validacao(long id, OperacaoCadastro op)
        {
            var conta = new ContaDTO { Id = id, Descricao = "", Nome = "" };

            Validacao(conta, op);
        }

        private void Validacao(ContaDTO contaDTO, OperacaoCadastro op)
        {
            string msg = "";

            if (string.IsNullOrEmpty(contaDTO.Descricao))
                msg += "Descrição inválida";

            if (string.IsNullOrEmpty(contaDTO.Nome))
                msg += "Nome inválido";

            if ((contaDTO.Id is null || contaDTO.Id == 0) && !op.Equals(OperacaoCadastro.Create))
                msg += "Id inválido";

            if (!string.IsNullOrEmpty(msg))
                throw new ArgumentException(msg);

        }
    }

    internal enum OperacaoCadastro
    {
        Create,
        Read,
        Update,
        Delete
    }
}