public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList <int> ints = new List<int>();
        IList<IList<int>> ans = new List<IList<int>>();
        // ints.Add(1);
        for (int i=1;i<=numRows;i++) {
            ints = RegenerateList(ints,i);
            ans.Add(ints);
        }

        return ans;
                
    }
    private IList<int> RegenerateList( IList<int> list, int size) {
        if (size==1) return new List<int>(){1};
        else if (size==2) return new List<int>() {1,1};
        IList<int> news = new List<int>();
        news.Add(list.First());
        for (int i=0;i<list.Count-1;i++) {
            news.Add(list[i] + list[i+1]);
        }
        news.Add(list.Last());
        return news;
    }
}

class Program {
    static void Main (string[] args) {
        IList<IList<int>> ok = Solution.Generate(5); //number test here
        foreach (IList<int> test in ok ) {
            foreach(int i in test) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}