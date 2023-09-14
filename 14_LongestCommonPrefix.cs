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
        }
        if(minV.Length == 0)//if the string is empty then just return the empty string
        {
            return "";
        }
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < minV.Length; i++)//this for loop is for iterating through the letters
        {
            //I want to build the string here bc if it passed all the checks in the other loop then i can add it

            for(int j = 0; j < strs.Length; j++)//this for loop is for iterating through the words
            {
                if(strs[j][i] != minV[i])//
                return resol;
            }
            resol = resol + minV[i];

            //or do i add it after the for statement here?
        }
        
        Console.WriteLine(strs.Length);
        return resol;
        
    }
}
