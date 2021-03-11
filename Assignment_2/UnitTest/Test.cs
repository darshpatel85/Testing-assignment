using System;
using Assignment_2;
using Xunit;

namespace UnitTest
{
    public class Test
    {
        [Fact]
        public void ConvertUpper1()
        {
            string a = "try";
            string result = a.ConvertUpper();
            Assert.Equal("TRY", result);
        }
        [Fact]
        public void ConvertUpper2()
        {
            string a = "try";
            string result = a.ConvertUpper();
            Assert.NotEqual("TrY", result);
        }
        [Fact]
        public void ConvertLower1()
        {
            string a = "TRY";
            string result = a.ConvertLower();
            Assert.Equal("try", result);
        }
        [Fact]
        public void ConvertLower2()
        {
            string a = "TRY";
            string result = a.ConvertLower();
            Assert.NotEqual("Try", result);
        }
        [Fact]
        public void ConvertTitleCase1()
        {
            string a = "try demo";
            string result = a.ConvertTitleCase();
            Assert.Equal("Try Demo", result);
        }
        [Fact]
        public void ConvertTitleCase2()
        {
            string a = "try demo";
            string result = a.ConvertTitleCase();
            Assert.NotEqual("TRY Demo", result);
        }
        [Fact]
        public void IsLower1()
        {
            string a = "try";
            bool result = a.IsLower();
            Assert.True(result);
        }
        [Fact]
        public void IsLower2()
        {
            string a = "Try";
            bool result = a.IsLower();
            Assert.False(result);
        }
        [Fact]
        public void IsUpper1()
        {
            string a = "TRY";
            bool result = a.IsUpper();
            Assert.True(result);
        }
        [Fact]
        public void IsUpper2()
        {
            string a = "TrY";
            bool result = a.IsUpper();
            Assert.False(result);
        }
        [Fact]
        public void ConvertCapitalize1()
        {
            string a = "try demo";
            string result = a.ConvertCapitalize();
            Assert.Equal("Try demo", result);
        }
        [Fact]
        public void ConvertCapitalize2()
        {
            string a = "try demo";
            string result = a.ConvertCapitalize();
            Assert.NotEqual("Try Demo", result);
        }
        [Fact]
        public void WordCount1()
        {
            string a = "try demo";
            int result = a.WordCount();
            Assert.Equal(2, result);
        }
        [Fact]
        public void WordCount2()
        {
            string a = "try demo";
            int result = a.WordCount();
            Assert.NotEqual(1, result);
        }
        [Fact]
        public void RemoveLastCharacter1()
        {
            string a = "try";
            string result = a.RemoveLastCharacter();
            Assert.Equal("tr", result);
        }
        [Fact]
        public void RemoveLastCharacter2()
        {
            string a = "try";
            string result = a.RemoveLastCharacter();
            Assert.NotEqual("try", result);
        }
        [Fact]
        public void ValidNumeric1()
        {
            string a = "333";
            bool result = a.ValidNumeric();
            Assert.True(result);
        }
        [Fact]
        public void ValidNumeric2()
        {
            string a = "33a3";
            bool result = a.ValidNumeric();
            Assert.False(result);
        }
        [Fact]
        public void StringToNumber1()
        {
            string a = "454";
            int? result = a.StringToNumber();
            Assert.Equal(454, result);
        }
        [Fact]
        public void StringToNumber2()
        {
            string a = "33a3";
            int? result = a.StringToNumber();
            Assert.Null(result);
        }
    }
}
