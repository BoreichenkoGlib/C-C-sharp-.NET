#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
#define A 5
#define B 3

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int sum = 0;
	int a[A][B];
	for (int i = 0; i < A; i++) {
		sum = 0;
		for (int j = 0; j < B; j++) {
			a[i][j] = i - j * i; // формую масив за правилом m[i,j] = i-j*і
			printf("%d ", a[i][j]);
			sum += a[i][j];
		}
		printf("   |%d\n", sum);
	}
}