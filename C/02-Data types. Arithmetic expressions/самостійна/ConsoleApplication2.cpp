#include "pch.h"
#include <iostream>
#include<stdio.h>
#include<math.h>
#include<Windows.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	float a, b, c, A, B, Y, S, P, h;
	printf("ВВедіть a: "); scanf_s("%f", &a);
	printf("ВВедіть b: "); scanf_s("%f", &b);
	printf("ВВедіть P: "); scanf_s("%f", &P);
	c = P - (a + b);
	S = sqrt((P/2)*(P/2 - a)*(P/2 - b)*(P/2 - c));
	h = (2*S) / c;
	A = (2 * S) / b * c;
	B = (2 * S) / a * c;
	Y = (2 * S) / a * b;
	printf("\nc=%.1f", c);
	printf("\nh=%.1f", h);
	printf("\nA=%.1f", A);
	printf("\nB=%.1f", B);
	printf("\nY=%.1f", Y);
	printf("\nS=%.1f", S);
	return 0;
}
