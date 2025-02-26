public class Solution {
    
    public IList<int> GetRow(int rowIndex) {
        IList<int> list = new List<int>() {1};
        for (int i=1;i<=rowIndex;i++) {
            list.Add(1);
            for (int j=i-1;j>0;j--) {
                list[j] = list[j] + list[j-1];
            }
        }
        return list;
    }
}

class Program {
    static void main(string []args) {
        //test here
        Solution solution = new Solution();
        Console.WriteLine(solution.GetRow(3));
        Console.WriteLine(solution.GetRow(5));

    }
}