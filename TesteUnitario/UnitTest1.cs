using ExpectedObjects;
using ProvaTecnicaSebrae.Context;
using ProvaTecnicaSebrae.Interfaces;
using ProvaTecnicaSebrae.Models;
using ProvaTecnicaSebrae.Services;
using System;
using Xunit;

namespace TesteUnitario
{
    public class UnitTest1
    {
        [Fact]
        public void DeveAdicionarCurso()
        {
            var informado = new ContaDTO
            {
                Descricao = "Descrição",
                Id = 0,
                Nome = "Leandro"
            };

            var esperado = new ContaDTO
            {
                Descricao = "Descrição",
                Id = 0,
                Nome = "Leandro"
            };

            esperado.ToExpectedObject().ShouldMatch(informado);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void NaoDeveAtualizarComDescricaoNulaOuVazia(string descricao)
        {
            IContaContext context = new ContaContext();

            var informado = new ContaDTO
            {
                Descricao = descricao,
                Id = 0,
                Nome = "Leandro"
            };

            Assert.Throws<ArgumentException>(() => new ContaService(context).Update(informado));

        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void NaoDeveAtualizarComNomeNuloOuVazio(string nome)
        {
            IContaContext context = new ContaContext();

            var informado = new ContaDTO
            {
                Descricao = "Descricao",
                Id = 0,
                Nome = nome
            };

            Assert.Throws<ArgumentException>(() => new ContaService(context).Update(informado));

        }

        [Theory]
        [InlineData(null)]
        [InlineData(0)]
        public void NaoDeveAtualizarSemTerUmIdValido(int? id)
        {
            IContaContext context = new ContaContext();

            var informado = new ContaDTO
            {
                Descricao = "Descricao",
                Id = id,
                Nome = "Leandro"
            };

            Assert.Throws<ArgumentException>(() => new ContaService(context).Update(informado));
        }
    }
}
