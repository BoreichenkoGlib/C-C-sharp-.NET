#include "pch.h"
#include <iostream>
#include <Windows.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int n = 1, i = 2, result = 0, num = 0; //num - номер послідовності
	for (i = 2; result < 100; i)
		for (n = 1; result < 100; n = 2 * n)
			if (result < 100)
			{
				result = i * n;
				num++;
				printf("\n%d = %d", num, result);
			}
	printf("\nНомер послідовності = %d", num);
}