using System;
using Xunit;
using MyCompany.CoreLibary;


namespace MyCompany.CoreLibary.Tests
{
    
    public class StringLibraryTests
    {
        //Live Unit testing demo as per https://docs.microsoft.com/en-us/visualstudio/test/live-unit-testing-start?tabs=csharp

        [Fact]
        public void TestStartsWithUpper()
        {
            // Tests that we expect to return true.
            string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.True(result,
                              $"Expected for '{word}': true; Actual: {result}");
            }
        }

        [Fact]
        public void TestDoesNotStartWithUpper()
        {
            // Tests that we expect to return false.
            string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                               "1234", ".", ";", " " };
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.False(result,
                               $"Expected for '{word}': false; Actual: {result}");
            }
        }

        [Fact]
        public void DirectCallWithNullOrEmpty()
        {
            // Tests that we expect to return false.
            string[] words = { String.Empty, null };
            foreach (var word in words)
            {
                bool result = StringLibrary.StartsWithUpper(word);
                Assert.False(result,
                               $"Expected for '{(word == null ? "<null>" : word)}': " +
                               $"false; Actual: {result}");
            }
        }
    }
}