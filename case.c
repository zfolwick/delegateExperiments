#include <stdio.h>
#include <stdlib.h> // for malloc
#include <string.h> //for strlen
#include <ctype.h> // for toupper()
#include "case.h"



int initializeFT(MI_ApplicationFT* aft)
{
    aft->UpperCaseFirst = UpperCaseFirst;
    aft->UpperCaseLast = UpperCaseLast;
    return 0;
}

int main()
{
       char str[] = "msft";

       MI_ApplicationFT appFT;
       initializeFT(&appFT);

       char * x = appFT.UpperCaseLast(str);
       printf("%s\n", x);

       char * y = appFT.UpperCaseFirst(str);
       printf("%s\n", y);
       return 0;
}
