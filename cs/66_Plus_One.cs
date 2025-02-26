public class Solution {
    public int[] PlusOne(int[] digits) {
        digits[digits.Length-1]++;
        for (int i = digits.Length-1;i>0;i--) {
            if (digits[i] == 10) {
                digits[i] = 0;
                digits[i-1]++;
            }
            else break;
        }
        if(digits[0]==10) {
            int[] digit = new int[digits.Length+1];
            for (int i=digit.Length-1;i>0;i--) {
                digit[i] = digits[i-1];
            }
            digit[1] = 0;
            digit[0] = 1;
            return digit;
        }
        return digits;
    }
}
class Program {
    static void Main (string[] args) {
        //test here
        int [] a = new int [4] {9,9,9,9};
        a = Solution.PlusOne(a);
        foreach (int i in a) Console.Write($"{i} ");
    }
}