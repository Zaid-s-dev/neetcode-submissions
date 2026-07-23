public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var anagramGroups = new Dictionary<string, List<string>>();
        foreach(string word in strs)
        {
            char[] wordChars = word.ToCharArray();
            Array.Sort(wordChars);
            string sortedKey = new( wordChars);

            if(!anagramGroups.ContainsKey(sortedKey))
                anagramGroups[sortedKey] = [];

            anagramGroups[sortedKey].Add(word);
        }

        return [.. anagramGroups.Values];

    }
}
