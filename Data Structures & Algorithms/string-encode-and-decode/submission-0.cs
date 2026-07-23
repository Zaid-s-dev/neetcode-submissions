public class Solution {
    private static string delimiter = "#";

    public string Encode(IList<string> strs) {
        string encodedString = "";
        foreach(var str in strs){
            encodedString = encodedString + str.Length + delimiter + str;
        }
        return encodedString;
    }

    public List<string> Decode(string s) {
        List<string> decoded = [];

        while (s.Length>0)
        {
            int delimiterIndex = s.IndexOf(delimiter);
            string lenghtMarker = s.Substring(0, delimiterIndex);
            int numberOfCharacters = int.Parse(lenghtMarker);
            int endEndOfChunk =  lenghtMarker.Length + delimiter.Length+numberOfCharacters;
            string chunk = s.Substring(lenghtMarker.Length + delimiter.Length,numberOfCharacters);
            decoded.Add(chunk);
            s = s.Substring(endEndOfChunk);
        }
        return decoded;
    }
}
