public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        if (matrix.Length == 0 || matrix[0].Length == 0)
            return false;
        int end;
        int mid;
        int r = matrix.Length;
        int c = matrix[0].Length;
        for (int i = 0; i < r; i++)
        {
            if (matrix[i][0] <= target && matrix[i][c - 1] >= target)
            {
                var start = 0;
                end = c - 1;
                while (start <= end)
                {
                    mid = (start + end) / 2;
                    if (target == matrix[i][mid])
                        return true;
                    else if (target < matrix[i][mid])
                        end = mid - 1;
                    else
                        start = mid + 1;
                }
            }
        }
        return false;
    }
}