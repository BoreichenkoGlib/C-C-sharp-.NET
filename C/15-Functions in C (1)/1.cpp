#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>

int per(int a, int b, int c)
{
	return a + b + c;
}

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int a, b, c;
	printf("Введіть a: "); scanf_s("%d", &a);
	printf("Введіть b: "); scanf_s("%d", &b);
	printf("Введіть c: "); scanf_s("%d", &c);
	per(a, b, c);
	printf("\nP = %d\n", per(a, b, c));
	return 0;
}