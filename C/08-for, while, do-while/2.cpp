#include "pch.h"
#include <iostream>
#include <Windows.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int n, Count, num;
	printf("\nОбчислення одиниць натурального числа:\n");
	printf("\nВведіть числа, 0 завершує програму:\n");
	do {
		printf("\nВведіть n: ");
		scanf_s("%d", &n);
		Count = (n % 10);
		printf("Count = %d", Count);
		printf("\nМЕНЮ");
		printf("\n1 - Продовжити роботу");
		printf("\n2 - Завершити роботу");
		printf("\nВведіть: ");
		scanf_s("%d", &num);
		if (num == 2)
		{
			n = 0;
		}
	} while (n != 0);
}