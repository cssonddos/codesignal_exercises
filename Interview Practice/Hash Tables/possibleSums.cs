int possibleSums(int[] coins, int[] quantity) {
    if (coins.Length != quantity.Length) return 0;
    HashSet<int> sums = new HashSet<int>();
    
    sums.Add(0);
    
    for (int i = 0; i < coins.Length; i++) {
        List<int> sumsNow = new List<int>(sums);
        foreach (int sum in sumsNow) {
            for (int j = 1; j <= quantity[i]; ++j) {
                sums.Add(sum + j * coins[i]);
           }
        }
    }
    
    return sums.Count - 1;
}