public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] ans = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int currentProduct = 1;

            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j)
                {
                    currentProduct = currentProduct * nums[j];
                } 
            }  
            ans[i] = currentProduct;
        }

        return ans;
    }
}