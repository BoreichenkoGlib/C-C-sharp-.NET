#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
#define N 20
#define M 20

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int a, b, n, m, k = -1, sum;
	int arr[N][M] = { };
	int ar[N] = { };
	srand(time(NULL));
	printf("Введіть n: "); scanf_s("%d", &n);
	printf("Введіть m: "); scanf_s("%d", &m);
	printf("Введіть a: "); scanf_s("%d", &a);
	printf("Введіть b: "); scanf_s("%d", &b);
	for (int i = 0; i < n; i++) {
		sum = 0;
		for (int j = 0; j < m; j++) {
			arr[i][j] = a + rand() % (b - a + 1);
			printf("%3d ", arr[i][j]);
			sum += arr[i][j];
			ar[i] = sum;
		}
		printf("|sum = %d\n", sum);
	}
	printf("\nСума рядків\n");
	for (int i=0; i<n; i++)
		printf("%3d ", ar[i]);
}