#include <stdio.h>
#include <string.h>
#include <assert.h>
int lengthOfLastWord(char* s) {
    int size = strlen(s);
    int count = 0;
    int i = size-1;
    int flagNum = 0;
    for (;i>=0;i--) {
        if (s[i]==' ') {
            if (!flagNum) continue;
            else return count;
        }
        else {
            flagNum = 1;
            count++;
        }
    }
    return count;
}
int main() {
    //test here
    assert(lengthOfLastWord("Hello World") == 5);
    assert(lengthOfLastWord("   fly me   to   the moon  ") == 4);
    assert(lengthOfLastWord("luffy is still joyboy") == 6);
    assert(lengthOfLastWord("ui a") == 1);
    assert(lengthOfLastWord(" ") == 0);

    printf("AC");
    return 0;
}