#include "pch.h"
#include <iostream>
#include<stdio.h>
#include<math.h>

int main()
{
	float a, b, с;
	printf("\nVvedite A: "); scanf_s("%f", &a);
	printf("\nVvedite B: "); scanf_s("%f", &b);
	a = a + b;     
	b = a - b;     
	a = a - b;   
	printf("\n a=%.f", a); printf(" b=%.f", b);

	printf("\nVvedite B: "); scanf_s("%f", &b);
	printf("\nVvedite C: "); scanf_s("%f", &c);
	b = b + c;
	c = b - c;
	b = b - c;
	printf("\n b=%.f", b); printf(" c=%.f", c);

	printf("\nVvedite C: "); scanf_s("%f", &c);
	printf("\nVvedite A: "); scanf_s("%f", &a);
	c = c + a;
	a = c - a;
	c = c - a;
	printf("\n c=%.f", c); printf(" a=%.f", a);
	return 0;
}

