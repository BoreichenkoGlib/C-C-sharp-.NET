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
	srand((unsigned int)time(NULL));
	setlocale(LC_ALL, "Russian");
	int i, j;
	int A[4][4];
	for (i = 0; i < 4; i++)
	{
		for (j = 0; j < 4; j++)
		{
			A[i][j] = rand() % 1000000;
			if (A[i][j] < A[i][j - 1])
			{
				A[i][j] = A[i][j] + A[i][j - 1];
				A[i][j - 1] = A[i][j - 1] - A[i][j];
				A[i][j - 1] = A[i][j - 1] - A[i][j];
			}
			printf("%8d ", A[i][j]);
		}
		printf("\n");
	}
}