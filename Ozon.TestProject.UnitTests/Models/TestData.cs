using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace TestProject.UnitTests.Models
{
    class TestData
    {
        [JsonPropertyName("inputString")]
        public string InputString { get; set;}

        [JsonPropertyName("expectedResult")]
        public string ExpectedResult { get; set;}
    }
}
