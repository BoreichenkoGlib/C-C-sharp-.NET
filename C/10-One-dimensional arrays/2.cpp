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
	int m[3] = {};
	double n[3] = {};
	int i, k;
	srand(time(NULL));
	printf("Введіть k: "); scanf_s("%d", &k);
	for (int i = 0; i < 3; i++)
	{
		printf("m[%d] = ", i);
		scanf_s("%d", &m[i]);
	}

	for (i = 0; i < k; i++)
		m[i] = -66 + rand() % 733; 
	for (i = 0; i < k; i++)
		printf("%4d", m[i]);
	printf("\n");

	for (int i = 0; i < 3; i++)
	{
		printf("n[%d] = ", i);
		scanf_s("%lf", &n[i]);
	}

	for (i = 0; i < k; i++)
		n[i] = 0.01 * (rand() % 13);
	for (i = 0; i < k; i++)
		printf(" %.2lf", n[i]);
}