#include "pch.h"
#include <iostream>
#include <Windows.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int n, i = 0, fac = 1, result = 0;
	printf("Введіть n: "); scanf_s("%d", &n);
	while (i < n)
	{
		i += 1;
		fac = i * fac;
		result = result + fac;
	}
	printf("\nresult=%d", result);
}