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
	int a[N] = {10, 1, 2, 3, 4, 5, 6, 7, 8, 9};
	int i, j, v;
	for (int i = 0; i < N; i++)
		printf(" %d ", a[i]);
	printf("\n");
	for (i = 1; i < N; i++)
	{
		if (a[i] < a[i - 1])
		{
			v = a[i];
			j = i - 1;
			while ((j >= 0) && (a[j] > v)) a[j + 1] = a[j--];
			a[j + 1] = v;
		}
	}
	for (int i = 0; i < N; i++)
		printf(" %d ", a[i]);
}