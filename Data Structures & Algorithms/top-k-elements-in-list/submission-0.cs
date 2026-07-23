public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
           
        Dictionary<int,int> results = [];
        
        foreach(int number in nums)
        {
            if(!results.TryGetValue(number, out int value))
                results[number] = 1;
            else
                results[number] = value + 1;
        }

        return [.. results.OrderByDescending(x=>x.Value).Take(k).Select(x=>x.Key)];
    }
}
