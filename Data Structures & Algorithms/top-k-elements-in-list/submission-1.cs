public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        var freq = new Dictionary<int, int>(nums.Length); 
        foreach (int n in nums) {
            ref int count = ref System.Runtime.InteropServices.CollectionsMarshal.GetValueRefOrAddDefault(freq, n, out _);
            count++;
        }

        var buckets = new List<int>[nums.Length + 1];
        foreach (var kvp in freq) {
            int f = kvp.Value;
            (buckets[f] ??= new List<int>()).Add(kvp.Key);
        }

        var result = new int[k];
        int idx = 0;
        for (int i = nums.Length; i >= 0 && idx < k; i--) {
            if (buckets[i] is not null) {
                foreach (int num in buckets[i]) {
                    result[idx++] = num;
                    if (idx == k) break;
                }
            }
        }

        return result;
    }
}