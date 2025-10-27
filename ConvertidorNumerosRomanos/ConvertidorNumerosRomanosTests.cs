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
            string numeroRomano = CalculadoraNumerosRomanos.Calcular(1);

            numeroRomano.Should().Be("I");
        }

        [Fact]
        public void Si_NumeroEs2_Debe_RetornarII()
        {
            string numeroRomano = CalculadoraNumerosRomanos.Calcular(2);

            numeroRomano.Should().Be("II");
        }

        [Fact]
        public void Si_NumeroEs3_Debe_RetornarIII()
        {
            string numeroRomano = CalculadoraNumerosRomanos.Calcular(3);

            numeroRomano.Should().Be("III");
        }

        [Fact]
        public void Si_NumeroEs4_Debe_RetornarIV()
        {
            string numeroRomano = CalculadoraNumerosRomanos.Calcular(4);

            numeroRomano.Should().Be("IV");
        }

        [Fact]
        public void Si_NumeroEs5_Debe_RetornarV()
        {
            string numeroRomano = CalculadoraNumerosRomanos.Calcular(5);

            numeroRomano.Should().Be("V");
        }
        
        [Fact]
        public void Si_NumeroEs6_Debe_RetornarVI()
        {
            string numeroRomano = CalculadoraNumerosRomanos.Calcular(6);

            numeroRomano.Should().Be("VI");
        }
    }

    internal static class CalculadoraNumerosRomanos
    {
        internal static string Calcular(int numeroArabigo)
        {
            if (numeroArabigo == 1)
                return "I";
            else if (numeroArabigo == 2)
                return "II";
            else if (numeroArabigo == 3)
                return "III";
            else if (numeroArabigo == 4)
                return "IV";
            else
                return "V";
        }
    }
}