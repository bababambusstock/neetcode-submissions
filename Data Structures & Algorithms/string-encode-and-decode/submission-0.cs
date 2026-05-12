public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        
        foreach (string s in strs) {
            sb.Append(s.Length);
            sb.Append('#');
            sb.Append(s);
        }
        
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        
        while (i < s.Length) {
            int hashIndex = s.IndexOf('#', i);
            
            int length = int.Parse(s.Substring(i, hashIndex - i));
            
            string str = s.Substring(hashIndex + 1, length);
            result.Add(str);
            
            i = hashIndex + 1 + length;
        }
        
        return result;
    }
}