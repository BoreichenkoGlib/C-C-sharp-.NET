#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
#define N 10

void main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int a[N] = {0, 2, 34,  -4, 15, 46, 67, 38, 79, 10 };
	int k, j = 0;
	printf("Введіть k: "); scanf_s("%d", &k);
	for (int i = 0; i < N; i++)
	{
		printf(" %d", a[i]);
	}
	printf("\n");
	for (int i = 0; i < N - k; i++)
	{
		a[i] = a[k + j];
		printf(" %d", a[i]);
		j++;
	}
}