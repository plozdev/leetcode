#include <iostream>
#include <string>
#include <algorithm>
using namespace std;
class Solution {
    public:
        bool isPalindrome(string s) {
            string ans;
            for (int i=0;i<s.size();++i) {
                if (isalpha(s[i])) {
                    ans += tolower(s[i]);
                }
                else if (isdigit(s[i])) ans+=s[i];
            }
            string check = ans;
            reverse(ans.begin(),ans.end());
            return ans==check;
        }
};

int main() {
    //test go here
    return 0;
}