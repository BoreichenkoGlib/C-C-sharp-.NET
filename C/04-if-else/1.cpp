#include "pch.h"
#include <iostream>
#include<locale.h>
#include<math.h>

int main()
{
	float a, b, c, D, x1, x2, x;
	printf("Vvedite a: "); scanf_s("%f", &a);
	printf("Vvedite b: "); scanf_s("%f", &b);
	printf("Vvedite c: "); scanf_s("%f", &c);
	D = b * b - 4 * a*c;
	if (D > 0)
	{
		x1 = (-b + sqrt(D)) / (2 * a);
		x2 = (-b - sqrt(D)) / (2 * a);
		printf("D=%.1f", D);
		printf("\nx1=%.1f\nx2=%.1f", x1, x2);
	}
	else
		if (D == 0)
		{
			x = -b / (2 * a);
			printf("x=%.1f\n", x);
		}
		else printf("Коренів немає\n");
}