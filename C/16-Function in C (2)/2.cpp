#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
#define N 10

int func(int a[N])
{
	int i, j, b, counter = 0;
	printf("\n");
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
	for (i = 0; i < N; i++) {
		if (a[i] == a[i + 1])
		{
			counter++;
		}
	}
	return counter;
}

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	srand(time(NULL));
	int a[N];
	for (int i = 0; i < N; i++) {
		a[i] = rand() % 10;
		printf("%3d", a[i]);
	}
	if (func(a) > 2)
		printf("\nІстина");
	else printf("\nБрехня");
	return 0;
}