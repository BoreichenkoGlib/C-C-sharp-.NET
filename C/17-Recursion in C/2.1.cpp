#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
#define N 4

int func(int arr[], int x)
{
	int P;
	int sum = 0;
	for (int i = 1; i < N; i++)
	{
		sum += arr[i] * pow(x, i);
	}
	P = arr[0] + sum;
	return P;
}

int main()
{
	int arr[N], result, x;
	srand(time(NULL));
	printf("\nX = "); scanf_s("%d", &x); // ввожу значення х
	printf("\narr = [");
	for (int i = 0; i < N; i++) { // формую довільний масив
		arr[i] = rand() % 10;
		printf("%2d", arr[i]);
	}
	printf("]");
	result = func(arr, x);
	printf("\nP = %d\n", result); // вивожу значення поліному
	return 0;
}