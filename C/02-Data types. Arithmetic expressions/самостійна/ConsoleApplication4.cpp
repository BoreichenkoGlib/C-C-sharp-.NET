#include "pch.h"
#include <iostream>
#include<stdio.h>
#include<math.h>
#include<Windows.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	float a, b, c, A, B, Y, S, P, h, BK;
	printf("ВВедіть S: "); scanf_s("%f", &S);
	printf("ВВедіть c: "); scanf_s("%f", &c);
	printf("ВВедіть A: "); scanf_s("%f", &A);
	h = (2 * S) / c;
	b = (2 * S) / (c*sin(A));
	BK = c - sqrt(b*b - h * h);
	a = sqrt(BK*BK + h * h);
	P = a + b + c;
	B = sin((2 * S) / (a * c));
	Y = 180 - (A + B);
	printf("\na=%.1f", a);
	printf("\nb=%.1f", b);
	printf("\nB=%.1f", B);
	printf("\nY=%.1f", Y);
	printf("\nP=%.1f", P);
	printf("\nh=%.1f", h);
	return 0;
}