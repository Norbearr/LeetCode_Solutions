public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string minV = strs[0];
        string resol = "";
        
        foreach(string word in strs)//this foreach is to determine the shortest length string in the string array
        {
            if(word.Length < minV.Length)
            {
                minV = word;
            }

            if (word.Length == 0) { return ""; }
        }
        for(int i = 0; i < minV.Length; i++)//this for loop is for iterating through the letters
        {
            for(int j = 0; j < strs.Length; j++)//this for loop is for iterating through the words
            {
                if(strs[j][i] != minV[i])//
                return resol;
            }
            resol = resol + minV[i];
        }
        return resol;
        
    }
}
