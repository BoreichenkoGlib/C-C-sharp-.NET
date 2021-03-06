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
	int i, j;
	clock_t start, finish;
	for (int i = 0; i < N; i++)
	{
		a[i] = rand() % 10;
		printf("%3d", a[i]);
	}
	printf("\n");
	start = clock(); // Початок відліку часу
	int step = N / 2;
	while (step > 0)
	{
		for (int i = 0; i < (N - step); i++)
		{
			int j = i;
			while (j >= 0 && a[j] > a[j + step])
			{
				int c = a[j];
				a[j] = a[j + step];
				a[j + step] = c;
				j--;
			}
		}
		step = step / 2;
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