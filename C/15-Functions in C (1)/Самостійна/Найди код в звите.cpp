#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>

int ReverseInt(int n)
{
	int x = 0;
	while (n > 0) {
		x *= 10;
		x += n % 10;
		n /= 10;
	}
	return x;
}

int main()
{
	int n;
	printf("n = "); scanf_s("%d", &n);
	result = ReverseInt(n);
	printf("%d", result);
}