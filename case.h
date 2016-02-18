typedef struct _MI_ApplicationFT
{
    char* (*UpperCaseFirst)(char* input);
    char* (*UpperCaseLast)(char* input);
}MI_ApplicationFT;

static char* UpperCaseFirst(char* input)
{
    printf("\n\nC:/Case/UpperCaseFirst\n\n");
    input[0] = toupper(input[0]);
    printf("\nupperCase complete...\n");
    return strdup(input);
}

static char* UpperCaseLast(char* input)
{
        int last = strlen(input)-1;
        input[last] = toupper(input[last]);
        return input;
}

extern int initializeFT(MI_ApplicationFT * aft);

