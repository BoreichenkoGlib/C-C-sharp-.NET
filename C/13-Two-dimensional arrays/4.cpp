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
	int arr[N][N];
	int sum = 0;
	srand(time(NULL));
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++) {
			arr[i][j] = rand() % 10;
			printf("%3d ", arr[i][j]);
		}
		printf("\n");
	}
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++) {
			if ((i >= j) && (i + j + 1 >= N))
				sum += arr[i][j];
		}
	}
	printf("\nsum = %d", sum);
}