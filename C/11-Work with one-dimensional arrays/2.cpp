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
	srand(time(NULL));
	int A[N] = { };
	int B[N] = { };
	int sum = 0;
	printf("\nA[] = ");
	for (int i = 0; i < N; i++)
	{
		A[i] = rand() % 16;
		printf("%4d", A[i]);
	}
	printf("\nB[] = ");
	for (int i = 0; i < N; i++)
	{
		sum = sum + A[i];
		B[i] = B[i] + sum;
		printf("%4d", B[i]);
	}
	_getch();
}