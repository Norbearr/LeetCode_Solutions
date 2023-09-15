public class Solution {
    public bool IsValid(string s) {
        Dictionary<string, string> myDict = new Dictionary<string, string>();
        
        myDict.Add("(", ")");
        myDict.Add("{", "}");
        myDict.Add("[", "]");        
    }
}
