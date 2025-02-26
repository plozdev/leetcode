using System.Text;

public class Solution {
    private bool[] list = new bool[10];
    public bool IsValidSudoku(char[][] board) {
        return checkRow(board) && checkCol(board) && check3x3(board);
    }
    private bool check3x3(char [][] board) {
        for (int l=0;l<9;l+=3) {
            for (int k=0;k<9;k+=3) {
                reset();
                for (int i=l;i<l+3;i++) {
                    for (int j=k;j<k+3;j++) {
                        if (isNum(board[i][j])) {
                            int index = board[i][j] - '0';
                            if (list[index]) return false;
                            else list[index]  = true;
                        }
                    }
                }
            }
        }
        return true;
    }
    private bool checkRow(char [][] board) {
        for (int i=0;i<board.Length;i++) {
            reset();
            for (int j=0;j<board[i].Length;j++) {
                if (isNum(board[i][j])) {
                    int index = board[i][j] - '0';
                    if (list[index]) return false;
                    else list[index] = true;
                }
            }
        }
        return true;
    }
    private bool checkCol(char [][] board) {
        for (int i=0;i<board.Length;i++) {
            reset();
            for (int j=0;j<board[i].Length;j++) {
                if (isNum(board[j][i])) {
                    int index = board[j][i] - '0';
                    if (list[index]) return false;
                    else list[index] = true;
                }
            }
        }
        return true;
    }
    private void reset () {
        for (int i=0;i<list.Length;i++) list[i] = false;
    }
    private bool isNum(char c) {
        return c>='0' && c<='9';
    }
}
class Program {
    static void Main (string[] args) {
        //test here
        Solution s = new Solution();
        char[][] c = new char[9][]
        {
            new char[] {'.', '.', '.', '.', '5', '.', '.', '1', '.'},
            new char[] {'.', '4', '.', '3', '.', '.', '.', '.', '.'},
            new char[] {'.', '.', '.', '.', '.', '3', '.', '.', '1'},
            new char[] {'8', '.', '.', '.', '.', '.', '.', '2', '.'},
            new char[] {'.', '.', '2', '.', '7', '.', '.', '.', '.'},
            new char[] {'.', '1', '5', '.', '.', '.', '.', '.', '.'},
            new char[] {'.', '.', '.', '.', '.', '2', '.', '.', '.'},
            new char[] {'.', '2', '.', '9', '.', '.', '.', '.', '.'},
            new char[] {'.', '.', '4', '.', '.', '.', '.', '.', '.'}
        };
        Console.Write(s.IsValidSudoku(c));
    }
}