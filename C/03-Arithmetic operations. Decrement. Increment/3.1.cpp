#include "pch.h"
#include <iostream>
#include<math.h>

int main()
{
	float a, b, S, x, y, z;
	printf("\nVvedite a: ");     scanf_s("%f", &a);
	printf("\nVvedite b: ");     scanf_s("%f", &b);
	x = pow((a - b), 3);
	y = pow(a, 3);
	z = b * b*b - 3 * a*b*b - 3 * a*a*b;
	S = (x - y) / z;
    printf("Result = %.6f", S);
	return 0;
}
