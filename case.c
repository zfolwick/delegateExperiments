#include <stdio.h>
#include <stdlib.h> // for malloc
#include <string.h> //for strlen
#include <ctype.h> // for toupper()
#include "case.h"

typedef struct _MI_ApplicationFT
{
    char* (*UpperCaseFirst)(char* input);
    char* (*UpperCaseLast)(char* input);
}MI_ApplicationFT;

char* UpperCaseFirst(char* input)
{
        input[0] = toupper(input[0]);
        return input;
}

char* UpperCaseLast(char* input)
{
        int last = strlen(input)-1;
        input[last] = toupper(input[last]);
        return input;
}

MI_ApplicationFT * initializeFT()
{
    MI_ApplicationFT * aft = malloc(sizeof(MI_ApplicationFT));
    aft->UpperCaseFirst = UpperCaseFirst;
    aft->UpperCaseLast = UpperCaseLast;
    return aft;
}

int main()
{
       char str[] = "seattle";
       MI_ApplicationFT * appFT = initializeFT();
       char * x = appFT->UpperCaseLast(str);
       printf("%s\n", x);
       char * y = appFT->UpperCaseFirst(str);
       printf("%s\n", y);
       return 0;
}
