namespace GL
{
    /// <summary>
    /// 
    /// </summary>
    /// <link src="https://www.thegermanprofessor.com/present-tense-verbs/">Source 2</link>
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
            string ending = EndingDigitOfVerbs(2, verb);
            Dictionary<int, List<string>> verbsResult = new();
            bool IsSlightVariationFor_DuPronom = IsVariationEndingFor_DuPronon(verb);
            if (ending.Equals("en")) return RegularDeclinaisonOfVerbTerminatedBy_EN(verb, IsSlightVariationFor_DuPronom);
            else
            {
                ending = EndingDigitOfVerbs(3, verb);
                if (ending.Equals("eln"))
                {
                    verbsResult = RegularDeclinaisonOfVerbTerminatedBy_ELN(verb, IsSlightVariationFor_DuPronom);
                }
                else if (ending.Equals("ern"))
                {
                    verbsResult = RegularDeclinaisionOfVerbsTerminatedVy_ERN(verb, IsSlightVariationFor_DuPronom);
                }
            }
            return verbsResult;
        }

        private static bool IsVariationEndingFor_DuPronon(string verb)
        {
            List<char> particluarEndingOfDu = new List<char> { 'z', 's', 'x','ß' };
            return particluarEndingOfDu.Contains(verb.ElementAt(verb.Length -2)) || particluarEndingOfDu.Contains(verb.ElementAt(verb.Length - 3));
        }

        private static Dictionary<int, List<string>> RegularDeclinaisionOfVerbsTerminatedVy_ERN(string verb, bool isVariationFor_DuPronom)
        {
            string duEnding = GetDuEnding(isVariationFor_DuPronom);
            string prefix = verb.Substring(0, verb.Length - 1);
            return new Dictionary<int, List<string>> {
                        {1, new List<string>{ "ich", prefix + "e" }},
                        {2, new List<string>{ "du", prefix + duEnding}},
                        {3, new List<string>{ "er", prefix + "t" }},
                        {4, new List<string>{ "sie", prefix + "t" }},
                        {5, new List<string>{ "es", prefix + "t" }},
                        {6, new List<string>{ "wir", prefix + "n" }},
                        {7, new List<string>{ "ihr", prefix + "t" }},
                        {8, new List<string>{ "sie", prefix + "n" }},
                        {9, new List<string>{ "Sie", prefix + "n" }},
                    };
        }

        private static Dictionary<int, List<string>> RegularDeclinaisonOfVerbTerminatedBy_ELN(string verb, bool isVariationFor_DuPronom)
        {
            string duEnding = GetDuEnding(isVariationFor_DuPronom);

            string prefix = verb.Substring(0, verb.Length - 1);
            return new Dictionary<int, List<string>>
                    {
                        { 1, new List<string> { "ich", prefix + "e" } },
                        { 2, new List<string> { "du", prefix+ duEnding } },
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

        private static Dictionary<int, List<string>> RegularDeclinaisonOfVerbTerminatedBy_EN(string verb, bool isVariationFor_DuPronom)
        {
            string duEnding = GetDuEnding(isVariationFor_DuPronom);

            string prefix = verb.Substring(0, verb.Length - 2);
            return new Dictionary<int, List<string>>() {
                    { 1, new List<string> { "ich", prefix+ "e" }},
                    { 2, new List<string> { "du", prefix+ duEnding }},
                    { 3, new List<string> { "er", prefix+ "t" }},
                    { 4, new List<string> { "sie", prefix+ "t" }},
                    { 5, new List<string> { "es", prefix+ "t" }},
                    { 6, new List<string> { "wir", prefix+ "en" }},
                    { 7, new List<string> { "ihr", prefix+ "t" }},
                    { 8, new List<string> { "sie", prefix+ "en" }},
                    { 9, new List<string> { "Sie", prefix+ "en" }}
                };
        }

        private static string GetDuEnding(bool isVariationFor_DuPronom)
        {
            string duEnding = "st";
            if (isVariationFor_DuPronom) duEnding = "t";
            else duEnding = "st";
            return duEnding;
        }
    }
}