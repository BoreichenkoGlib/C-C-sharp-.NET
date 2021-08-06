#include"pch.h"
#include<iostream>
#include<windows.h>
#include<math.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int num;
	printf("Меню Лабораторна робота № 5:\n");
	printf("1.Завдання № 1\n");
	printf("2.Завдання № 2\n");
	printf("Виберіть: ");
	scanf_s("%d", &num);
	switch (num)
	{
	case 1:
		printf("\nЛабораторна робота Завдання № 1\n");
		int x;
		printf("\nВведіть число букви: ");
		scanf_s("%d", &x);
		switch (x)
		{
		case 1: printf("Антилопа\n");
			break;
		case 2: printf("Буквар\n");
			break;
		case 3: printf("Воля\n");
			break;
		case 4: printf("Грамота\n");
			break;
		case 5: printf("Дятел\n");
			break;
		case 6: printf("Електрика\n");
			break;
		case 7: printf("Єнот\n");
			break;
		case 8: printf("Жолудь\n");
			break;
		case 9: printf("Зебра\n");
			break;
		case 10: printf("Ігор\n");
			break;
		case 11: printf("Їжак\n");
			break;
		case 12: printf("Йогурт\n");
			break;
		case 13: printf("Київ\n");
			break;
		case 14: printf("Львів\n");
			break;
		case 15: printf("Майонез\n");
			break;
		case 16: printf("Надія\n");
			break;
		case 17: printf("Олег\n");
			break;
		case 18: printf("Партизан\n");
			break;
		case 19: printf("Русизм\n");
			break;
		case 20: printf("Севастополь\n");
			break;
		case 21: printf("Таврія\n");
			break;
		case 22: printf("Уляна\n");
			break;
		case 23: printf("Фонтан\n");
			break;
		case 24: printf("Хвоя\n");
			break;
		case 25: printf("Цукор\n");
			break;
		case 26: printf("Чаша\n");
			break;
		case 27: printf("Шолом\n");
			break;
		case 28: printf("Щастя\n");
			break;
		case 29: printf("Юля\n");
			break;
		case 30: printf("Язва\n");
			break;
		default: printf("Помилка");
		}
		break;
	case 2:
		printf("\nЛабораторна робота Завдання № 2\n");
		int num;
		printf("1.sin(x)\n");
		printf("2.x*x\n");
		printf("3.exp(x)\n");
		printf("Виберіть: ");
		scanf_s("%d", &num);
		switch (num)
		{
		case 1:
			printf("\nsin(x)\n");
			double x, y, a;
			printf("\nВведіть x: "); scanf_s("%lf", &x);
			printf("\nВведіть y: "); scanf_s("%lf", &y);
			if (x - y == 0)
			{
				a = sin(x)*sin(x) + pow(x, 1 / 3) + sin(y);
				printf("\n   a=%.f\n", a);
			}
			else
				if (x - y > 0)
				{
					a = sin(x)*sin(x) - 2 * sin(x)*y + y * y + log(x);
					printf("\n   a=%.f\n", a);
				}
				else
					if (x - y < 0)
					{
						a = y * y - 2 * y*sin(x) + sin(x)*sin(x) + tan(y);
						printf("\n   a=%.f\n", a);
					}
		case 2:
			printf("\nx*x\n");
			printf("\nВведіть x: "); scanf_s("%lf", &x);
			printf("\nВведіть y: "); scanf_s("%lf", &y);
			if (x - y == 0)
			{
				a = pow(x, 2)*pow(x, 2) + pow(x, 1 / 3) + sin(y);
				printf("\n   a=%.f\n", a);
			}
			else
				if (x - y > 0)
				{
					a = pow(x, 2)*pow(x, 2) - 2 * pow(x, 2)*y + y * y + log(x);
					printf("\n   a=%.f\n", a);
				}
				else
					if (x - y < 0)
					{
						a = y * y - 2 * y*pow(x, 2) + pow(x, 2)*pow(x, 2) + tan(y);
						printf("\n   a=%.f\n", a);
					}
		case 3:
			printf("\nexp(x)\n");
			printf("\nВведіть x: "); scanf_s("%lf", &x);
			printf("\nВведіть y: "); scanf_s("%lf", &y);
			if (x - y == 0)
			{
				a = exp(x)*exp(x) + pow(x, 1 / 3) + sin(y);
				printf("\   na=%.f\n", a);
			}
			else
				if (x - y > 0)
				{
					a = exp(x)*exp(x) - 2 * exp(x)*y + y * y + log(x);
					printf("\n   a=%.f\n", a);
				}
				else
					if (x - y < 0)
					{
						a = y * y - 2 * y*exp(x) + exp(x)*exp(x) + tan(y);
						printf("\n   a=%.f\n", a);
					}
		}
		break;
	}
	return 0;
}