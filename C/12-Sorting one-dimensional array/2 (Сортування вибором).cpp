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
	int i, id, j, b;
	clock_t start, finish;
	for (int i = 0; i < N; i++)
	{
		a[i] = rand() % 10;
		printf("%3d", a[i]);
	}
	printf("\n");
	start = clock(); // Початок відліку часу
	j = N - 1;
	while (j > 0) {
		id = 0;
		for (i = 1; i <= j; i++)
			if (a[i] > a[id]) id = i;
		b = a[id];
		a[id] = a[j];
		a[j] = b;
		j -= 1;
	}
	for (i = 0; i < N; i++) {
		printf("%3d", a[i]);
	}
	finish = clock(); // Кінець відліку часу
	dd = (float)(finish - start) / CLOCKS_PER_SEC;
	printf("\nЧас виконання = %f", dd);
	_getch();
}