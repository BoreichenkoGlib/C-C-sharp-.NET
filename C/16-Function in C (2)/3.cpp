#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>

int function(int N, int arr[10])
{
	int count = 0;
	for (int i = 0; i < 10; i++) {
		if (arr[i] % 3 == 0 && arr[i] % 1 == 0)
		{
			count++;
		}
	}
	return count;
}

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int arr[10];
	srand(time(0));
	for (int i = 0; i < 10; i++) {
		arr[i] = rand() % 10;
		printf("%3d", arr[i]);
	}
	if (function(10, arr) > 0)
	{
		printf("\nІстина");
		printf("\ncount = %d", function(10, arr));
	}
	else printf("\nБрехня");
	return 0;
}