#include "pch.h"
#include <iostream>
#include<Windows.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	float a = 30.50, x, y, x1, y1;
	x = modf(a, &y);
	y = modf(a, &x);
	x1 = modf(a, &y1);
	y1 = modf(a, &x1);

	printf("x=%.f", x);
	printf("y=%.f", 100 * y);
	printf("\n%.f гривень %.f копійок заплатив Коля, щоб піти на %.f атракціон“ Колесо огляду ” у парку, для того щоб у %.f раз подивиться на місто", x, 100*y, x1, 100*y1);
	return 0;
}
