#include <stdio.h>
#include <stdbool.h>
#include <string.h>
bool isPalindrome(char* s) {
    int i=0, j = strlen(s)-1;
    while (i<j) {
        if (isalnum(s[i]) && isalnum(s[j])) {
            if (tolower(s[i])!=tolower(s[j])) {
                return false;
            }
            else { i++; j--; }
        } 
        else {
            if (!isalnum(s[i])) i++;
            if (!isalnum(s[j])) j--;
        }  
    }
    return true;
}

int main() {
    //test go here
    return 0;
}