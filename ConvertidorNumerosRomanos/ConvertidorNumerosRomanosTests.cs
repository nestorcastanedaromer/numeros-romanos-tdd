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
        
        [Fact]
        public void Si_NumeroEs2_Debe_RetornarII()
        {
            string numeroRomano = CalculadoraNumerosRomanos.Calcular("2");

            numeroRomano.Should().Be("II");
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