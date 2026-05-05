public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var frequencies = new Dictionary<int, int>();
        
        foreach (int num in nums) {
            if (!frequencies.ContainsKey(num)) {
                frequencies[num] = 0;
            }
            frequencies[num]++;
        }

        return frequencies
            .OrderByDescending(pair => pair.Value)
            .Select(pair => pair.Key)
            .Take(k)
            .ToArray();
    }
}