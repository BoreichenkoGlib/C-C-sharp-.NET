#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<conio.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int i;
	for (i = 1; i <= 5; i++)
		printf("%d", i);
	printf("\n");
	for (i = 3; i <= 7; i++)
		printf("%d", i);
	printf("\n");
	for (i = 5; i <= 9; i++)
		printf("%d", i);
	printf("\n");
	for (i = 7; i <= 11; i++)
		printf("%d", i);
	printf("\n");
	_getch();
}