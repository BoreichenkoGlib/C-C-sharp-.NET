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
	int E[N], sum = 0, i = 0;
	for (int i = 0; i < 10; i++)
	{
		printf("E[%d] = ", i);
		scanf_s("%d", &E[i]);
	}
	for (int i = 0; i < N; i++)
	{
		if (E[i] % 2)
			sum = sum + E[i];
	}
	printf("\nsum = %d", sum);
}