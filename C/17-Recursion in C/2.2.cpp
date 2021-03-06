#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
#define K 4

int func(int*arr, int n, int x, int i)
{
	if (n == 0)
		return 0;
	else
		return *arr * pow(x, i) + func(arr + 1, n - 1, x, i + 1);
}

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int arr[K], x, P;
	srand(time(NULL));
	printf("X = "); scanf_s("%d", &x);
	for (int i = 0; i < K; i++) {
		arr[i] = rand() % 10;
		printf("%3d", arr[i]);
	}
	P = func(arr, 4, x, 1);
	printf("\nresult = %d", P/2);
}