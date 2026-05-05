public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if (strs == null || strs.Length == 0) 
            return new List<List<string>>(); 

        var map = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }
            
            map[key].Add(s);
        }
        
        return map.Values.ToList();
    }
}