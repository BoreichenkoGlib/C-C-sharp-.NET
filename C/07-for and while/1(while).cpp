#include "pch.h"
#include <iostream>
#include <Windows.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int A, B, summa=0;
	printf("Введіть A: "); scanf_s("%d", &A);
	printf("Введіть B: "); scanf_s("%d", &B);
	while (A <= B)
	{
		summa = summa + A;
		A = A + 1;
	}
	printf("Summa = %d\n", summa);
	return 0;
}

