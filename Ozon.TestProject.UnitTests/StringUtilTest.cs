using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using TestProject.UnitTests.Models;


namespace TestProject.UnitTests
{
    public class StringUtilTest
    {
        private List<TestData> dataList;


        [SetUp]
        public void SetUp()
        {
            var jsonString = File.ReadAllText("./Data/TestData.json");
            dataList = JsonConvert.DeserializeObject<List<TestData>>(jsonString);
        }



        [Test]
        public void RemoveExcessSpaceTest()
        {
            foreach (var val in dataList)
            {
                var result = val.InputString.RemoveExcessSpace();
                Console.WriteLine($"Input string: {val.InputString};\nResult: {result};\nExpected result: {val.ExpectedResult}");
                Assert.AreEqual(val.ExpectedResult, result, $"Input string {val.InputString} check");
                Console.WriteLine("*****************************************************************");
            }
        }
    }
}