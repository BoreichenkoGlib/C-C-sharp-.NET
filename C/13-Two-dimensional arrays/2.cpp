#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
#define N 5
#define M 5

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	double min = 1.99, max = -1.99, sum, dob, seredne;
	int i, j, counter = 0;
	srand(time(NULL));
	float a[N][M] = { };
	for (i = 0; i < N; i++) {
		sum = 0;
		for (j = 0; j < M; j++) {
			a[i][j] = rand() / double(RAND_MAX) + 1.f;
			printf("%.2f ", a[i][j]);
			sum += a[i][j];
			if (max < a[i][j])
				max = a[i][j];
			if (min > a[i][j])
				min = a[i][j];
		}
		printf("   |Сума рядка = %.2f\n", sum); // виведення суми рядків матриці
	}
	printf("\n");
	// Завдання №1 (Знаходження MAX )
	printf("max = %.2f\n", max); // виводжу значення max
	for (i = 0; i < N; i++) {
		for (j = 0; j < M; j++) {
			if (max == a[i][j])
				printf("row: %d, col: %d\n", i + 1, j + 1); // виводжу індекси max
		}
	}
	printf("\n");
	// Завдання №2 (Знаходження MIN)
	printf("min = %.2f\n", min); // виводжу значення min
	for (i = 0; i < N; i++) {
		for (j = 0; j < M; j++) {
			if (min == a[i][j])
				printf("row: %d, col: %d\n", i + 1, j + 1); // виводжу індекси min
		}
	}
	printf("\n");
	// Завдання №3 (Знаходження середньоарифметичного значення елементів кожного рядка)
	for (i = 0; i < N; i++) {
		counter++;
		sum = 0;
		for (j = 0; j < M; j++) {
			sum += a[i][j]; //  сума рядка матриці
			seredne = sum / N;
		}
		printf("Середнє арифметичне рядка №%d = %.2f\n", counter, seredne);
	}
	printf("\n");
	// Завдання №4-5 (обчисліть добуток і суму елементів головної діагоналі)
	sum = 0;
	dob = 1;
	for (i = 0; i < N; i++) {
		for (j = 0; j < M; j++) {
			if (i == j)
			{
				dob = dob * a[i][j];
				sum = sum + a[i][j];
			}
		}
	}
	printf("\ndob = %.2f", dob);
	printf("\nsum = %.2f", sum);
	printf("\n");
	// Завдання №6 (обчисліть суму елементів під головною діагоналлю)
	sum = 0;
	for (i = 0; i < N; i++) {
		for (j = 0; j < M; j++) {
			if (i < j)
			{
				sum = sum + a[i][j];
			}
		}
	}
	printf("\nsum = %.2f", sum);
}