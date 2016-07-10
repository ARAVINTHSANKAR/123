#include<stdio.h>
#include<conio.h>
void main()
{
int a[10];
int i,j,b;
clrscr();
printf("Enter 10 elements: ");
for(i=0;i<10;i++)
scanf("%d",&a[i]);
for(i=0;i<9;i++)
{
for(j=i+1;j<10;j++)
{
if(a[i]<a[j])
{
b=a[i];
a[i]=a[j];
a[j]=b;
}
}
}
printf("\nSorted array elements :\n");
for(i=0;i<10;i++)
printf("%d ",a[i]) ;
getch();
}
