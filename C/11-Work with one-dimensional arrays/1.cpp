#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int a[] = { 0, 0, -3, -4, -3, 0, 3, 2, 0, 3, 2, 0, 0 };
	int counter = 0;
	double diff;
	int N = sizeof(a) / sizeof(a[0]);
	printf("\nРозмір масиву = %d\n", N);
	for (int i = 0; i < N; i++)
		printf(" %d", a[i]);
	for (int i = 0; i < N - 1; i++)
	{
		diff = a[i + 1] - a[i];
		if (diff < 0)
		{
			counter++;
			while (diff < 0 && i < N - 1)
			{
				i++;
				diff = a[i + 1] - a[i];
			}
		}
	}
	printf("\nКількість ділянок = %d", counter);
	_getch();
}