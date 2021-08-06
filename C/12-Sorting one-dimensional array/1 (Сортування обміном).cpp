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
	int i, j, b;
	clock_t start, finish;
	for (int i = 0; i < N; i++)
	{
		a[i] = rand() % 10;
		printf("%3d", a[i]);
	}
	printf("\n");
	start = clock();
	for (i = 0; i < N - 1; i++)
	{
		for (j = 0; j < N - i - 1; j++)
		{
			if (a[j] > a[j + 1])
			{
				b = a[j];
				a[j] = a[j + 1];
				a[j + 1] = b;
			}
		}
	}
	for (i = 0; i < N; i++)
		printf("%3d", a[i]);
	finish = clock();
	dd = (float)(finish - start) / CLOCKS_PER_SEC;
	printf("\nЧас виконання = %f", dd);
	_getch();
}