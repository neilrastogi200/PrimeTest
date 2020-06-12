using System.Collections.Generic;
using PrimeNumbers;
using Xunit;

namespace PrimeNumberTest
{
    public class PrimeNumberTest
    {
        private readonly PrimeNumber _prime;
      
        public PrimeNumberTest()
        {
            _prime = new PrimeNumber();
        }

        [Fact]
        public void GetPrimeList_When_Input_Is_2_Returns_Valid_PrimeNumberList()
        {
            //Arrange
            var input = 2;

            List<int> expectedList = new List<int>() {2};

            //Act
            var actualResult = _prime.GetPrimeList(input);

            //Assert
            Assert.Equal(expectedList, actualResult);
        }

        [Fact]
        public void GetPrimeList_When_Input_Is_6_Returns_Valid_PrimeNumberList()
        {
            //Arrange
            var input = 6;

            List<int> expectedList = new List<int>() { 2, 3, 5 };

            //Act
            var actualResult = _prime.GetPrimeList(input);

            //Assert
            Assert.Equal(expectedList, actualResult);
        }

        [Fact]
        public void GetPrimeList_When_Input_Is_30_Returns_Valid_PrimeNumberList()
        {
            //Arrange
            var input = 30;

            List<int> expectedList = new List<int>() { 2, 3, 5, 7,11,13,17,19,23,29 };

            //Act
            var actualResult = _prime.GetPrimeList(input);

            //Assert
            Assert.Equal(expectedList, actualResult);
        }

        [Fact]
        public void GetPrimeList_When_Input_Is_50_Returns_Valid_PrimeNumberList()
        {
            //Arrange
            var input = 50;

            List<int> expectedList = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29,31,37,41,43,47};

            //Act
            var actualResult = _prime.GetPrimeList(input);

            //Assert
            Assert.Equal(expectedList, actualResult);
        }


        [Fact]
        public void CreatePrimeMultiplicationTable_When_Input_Is_List_Of_Prime_Numbers_Return_Multiplication_Answers()
        {
            //Arrange
            var input = new List<int>(){2,3,5};

            var expectedResult = new List<List<int>>()
                {new List<int>() {4, 6, 10}, new List<int>() {6, 9, 15}, new List<int>() {10, 15, 25}};

            //Act
            var actualResult =_prime.CreatePrimeMultiplicationTable(input);

            //Arrange
            Assert.Equal(expectedResult,actualResult);
            Assert.Equal(3,actualResult.Count);
        }

    }
}
