#include "pch.h"
#include <iostream>
#include<windows.h>
#include<math.h>
int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int num;
	printf("Меню:\n");
	printf("1.Радіус кола\n");
	printf("2.Діаметр кола\n");
	printf("3.Довжина кола\n");
	printf("4.Площа кола\n");
	printf("Виберіть: ");
	scanf_s("%d", &num);
	switch (num)
	{
	case 1:
		printf("\n  Радіус кола");
		double R;
		printf("\nВведіть R: "); scanf_s("%lf", &R);
		printf("R = %.2f\n", R);
		break;
	case 2:
		printf("\n  Діаметр кола\n");
		double D;
		printf("\nВведіть R: "); scanf_s("%lf", &R);
		D = 2 * R;
		printf("D = %.2f\n", D);
		break;
	case 3:
		printf("\n  Довжина кола\n");
		double L;
		printf("\nВведіть R: "); scanf_s("%lf", &R);
		L = 2 * 3.14*R;
		printf("L = %.2f\n", L);
		break;
	case 4:
		printf("\n  Площа кола\n");
		double S;
		printf("\nВведіть R: "); scanf_s("%lf", &R);
		S = 3.14*R*R;
		printf("S = %.2f\n", S);
		break;
		return 0;
	}
}