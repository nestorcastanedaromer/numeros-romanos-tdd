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
            string numeroRomano = CalculadoraNumerosRomanos.Calcular("1");

            numeroRomano.Should().Be("I");
        }
    }

    internal static class CalculadoraNumerosRomanos
    {
        internal static string Calcular(string numeroArabigo)
        {
            return "I";
        }
    }
}