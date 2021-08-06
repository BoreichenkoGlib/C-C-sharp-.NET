#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>

double seredne(double N, double arr[5]);

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	double arr[5];
	srand(time(NULL));
	for (int i = 0; i < 5; i++) {
		arr[i] = rand() / double(RAND_MAX) + 1.f;
		printf("%.2f ", arr[i]);
	}
	double result = seredne(5, arr);
	printf("\nresult = %.2f", result);
}

double seredne(double N, double arr[5])
{
	double sum = 0, sered;
	for (int i = 0; i < 5; i++)
		sum += arr[i];
	sered = sum / N;
	return sered;
}