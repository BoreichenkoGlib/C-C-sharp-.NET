#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
#include<math.h>
#define N 1

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int a[N] = {};
	int b[N] = {};
	int c[N] = {};
	int d[N] = {};
	int e[N] = {};
	float f[N] = {};
	int g[N] = {};
	int h[N] = {};
	int j[N] = {};
	double k[N] = {};
	int i, num;
	srand(time(NULL));
	printf("Введіть: ");
	scanf_s("%d", &num);
	switch (num)
	{
	case 1:
		for (i = 0; i < N; i++)
			a[i] = -4 + rand() % 3; // 0 ... -2
		for (i = 0; i < N; i++)
			printf("\n1 - %5d", a[i]);
	case 2:
		for (i = 0; i < N; i++)
			b[i] = 100 + rand() % 200; // 100 ... 299
		for (i = 0; i < N; i++)
			printf("\n2 - %5d", b[i]);
	case 3:
		for (i = 0; i < N; i = i + 2)
			c[i] = -34 + rand() % 33; // -34 ... -2
		for (i = 0; i < N; i = i + 2)
			printf("\n3 - %5d", c[i]);
	case 4:
		for (i = 0; i < N; i++)
			d[i] = -128 + rand() % 256; // -128 ... 127
		for (i = 0; i < N; i++)
			printf("\n4 - %5d", d[i]);
	case 5:
		for (i = 0; i < N; i = i + 2)
			e[i] = -7 + rand() % 19; // -7 ... 11
		for (i = 0; i < N; i = i + 2)
			printf("\n5 - %5d", e[i]);
	case 6:
		for (i = 0; i < N; i++)
			f[i] = 0.15 * (rand() % 37); // -7.85 ... 28.3
		for (i = 0; i < N; i++)
			printf("\n6 - %5.2f", f[i]);
	case 7:
		for (i = 0; i < N; i++)
			g[i] = -100 + rand() % 201; // -100 ... 100
		for (i = 0; i < N; i++)
			printf("\n7 - %5d", g[i]);
	case 8:
		for (i = 0; i < N; i++)
			h[i] = 23 + rand() % 48; // 23 ... 71
		for (i = 0; i < N; i++)
			printf("\n8 - %5d", h[i]);
	case 9:
		for (i = 0; i < N; i++)
			j[i] = rand() % 2; // 0 ... 1
		for (i = 0; i < N; i++)
			printf("\n9 - %5d", j[i]);
	case 10:
		for (i = 0; i < N; i++)
			k[i] = pow(17, 1 / 2) + rand() % 66; // pow(17, 1/2) ... pow(82, 1/2)
		for (i = 0; i < N; i++)
			printf("\n10 - %5.2f", k[i]);
	}
	_getch();
}