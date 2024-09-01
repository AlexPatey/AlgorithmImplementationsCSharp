namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class PascalsTriangle_118
{
    public static IList<IList<int>> Generate(int numRows)
    {
        if (numRows < 2)
        {
            return [new List<int> { 1 }];
        }
        
        IList<IList<int>> pascalsTriangle = [new List<int> { 1 }, new List<int> { 1, 1 }];

        var i = 2;

        while (i < numRows)
        {
            var j = 0;
            pascalsTriangle.Add(new List<int>());
            while (j <= i)
            {
                if (j == 0 || j == i)
                {
                    pascalsTriangle[i].Add(1);
                }
                else
                {
                    var result = pascalsTriangle[i -1][j - 1] + pascalsTriangle[i - 1][j];
                    pascalsTriangle[i].Add(result);
                }
                
                j++;
            }
            i++;
        }

        return pascalsTriangle;
    } 
}