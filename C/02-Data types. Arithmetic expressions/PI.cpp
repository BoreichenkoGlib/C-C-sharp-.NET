#include"pch.h"
#include<iostream>
#include <stdio.h>
#include<math.h>

int main()
{
	float deg, rad;
	const float pi = 3.1415926;
	printf("\nVvedite Deg: "); scanf_s("%f", &deg);
	rad = deg * (pi / 180);
	printf("\nRad=%.6f", rad);
	return 0;
}
