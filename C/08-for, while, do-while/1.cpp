#include "pch.h"
#include <iostream>
#include <Windows.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int num;
	double value, posCount = 0, negCount = 0, min = 1e7;
	printf("\nОбчислення мінімального числа серед позитивно введених:\n");
	printf("\nВведіть числа, 0 завершує програму:\n");
	printf("\nМеню");
	printf("\n1 - Продовжити роботу");
	printf("\n2 - Закінчити роботу ");
	scanf_s("%d", &num);
	switch (num)
	{
	case 1:
		do {
			scanf_s("%lf", &value);
			if (value < 0) negCount++;
			if (value > 0) posCount++;
			if (posCount < min) min = posCount;
		} while (value != 0);
		printf("min = %.f", min);
	case 2:
		break;
	}
}