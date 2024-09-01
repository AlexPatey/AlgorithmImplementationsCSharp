namespace AlgorithmImplementationsCSharp.LeetCodeSolutions;

public static class PascalsTriangleII_119
{
    public static IList<int> GetRow(int rowIndex)
    {
        switch (rowIndex)
        {
            case < 1:
                return new List<int> { 1 };
            case 1:
                return new List<int> { 1, 1 };
        }

        IList<IList<int>> pascalsTriangle = [new List<int> { 1 }, new List<int> { 1, 1 }];

        var i = 2;

        while (i <= rowIndex)
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

            if (i == rowIndex)
            {
                return pascalsTriangle[rowIndex];
            }
            i++;
        }
        
        return pascalsTriangle[rowIndex];
    }
}