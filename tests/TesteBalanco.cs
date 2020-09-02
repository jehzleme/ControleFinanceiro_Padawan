using NUnit.Framework;
using NUnit.Framework.Internal.Commands;
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


        public void ValorSaldoInicial()
        {
            Balanco balanco = new Balanco();
            Assert.Equals(0.0, balanco.Saldo);
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
            balanco.Add(new Debito(650.25));
            Assert.Equals(349.75, balanco.Saldo);
        }

        [Test]
        public void AdicionarDebitoCredito()
        {
            Balanco balanco = new Balanco();
            balanco.Add(new Debito(200.00));
            balanco.Add(new Credito(550.25));
            Assert.Equals(700.00, balanco.Saldo);
        }

    }
}