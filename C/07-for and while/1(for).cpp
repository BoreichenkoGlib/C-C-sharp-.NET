#include "pch.h"
#include <iostream>
#include <Windows.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int A, B, i, summa = 0;
	printf("Введіть A: "); scanf_s("%d", &A);
	printf("Введіть B: "); scanf_s("%d", &B);
	for (i = A; i <= B; i++)
		summa=summa+i;
	printf("\nsumma=%d", summa);
    return 0;
}

