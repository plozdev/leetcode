public class Solution {
     public int MaxProfit(int[] prices) {
        int buy = prices[0];
        int current = 0;
        for (int i=1;i<prices.Length;i++) {
            buy = Math.Min(prices[i],buy);
            current = Math.Max(prices[i] - buy,current);
        }
        return current;
    }
}

class Program {
    static void Main (string[] args) {
        //test here
        Solution s = new Solution();
        int[] a = new int[3] {1,3,0}; //output = 2
        Console.WriteLine(s.MaxProfit(a));
        a = new int [6]{10,1,6,7,4,0}; //output = 6
        Console.WriteLine(s.MaxProfit(a));
    }
}