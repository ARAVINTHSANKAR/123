#include <stdio.h>
#include<string.h>
int main(void) {
char a[100];
int i;
for(i=0;i<20;i++)
{
scanf("%c",&a[i]);
}
for(i=0;i<7;i++)
{
    if((a[i]>='a'&&a[i]<='z')||(a[i]>='A'&&a[i]<='Z'))
        printf("%c",a[i]);
}
	return 0;
}

