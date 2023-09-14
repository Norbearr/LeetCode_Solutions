public class Solution 
{
    public bool SearchMatrix(int[][] matrix, int target) 
    {  
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix[row].Length; column++)
            {
                if(matrix[row][column] == target)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
