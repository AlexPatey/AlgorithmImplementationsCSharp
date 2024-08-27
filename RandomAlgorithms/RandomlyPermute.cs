namespace AlgorithmImplementationsCSharp.RandomAlgorithms;

public static class RandomlyPermute
{
    public static void Permute(int[] A)
    {
        var random = new Random();
        
        for (var i = 0; i < A.Length; i++)
        {
            var randomNumber = random.Next(0, A.Length);
            (A[randomNumber], A[i]) = (A[i], A[randomNumber]);
        }
    }
}