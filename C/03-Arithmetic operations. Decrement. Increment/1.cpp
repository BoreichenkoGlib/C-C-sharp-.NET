#include "pch.h"
#include <iostream>
#include<Windows.h>
#include<stdio.h>

int main()
{
	int x,y;
	printf("Vvedite x: "); scanf_s("%d", &x);
	printf("Vvedite y: "); scanf_s("%d", &y);
	printf("|%7d%d    |", x,y);
	printf("\n|%-d%7d    |", x, y);
	printf("\n|%-d%7d    |", x, y);
	printf("\n|%-d%11d|", x, y);
	return 0;
}

