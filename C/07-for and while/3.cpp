#include "pch.h"
#include <iostream>
#include <Windows.h>
#include <math.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int num;
	printf("Завдання №3");
	printf("\n1.Функція 1.(while)");
	printf("\n2.Функція 1.(for)");
	printf("\n3.Функція 2(while)");
	printf("\n4.Функція 2(for)");
	printf("\nВиберіть: ");
	scanf_s("%d", &num);
	switch (num)
	{
	case 1:
		float a, b, y, h;
		printf("Введіть a: "); scanf_s("%f", &a);
		printf("Введіть b: "); scanf_s("%f", &b);
		printf("Введіть h: "); scanf_s("%f", &h);
		while (a <= b)
		{
			y = sin(a)*cos(a*a);
			printf("%5.2f -> %5.2f\n", a, y);
			a += h;
		}
		break;
	case 2:
		printf("Введіть a: "); scanf_s("%f", &a);
		printf("Введіть b: "); scanf_s("%f", &b);
		printf("Введіть h: "); scanf_s("%f", &h);
		for (a; a <= b; a += h)
			if (a <= b)
			{
				y = sin(a)*cos(a*a);
				printf("%5.2f -> %5.2f\n", a, y);
			}
		break;
	case 3:
		printf("Введіть a: "); scanf_s("%f", &a);
		printf("Введіть b: "); scanf_s("%f", &b);
		printf("Введіть h: "); scanf_s("%f", &h);
		while (a <= b)
		{
			y = pow(a, 1 / 4);
			printf("%5.2f -> %5.2f\n", a, y);
			a += h;
		}
		break;
	case 4:
		printf("Введіть a: "); scanf_s("%f", &a);
		printf("Введіть b: "); scanf_s("%f", &b);
		printf("Введіть h: "); scanf_s("%f", &h);
		for (a; a <= b; a += h)
			if (a <= b)
			{
				y = pow(a, 1 / 4);
				printf("%5.2f -> %5.2f\n", a, y);
			}
		break;
	}

	return 0;
}