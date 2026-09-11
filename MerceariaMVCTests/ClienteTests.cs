using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MerceariaMVC.Models;

namespace MerceariaMVCTests
{
    public class ClienteTests
    {
        [Fact]
        public void Verificar_Idade_Invalido_se_ForMenorQueDezoito()
        {
            //Arrange
            var cliente = new Cliente
            {
                Nome = "Robert",
                Email = "Robert@gmail.com",
                Idade = 17,
                Ativo = false,
                
            };

            //Act

            var resultado = cliente.Validacao();

            //Assert
            Assert.False(resultado);
        }
        [Fact]
        public void Verificar_Gmail_Valido()
        {
            //Arrange
            var cliente = new Cliente
            {
                Nome = "Rogério Sacrificio",
                Email = "RogerioSacrificio01gmail.com",
                Idade = 59,
                Ativo = true,

            };

            //Act

            var resultado = cliente.Validacao();

            //Assert
            Assert.False(resultado);
        }
        [Fact]

        public void Verificar_Nome_Nulo_ou_Vazio_Invalido()
        {
            var cliente = new Cliente
            {

                Nome = "",
                Email = "Prado012gmail.com",
                Idade = 20,
                Ativo = true,

            };

            //Act 

            var resultado = cliente.Validacao();

            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void Verificar_Se_Cliente_Esta_Ativo()
        {
            var cliente = new Cliente
            {

                Nome = "China",
                Email = "ChinaFulero023.com",
                Idade = 20,
                Ativo = false,

            };

            var resultado = cliente.PodeComprar();

            Assert.False(resultado);
        }

        [Fact]
        public void Cliente_apto_para_comprar()
        {
            var cliente = new Cliente
            {

                Nome = "Paulo",
                Email = "Madruga03948@.com",
                Idade = 20,
                Ativo = true

            };

            var resultado = cliente.Validacao();

            Assert.True(resultado);
        }

    }
}
