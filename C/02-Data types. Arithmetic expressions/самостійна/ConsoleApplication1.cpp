#include "pch.h"
#include <iostream>
#include<stdio.h>
#include<math.h>
#include<Windows.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	float a, b, c, A, B, Y, S, P, p, h, BK;
	printf("ВВедіть S: "); scanf_s("%f", &S);
	printf("ВВедіть h: "); scanf_s("%f", &h);
	printf("ВВедіть A: "); scanf_s("%f", &A);
	c = (2 * S) / h;
	b = h / sin(A);
	BK = c - sqrt(b*b - h * h);
	a = sqrt(BK*BK + h * h);
	P = a + b + c;
	B = sin(h / a);
	Y = 180 - (A + B);
    printf("\na=%.1f", a);
	printf("\nb=%.1f", b);
	printf("\nc=%.1f", c);
	printf("\nB=%.1f", B);
	printf("\nY=%.1f", Y);
	printf("\nP=%.1f", P);
	return 0;
}
