#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>

double func(double x, double y)
{
	do {
		y = y / 10;
	} while (y > 1);
	return x + y;
}

int main()
{
	double a, x, y;
	printf("x = "); scanf_s("%lf", &x);
	printf("y = "); scanf_s("%lf", &y);
	a = func(x, y);
	printf("\n%f", a);
}