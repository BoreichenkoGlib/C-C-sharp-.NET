#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>

int func(int x)
{
	return x * x;
}

int main()
{
	int x, result;
	printf("x = "); scanf_s("%d", &x);
	result = func(x);
	printf("result = %d", result);
}