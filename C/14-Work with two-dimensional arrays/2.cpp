#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
#define A 5
#define B 6

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	srand(time(NULL));
	int counter = 0;
	int arr[A][B];
	for (int i = 0; i < A; i++) {
		for (int j = 0; j < B; j++) {
			arr[i][j] = rand() % 10;
			printf("%d ", arr[i][j]);
		}
		printf("\n");
	}
	for (int j = 0; j < B; j++)
		for (int i = 0; i < A; i++)
		{
			if (arr[i][j] == 0)
			{
				counter++;
				break;
			}
		}
	printf("\nCounter = %d", counter);
	_getch();
}