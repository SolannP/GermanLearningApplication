using GL;
using System.Collections.Generic;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Spelen = to play = jouer
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
            // klingeln = to ring = sonner
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
            // Kletern = to climb = escalader
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
            // Sitzen = to sit = s'assoir
            Dictionary<int, List<string>> regularRegularVerbsHaving_z = GermanVerbsTerm.InPresent("sitzen");
            Dictionary<int, List<string>> correctRegularVerbsHaving_z = new Dictionary<int, List<string>> {
                {1, new List<string>{ "ich", "sitze" }},
                {2, new List<string>{ "du", "sitzt" }},
                {3, new List<string>{ "er", "sitzt" }},
                {4, new List<string>{ "sie", "sitzt" }},
                {5, new List<string>{ "es", "sitzt" }},
                {6, new List<string>{ "wir", "sitzen" }},
                {7, new List<string>{ "ihr", "sitzt" }},
                {8, new List<string>{ "sie", "sitzen" }},
                {9, new List<string>{ "Sie", "sitzen" }},
            };
            //Faxen = to fax = faxer
            Dictionary<int, List<string>> regularRegularVerbsHaving_x = GermanVerbsTerm.InPresent("faxen");
            Dictionary<int, List<string>> correctRegularVerbsHaving_x = new Dictionary<int, List<string>> {
                {1, new List<string>{ "ich", "faxe" }},
                {2, new List<string>{ "du", "faxt" }},
                {3, new List<string>{ "er", "faxt" }},
                {4, new List<string>{ "sie", "faxt" }},
                {5, new List<string>{ "es", "faxt" }},
                {6, new List<string>{ "wir", "faxen" }},
                {7, new List<string>{ "ihr", "faxt" }},
                {8, new List<string>{ "sie", "faxen" }},
                {9, new List<string>{ "Sie", "faxen" }},
            };

            // ALT + 225 for ﬂ
            // Gieﬂt or Giest = to pour / spill = verser
            Dictionary<int, List<string>> regularRegularVerbsHaving_ﬂ = GermanVerbsTerm.InPresent("gieﬂen");
            Dictionary<int, List<string>> correctRegularVerbsHaving_ﬂ = new Dictionary<int, List<string>> {
                {1, new List<string>{ "ich", "gieﬂe" }},
                {2, new List<string>{ "du", "gieﬂt" }},
                {3, new List<string>{ "er", "gieﬂt" }},
                {4, new List<string>{ "sie", "gieﬂt" }},
                {5, new List<string>{ "es", "gieﬂt" }},
                {6, new List<string>{ "wir", "gieﬂen" }},
                {7, new List<string>{ "ihr", "gieﬂt" }},
                {8, new List<string>{ "sie", "gieﬂen" }},
                {9, new List<string>{ "Sie", "gieﬂen" }},
            };

            foreach ( var key in regularVerbsEndingByEn.Keys) Assert.Equal(correctRegularVerbsEndingBy_EN[key], regularVerbsEndingByEn[key] );

            foreach (var key in regularVerbsEndingBy_ELN.Keys) Assert.Equal(correctRegularVerbsEndingBy_ELN[key], regularVerbsEndingBy_ELN[key] );
            
            foreach (var key in regularVerbsEndingBy_ERN.Keys) Assert.Equal(correctRegularVerbsEndingBy_ERN[key], regularVerbsEndingBy_ERN[key]);

            foreach (var key in regularRegularVerbsHaving_z.Keys) Assert.Equal(correctRegularVerbsHaving_z[key], regularRegularVerbsHaving_z[key]);

            foreach (var key in regularRegularVerbsHaving_x.Keys) Assert.Equal(correctRegularVerbsHaving_x[key], regularRegularVerbsHaving_x[key]);

            foreach (var key in regularRegularVerbsHaving_ﬂ.Keys) Assert.Equal(correctRegularVerbsHaving_ﬂ[key], regularRegularVerbsHaving_ﬂ[key]);
        }
    }
}