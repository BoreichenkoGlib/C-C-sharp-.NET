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
	double a, b, x, y, z, u, min, max;
	printf("Введіть X: "); scanf_s("%lf", &x);
	printf("Введіть Y: "); scanf_s("%lf", &y);
	printf("Введіть Z: "); scanf_s("%lf", &z);
	if (x > y && x > z)
	{
		max = x;
		printf("max=%.1f", x);
	}
	else
		if (y > x && y > z)
		{
			max = y;
			printf("max=%.1f", y);
		}
		else
			if (z > x && z > y)
			{
				max = z;
				printf("max=%.1f", z);
			}
	if (x < y && x < z)
	{
		min = x;
		printf("\nmin=%.1f", x);
	}
	else
		if (y < x && y < z)
		{
			min = y;
			printf("\nmin=%.1f", y);
		}
		else
			if (z < x && z < y)
			{
				min = z;
				printf("\nmin=%.1f", z);
			}
	a = max - pow(2, x)*min*min;
	b = sin(2 * x) + max * min*min;
	u = a / b;
	printf("\nu=%f", u);
	return 0;
}


	

		
	