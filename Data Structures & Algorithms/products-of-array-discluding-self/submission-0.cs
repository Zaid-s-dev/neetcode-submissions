public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        List<int> result = [];
        for(int i=0; i < nums.Length; i++){
            int product = 1;
            for(int p=0; p < nums.Length; p++)
            {
                if(p!=i)
                    product *= nums[p];
            }
            result.Add(product);
        }

        return result.ToArray();
    }
}
