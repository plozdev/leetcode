#include<stdio.h>
#include <stdlib.h>
#include <assert.h>
/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* plusOne(int* digits, int digitsSize, int* returnSize) {
	if (digits == NULL || digitsSize <= 0) {
        *returnSize = 0;
        return NULL;
    }
	digits[digitsSize-1]++;
    int i; 
    for (i=digitsSize-1;i>0;i--) {
    	if (digits[i]==10) {
    		digits[i] = 0;
    		digits[i-1]++;
		}
		else break;
	}
	if (digits[0]==10) {
		*returnSize = digitsSize+1;
		int *new_arr = (int *) malloc(*returnSize * sizeof(int));
		for (i=digitsSize;i>=2;i--) new_arr[i] = digits[i-1];
		new_arr[0] = 1; new_arr[1] = 0;
		return new_arr;
    }
    *returnSize = digitsSize;
    return digits;
}

void testPlusOne(int* digits, int digitsSize, int* expected, int expectedSize) {
    int returnSize;
    int* result = plusOne(digits, digitsSize, &returnSize);

    assert(returnSize == expectedSize);

    for (int i = 0; i < returnSize; i++) {
        assert(result[i] == expected[i]);
    }

    if (result != digits) {
        free(result);
    }
}
int main()
{	
    //test here
	int digits1[] = {1, 2, 3};
    int expected1[] = {1, 2, 4};
    testPlusOne(digits1, 3, expected1, 3);

    int digits2[] = {4, 3, 2, 1};
    int expected2[] = {4, 3, 2, 2};
    testPlusOne(digits2, 4, expected2, 4);

    int digits3[] = {9};
    int expected3[] = {1, 0};
    testPlusOne(digits3, 1, expected3, 2);

    int digits4[] = {9, 9, 9};
    int expected4[] = {1, 0, 0, 0};
    testPlusOne(digits4, 3, expected4, 4);
    
    printf("AC");
	return 0;
	
}