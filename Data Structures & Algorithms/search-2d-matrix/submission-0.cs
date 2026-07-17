public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int left = 0, right = matrix.Length-1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if  (target < matrix[mid][0])
            {

                right = mid -1;

            } else if (target > matrix[mid][matrix[mid].Length-1])
            {
                left = mid + 1;
            }
            else
            {
                int low = 0, high = matrix[mid].Length-1;
                 while (low <= high)
                {
                    int mid2 =  low + (high - low) / 2;

                    if (matrix[mid][mid2] == target)
                        return true;
                    else if (matrix[mid][mid2] <  target)
                    {
                        low = mid2 + 1;
                    }
                    else
                    {
                        high = mid2 - 1;
                    }
                }
                return false;
            }
        }
        return false;
    }
}
