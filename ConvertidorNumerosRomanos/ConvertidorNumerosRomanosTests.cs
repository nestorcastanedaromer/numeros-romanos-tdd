using System;
using Xunit;
using FluentAssertions;

namespace ConvertidorNumerosRomanos.Tests
{
    public class ConvertidorNumerosRomanosTests
    {
        [Fact]
        public void Si_NumeroEs1_Debe_RetornarI()
        {
            var calculadora = new CalculadoraNumerosRomanos();

            var numeroRomano= calculadora.Calcular("1");

            numeroRomano.Should().Be("I");
        }
    }

    internal class CalculadoraNumerosRomanos
    {
        public CalculadoraNumerosRomanos()
        {
        }

        internal string Calcular(string v)
        {
            throw new NotImplementedException();
        }
    }
}