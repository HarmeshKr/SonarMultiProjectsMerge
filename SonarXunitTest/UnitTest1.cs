using System;
using SonarLibrary;
using Xunit;

namespace SonarXunitTest
{
    public class TestClass
    {
        Numbers numbers;
        public TestClass()
        {
            numbers=new Numbers();
        }
        [Fact]
        public void ZeroDivideTest()
        {
             Assert.Throws<DivideByZeroException>(()=>
             {
                    numbers.Divide(10,0);
             });
        }
        [Fact]
        public void DivideTest()
        {
             double result= numbers.Divide(10,2);
             Assert.Equal(5,result);
             
        }
        [Fact]
        public void SubtractTest()
        {
             double result= numbers.Subtract(10,2);
             Assert.NotEqual(18,result);
             
        }
        [Fact]
        public void RootTest()
        {
             double result= numbers.Root(16);
             Assert.Equal(4,result);
             
        }
        [Fact]
        public void SumTest()
        {
             double result= numbers.Sum(16,14);
             Assert.Equal(30,result);
             
        }
    }
}
