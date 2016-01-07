using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeChallenge2;
using System.Collections.Generic;

namespace StatisticsCalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        StatisticsCalculator calculator;

        [TestInitialize]
        public void Initialize()
        {
            calculator = new StatisticsCalculator(); 
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullValuesReturnError()
        {
            var result = calculator.CalculateStatistics(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmptyValuesReturnError()
        {
            var result = calculator.CalculateStatistics(new List<int>());
        }

        [TestMethod]
        public void OneValueReturnsItselfAsMin()
        {
            var oneElementList = MakeOneElementList();
 
            var result = calculator.CalculateStatistics(oneElementList);

            Assert.AreEqual(100, result.Min);
        }

        [TestMethod]
        public void OneValueReturnsItselfAsMax()
        {
            var oneElementList = MakeOneElementList();

            var result = calculator.CalculateStatistics(oneElementList);

            Assert.AreEqual(100, result.Max);
        }

        [TestMethod]
        public void OneValueReturnsItselfAsAverage()
        {
            var oneElementList = MakeOneElementList();

            var result = calculator.CalculateStatistics(oneElementList);

            Assert.AreEqual(100, result.Average);
        }

        [TestMethod]
        public void TwoValueReturnsHigherNumberAsMax()
        {
            var twoElementList = MakeTwoElementList();

            var result = calculator.CalculateStatistics(twoElementList);

            Assert.AreEqual(200, result.Max);
        }

        [TestMethod]
        public void TwoValueReturnsLowerNumberAsMin()
        {
            var twoElementList = MakeTwoElementList();

            var result = calculator.CalculateStatistics(twoElementList);

            Assert.AreEqual(100, result.Min);
        }

        [TestMethod]
        public void TwoValueReturnsAverageNumberAsAverage()
        {
            var twoElementList = MakeTwoElementList();

            var result = calculator.CalculateStatistics(twoElementList);

            Assert.AreEqual(150, result.Average);
        }

        [TestMethod]
        public void ExampleSequencAverageIsCorrect()
        {
            var exampleSequence = MakeExampleSequence();

            var result = calculator.CalculateStatistics(exampleSequence);

            Assert.AreEqual(400, result.Average);
        }

        [TestMethod]
        public void ExampleSequenceStdDeviationIsCorrect()
        {
            var exampleSequence = MakeExampleSequence();

            var result = calculator.CalculateStatistics(exampleSequence);

            Assert.AreEqual((decimal) 353.55, result.StandardDeviation);
        }

        private List<int> MakeExampleSequence()
        {
            // Números: 100, 200, 1000, 300

            var exampleList = new List<int>();
            exampleList.Add(100);
            exampleList.Add(200);
            exampleList.Add(1000);
            exampleList.Add(300);
            return exampleList;
        }


        private static List<int> MakeOneElementList()
        {
            var oneElementList = new List<int>();
            oneElementList.Add(100);
            return oneElementList;
        }

        private static List<int> MakeTwoElementList()
        {
            var oneElementList = new List<int>();
            oneElementList.Add(100);
            oneElementList.Add(200);
            return oneElementList;
        }
    }
}
