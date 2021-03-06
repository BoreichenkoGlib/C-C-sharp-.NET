#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
#define N 5

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	srand(time(NULL));
	int a, b;
	long int arr[N][N];
	for (int i = N - 1; i >= 0; i--) {
		for (int j = N - 1; j >= 0; j--) {
			arr[i][j] = 1000000 + rand() % 1000000;
			printf("%d ", arr[i][j]);
		}
		printf("\n");
	}
	printf("\n");
	for (int i = N - 1; i >= 0; i--) // проводжу сортування масиву по рядках
	{
		for (int j = N - 1; j >= 0; j--)
		{
			for (int k = j; k >= 0; k--)
			{
				if (arr[i][j] < arr[i][k])
				{
					a = arr[i][j];
					arr[i][j] = arr[i][k];
					arr[i][k] = a;
				}
			}
		}
	}
	for (int i = N - 1; i >= 0; i--) // проводжу сортування по стовпчиках
	{
		for (int j = N - 1; j >= 0; j--)
		{
			for (int p = i; p >= 0; p--)
			{
				if (arr[i][j] < arr[p][j])
				{
					b = arr[i][j];
					arr[i][j] = arr[p][j];
					arr[p][j] = b;
				}
			}
		}
	}
	for (int i = N - 1; i >= 0; i--) {  // вивожу масив
		for (int j = N - 1; j >= 0; j--) {
			printf("%d ", arr[i][j]);
		}
		printf("\n");
	}
}