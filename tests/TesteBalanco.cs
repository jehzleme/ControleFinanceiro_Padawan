using NUnit.Framework;
using Padawan.Financeiro.Negocio;
using Padawan.Financeiro.Negocio.Model;
namespace Tests
{
    public class TesteBalanco
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AdicionarCredito()
        {
            Balanco balanco = new Balanco();
            balanco.Add(new Credito(1000.00));
            Assert.Equals(1000.00, balanco.Saldo);
        }

        [Test]
        public void AdicionarDebito()
        {
            Balanco balanco = new Balanco();
            balanco.Add(new Debito());
            Assert.Pass();
        }

        [Test]
        public void AdicionarDebitoCredito()
        {
            Balanco balanco = new Balanco();
            balanco.Add(new Debito());
            balanco.Add(new Credito());
            Assert.Pass();
        }

        [Test]
        public void BalancoInicial()
        {
            Balanco balanco = new Balanco();
            Assert.Pass();
        }
    }
}