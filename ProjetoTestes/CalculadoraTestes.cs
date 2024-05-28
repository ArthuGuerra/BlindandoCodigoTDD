using Xunit;
using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjetoTestes;

public class CalculadoraTestes
{
    private Calculadora _calc;

    public CalculadoraTestes()
    {
         _calc = new Calculadora();
    }

    [Theory]
    [InlineData(2,3,5)]
    [InlineData(5,4,9)]
    [InlineData(3,4,7)]
    [InlineData(9,1,10)]
    [InlineData(6,5,11)]
    public void TesteSomar(int num1, int num2, int result)
    {
        // arrange
        
        // act
        double resultCalc = _calc.Somar(num1,num2);
        // assert
        Assert.Equal(result, resultCalc); 
    }


    [Theory]
    [InlineData(5,2,3)]
    [InlineData(10,4,6)]
    [InlineData(8,4,4)]
    [InlineData(5,4,1)]
    [InlineData(6,5,1)]
    public void TesteSubtrair(int num1, int num2, int result)
    {
        // arrange
        
        // act
        double resultCalc = _calc.Sub(num1,num2);
        // assert
        Assert.Equal(result, resultCalc); 
    }

    [Theory]
    [InlineData(5,2,10)]
    [InlineData(10,4,40)]
    [InlineData(8,4,32)]
    [InlineData(5,4,20)]
    [InlineData(0,5,0)]
    public void TesteMultiplicar(int num1, int num2, int result)
    {
        // arrange
        
        // act
        double resultCalc = _calc.Mult(num1,num2);
        // assert
        Assert.Equal(result, resultCalc); 
    }


     [Theory]
    [InlineData(6,3,2)]
    [InlineData(10,2,5)]
    [InlineData(8,4,2)]
    [InlineData(2,2,1)]
    [InlineData(8,1,8)]
    public void TesteDividir(int num1, int num2, int result)
    {
        // arrange
        
        // act
        double resultCalc = _calc.Dividir(num1,num2);
        // assert
        Assert.Equal(result, resultCalc); 
    }

    // [Fact]
    // public void TestarDivisaoPorZero()
    // {
    //     Assert.Throws<DivideByZeroException>(
    //         () => _calc.Dividir(3,0));
    // }

      [Fact]
    public void TestasHistorico()
    {
        _calc.Somar(1,2);
        _calc.Somar(2,5);
        _calc.Somar(5,5);
        _calc.Somar(6,4);

        var lista = _calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}