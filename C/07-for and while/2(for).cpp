#include "pch.h"
#include <iostream>
#include <Windows.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int n, i, result = 0, fac = 1;
	printf("Введіть n: "); scanf_s("%d", &n);
	for (i = 1; i <= n; i++)
		if (i <= n)
		{
			fac = fac * i;
			result = result + fac;
		}
	printf("\nresult=%d", result);
}