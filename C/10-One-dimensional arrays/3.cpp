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
	int arr[N], i, mx, a, b, zero = 0, dob = 1;
	srand(time(NULL));
	mx = 0;
	printf("Введіть a: "); scanf_s("%d", &a);
	printf("Введіть b: "); scanf_s("%d", &b);
	for (i = 0; i < N; i++)
	{
		arr[i] = a + rand() % (b - a + 1);
		printf(" %d ", arr[i]);
		if (arr[i] > arr[mx])
			mx = i;
	}
	printf("\narr[%d] = %d\n", mx, arr[mx]);
	for (i = 0; i < N; i++)
	{
		arr[i] = a + rand() % (b - a + 1);
		printf(" %d ", arr[i]);
		if (arr[i] == 0)
		{
			zero += 1;
		}

	}
	for (i = 0; i < N; i++)
		if (arr[i] == 0)
			break;
	for (++i; i < N; i++)
	{
		if (arr[i] == 0)
			break;
		dob *= arr[i];
	}
	printf("\nРівних нулю: %d", zero);
	printf("\nДобуток: %d", dob);
}