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
	int i, j, temp;
	int arr[N][N];
	for (i = 0; i < N; i++)
	{
		for (j = 0; j < N; j++) {
			arr[i][j] = rand() % 10;
			printf("%d ", arr[i][j]);
		}
		printf("\n");
	}
	printf("\n");
	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < N; j++)
		{
			for (int k = i; k < N; k++)
			{
				if (j % 2 != 0)
				{
					if (arr[i][j] < arr[k][j])
					{
						temp = arr[i][j];
						arr[i][j] = arr[k][j];
						arr[k][j] = temp;
					}
				}
			}
			printf("%d ", arr[i][j]);
		}
		printf("\n");
	}
}