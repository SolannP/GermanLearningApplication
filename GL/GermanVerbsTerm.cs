namespace GL
{
    public static class GermanVerbsTerm
    {

        public static Dictionary<int, string> PronounsSubject = new Dictionary<int, string>()
        {
            { 1, "ich" },
            { 2, "du" } ,
            { 3, "er"}, 
            { 4, "sie"}, 
            { 5,"es" },
            { 6, "wir"},
            { 7, "ihr"},
            { 8, "sie" }, 
            { 9,"Sie"}
        };
        public static Dictionary<int, List<string>> InPresent(string verb)
        {
            string ending = EndingDigitOfVerbs(2,verb);
            if (ending.Equals("en")) return RegularDeclinaisonOfVerbTerminatedBy_EN(verb);
            else
            {
                ending = EndingDigitOfVerbs(3, verb);
                if (ending.Equals("eln"))
                {
                    return RegularDeclinaisonOfVerbTerminatedBy_ELN(verb);
                }
                else if (ending.Equals("ern"))
                {
                    return RegularDeclinaisionOfVerbsTerminatedVy_ERN(verb);
                }
            }
            return null;
        }

        private static Dictionary<int, List<string>> RegularDeclinaisionOfVerbsTerminatedVy_ERN(string verb)
        {
            string prefix = verb.Substring(0, verb.Length - 1);
            return new Dictionary<int, List<string>> {
                        {1, new List<string>{ "ich", prefix + "e" }},
                        {2, new List<string>{ "du", prefix + "st" }},
                        {3, new List<string>{ "er", prefix + "t" }},
                        {4, new List<string>{ "sie", prefix + "t" }},
                        {5, new List<string>{ "es", prefix + "t" }},
                        {6, new List<string>{ "wir", prefix + "n" }},
                        {7, new List<string>{ "ihr", prefix + "t" }},
                        {8, new List<string>{ "sie", prefix + "n" }},
                        {9, new List<string>{ "Sie", prefix + "n" }},
                    };
        }

        private static Dictionary<int, List<string>> RegularDeclinaisonOfVerbTerminatedBy_ELN(string verb)
        {
            string prefix = verb.Substring(0, verb.Length - 1);
            return new Dictionary<int, List<string>>
                    {
                        { 1, new List<string> { "ich", prefix + "e" } },
                        { 2, new List<string> { "du", prefix+ "st" } },
                        { 3, new List<string> { "er", prefix + "t" } },
                        { 4, new List<string> { "sie", prefix + "t" } },
                        { 5, new List<string> { "es", prefix + "t" } },
                        { 6, new List<string> { "wir", prefix + "n" } },
                        { 7, new List<string> { "ihr", prefix + "t" } },
                        { 8, new List<string> { "sie", prefix + "n" } },
                        { 9, new List<string> { "Sie", prefix + "n" } },
                    };
        }

        private static string EndingDigitOfVerbs(int digitFromEnd,string verb)
        {
            return verb.Substring(verb.Length - digitFromEnd, digitFromEnd);
        }

        private static Dictionary<int, List<string>> RegularDeclinaisonOfVerbTerminatedBy_EN(string verb)
        {
            string prefix = verb.Substring(0, verb.Length - 2);
            return new Dictionary<int, List<string>>() {
                    { 1, new List<string> { "ich", prefix+ "e" }},
                    { 2, new List<string> { "du", prefix+ "st" }},
                    { 3, new List<string> { "er", prefix+ "t" }},
                    { 4, new List<string> { "sie", prefix+ "t" }},
                    { 5, new List<string> { "es", prefix+ "t" }},
                    { 6, new List<string> { "wir", prefix+ "en" }},
                    { 7, new List<string> { "ihr", prefix+ "t" }},
                    { 8, new List<string> { "sie", prefix+ "en" }},
                    { 9, new List<string> { "Sie", prefix+ "en" }}
                };
        }
    }
}