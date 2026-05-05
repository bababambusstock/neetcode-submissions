public class Solution
{
  public bool IsAnagram(string s, string t)
  {
    if (s.Length != t.Length) return false;

    var dictionary = new Dictionary<char, int>();

    foreach (char c in s)
    {
      if (dictionary.ContainsKey(c))
      {
        dictionary[c]++;
      }
      else
      {
        dictionary[c] = 1;
      }
    }
    foreach (char c in t )
    {
      if (!dictionary.ContainsKey(c) || dictionary[c] == 0)
      {
        return false;
      }
       else 
      {
        dictionary[c]--;
      }
    }
    return true;
  }
}
