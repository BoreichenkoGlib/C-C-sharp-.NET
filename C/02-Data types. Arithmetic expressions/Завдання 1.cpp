#include"pch.h"
#include<iostream>
#include<stdio.h>
#include<math.h>
int main()
{
	float a, b, c, d, x, y, z, S;
	printf("\nVvedite x: ");     scanf_s("%f", &x);
	printf("\nVvedite y: ");     scanf_s("%f", &y);
	printf("\nVvedite z: ");     scanf_s("%f", &z);
	a = 5 * cos(x);
	b = z / 4;
	c = sin(y);
	d = (4 * fabs(z - x) - 5) / (z*(x - y) + z * z);
	S = a - b * c*d;
	printf("Result S=%.6f", S);
	return 0;
}

