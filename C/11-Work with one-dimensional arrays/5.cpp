#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
#define N 20

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int a[N], b[N], j, f, i;
	srand(time(NULL));
	for (i = 0; i < N; i++)
	{
		a[i] = rand() % 15;
		printf("%d ", a[i]);
	}
	printf("\n");
	for (i = 0; i < N; i++)
	{
		f = 1;
		for (j = 0; j < N; j++)
			if (a[i] == a[j] && i != j)
			{
				f = 0;
				break;
			}
		if (f == 1) printf("%d ", a[i]);
	}
	printf("\n");
}