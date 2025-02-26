#include <iostream>
#include <sstream>
#include <vector>
using namespace std;
class Solution {
    public:
        int lengthOfLastWord(string s) {
            vector <string> v;
            stringstream ss(s);
            string word;
            int count = 0;
            while (ss>>word) {
                v.push_back(word);
                count++;
            }
            return v[count-1].size();
        }
};
int main() {    
    //test here
    Solution s;
    cout<<s.lengthOfLastWord(" Hello  World   ");
    return 0;
}