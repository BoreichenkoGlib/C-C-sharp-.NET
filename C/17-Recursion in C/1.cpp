#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>

int func(const int* const ptr, int lastMaxValue, const int* const endPtr)
{
	int newMax = lastMaxValue;
	if (ptr < endPtr)
	{
		if (lastMaxValue < *ptr)
		{
			newMax = *ptr;
		}

		return func(ptr + 1, newMax, endPtr);
	}
	else return lastMaxValue;
}

int main()
{
	int a[10];
	srand(time(NULL));
	for (int i = 0; i < 10; i++) {
		a[i] = rand() % 100;
		printf("%3d", a[i]);
	}
	printf("\nmax = %d", func(&a[0], a[0], &a[sizeof(a) / sizeof(*a)]));

	return 0;
}