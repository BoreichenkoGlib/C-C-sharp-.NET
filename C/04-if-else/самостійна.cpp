#include "pch.h"
#include <iostream>
#include<locale.h>
#include<stdio.h>
#include<Windows.h>
#include<math.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	double x, y;
	printf("Введіть X: "); scanf_s("%lf", &x);
	printf("Введіть Y: "); scanf_s("%lf", &y);
	if ((x >= -4) && (x <= -1.5) && (y >= -4) && (y <= -1.5) && (x*x+y*y<=16))
	{
		printf("true", x, y);
	}
	else
		if ((x >= -3) && (x <= -1.5) && (y >= 1.5) && (y <= 3) && (x*x + y * y <= 9))
		{
			printf("true", x, y);
		}
		else
			if ((x >= 1.5) && (x <= 2) && (y >= 1.5) && (y <= 2) && (x*x + y * y <= 4))
			{
				printf("true", x, y);
			}
			else
				if ((x >= 2) && (x <= 3) && (y >= -3) && (y <= -2) && (x*x + y * y <= 9))
				{
					printf("true", x, y);
				}
				else printf("false", x, y);
	printf("\nВведіть X: "); scanf_s("%lf", &x);
	printf("\nВведіть Y: "); scanf_s("%lf", &y);
	return 0;
}
