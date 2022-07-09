using GL;
using System.Collections.Generic;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Dictionary<int,List<string>> regularVerbsEndingByEn = GermanVerbsTerm.InPresent("spielen");
            Dictionary<int, List<string>> correctRegularVerbsEndingBy_EN = new Dictionary<int, List<string>> {
                {1, new List<string>{ "ich", "spiele" }},
                {2, new List<string>{ "du", "spielst" }},
                {3, new List<string>{ "er", "spielt" }},
                {4, new List<string>{ "sie", "spielt" }},
                {5, new List<string>{ "es", "spielt" }},
                {6, new List<string>{ "wir", "spielen" }},
                {7, new List<string>{ "ihr", "spielt" }},
                {8, new List<string>{ "sie", "spielen" }},
                {9, new List<string>{ "Sie", "spielen" }},
            };

            Dictionary<int, List<string>> regularVerbsEndingBy_ELN = GermanVerbsTerm.InPresent("klingeln");
            Dictionary<int, List<string>> correctRegularVerbsEndingBy_ELN = new Dictionary<int, List<string>> {
                {1, new List<string>{ "ich", "klingele" }},
                {2, new List<string>{ "du", "klingelst" }},
                {3, new List<string>{ "er", "klingelt" }},
                {4, new List<string>{ "sie", "klingelt" }},
                {5, new List<string>{ "es", "klingelt" }},
                {6, new List<string>{ "wir", "klingeln" }},
                {7, new List<string>{ "ihr", "klingelt" }},
                {8, new List<string>{ "sie", "klingeln" }},
                {9, new List<string>{ "Sie", "klingeln" }},
            };

            Dictionary<int, List<string>> regularVerbsEndingBy_ERN = GermanVerbsTerm.InPresent("klettern");
            Dictionary<int, List<string>> correctRegularVerbsEndingBy_ERN = new Dictionary<int, List<string>> {
                {1, new List<string>{ "ich", "klettere" }},
                {2, new List<string>{ "du", "kletterst" }},
                {3, new List<string>{ "er", "klettert" }},
                {4, new List<string>{ "sie", "klettert" }},
                {5, new List<string>{ "es", "klettert" }},
                {6, new List<string>{ "wir", "klettern" }},
                {7, new List<string>{ "ihr", "klettert" }},
                {8, new List<string>{ "sie", "klettern" }},
                {9, new List<string>{ "Sie", "klettern" }},
            };


            foreach ( var key in regularVerbsEndingByEn.Keys) Assert.Equal(correctRegularVerbsEndingBy_EN[key], regularVerbsEndingByEn[key] );

            foreach (var key in regularVerbsEndingBy_ELN.Keys) Assert.Equal(correctRegularVerbsEndingBy_ELN[key], regularVerbsEndingBy_ELN[key] );
            
            foreach (var key in regularVerbsEndingBy_ELN.Keys) Assert.Equal(correctRegularVerbsEndingBy_ERN[key], regularVerbsEndingBy_ERN[key]);
            


        }
    }
}