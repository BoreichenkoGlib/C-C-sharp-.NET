#include "pch.h"
#include <iostream>
#include<locale.h>
#include<stdio.h>
#include<Windows.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	float a, b, x, y, z;
	printf("Введіть X: "); scanf_s("%f", &x);
	printf("Введіть Y: "); scanf_s("%f", &y);
	printf("Введіть Z: "); scanf_s("%f", &z);
	a = (x + y) - 7;
	b = y + 2 * z;
	if (a < b)
	{
		printf("Min=%.1f", a - 4);
	}
	else
		if (a > b)
		{
			printf("Min=%.1f", b - 4);
		}
}