#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<math.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	float x, y;
	printf("Введіть x: "); scanf_s("%f", &x);
	printf("Введіть y: "); scanf_s("%f", &y);
	if ((y <= x + 1) && (y >= 0) && (x >= 0) && (x*x + y * y >= pow(2, 1 / 2)))
	{
		printf("Істина");
	}
	else
		if ((y <= -x + 1) && (y >= 0) && (x <= 0) && (x*x + y * y >= pow(2, 1 / 2)))
		{
			printf("Істина");
		}
    else printf("Помилка");
	return 0;
}

