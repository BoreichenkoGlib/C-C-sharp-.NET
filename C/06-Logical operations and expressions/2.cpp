#include "pch.h"
#include <iostream>
#include <Windows.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int x, y;
	printf("Введіть кількість голів команди Динамо: "); scanf_s("%d", &x);
	printf("Введіть кількість голів команди Шахтар: "); scanf_s("%d", &y);
	x > y ? printf("\nПеремога Динамо") :
		x < y ? printf("\nПеремога Шахтаря") :
		printf("\nНічия");
}

