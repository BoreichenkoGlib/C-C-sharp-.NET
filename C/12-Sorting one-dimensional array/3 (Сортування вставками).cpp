#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
#define N 10

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int a[N] = { };
	float dd;
	double x; int i, j;
	clock_t start, finish;
	for (int i = 0; i < N; i++)
	{
		a[i] = rand() % 10;
		printf("%3d", a[i]);
	}
	printf("\n");
	start = clock(); // Початок відліку часу
	for (i = 0; i < N; i++)
	{
		x = a[i];
		for (j = i - 1; j >= 0 && a[j] > x; j--)
			a[j + 1] = a[j];
		a[j + 1] = x;
	}
	for (i = 0; i < N; i++)
	{
		printf("%3d", a[i]);
	}
	finish = clock(); // Кінець відліку часу
	dd = (float)(finish - start) / CLOCKS_PER_SEC;
	printf("\nЧас виконання = %f", dd);
	_getch();
}