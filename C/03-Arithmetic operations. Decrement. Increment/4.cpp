#include "pch.h"
#include <iostream>
#include<stdio.h>
#include<math.h>
#include<Windows.h>

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int m, n, a, b, c, d, e, f;
	printf("ВВедіть m: "); scanf_s("%d", &m);
	printf("ВВедіть n: "); scanf_s("%d", &n);
	a = m + --n;
	b = m++ < ++n;
	c = n-- < --m;
	d = --m - ++n;
	e = m * --n;
	f = n-- > m++;
	printf("\na=%d", a);
	printf("\nb=%d", b);
	printf("\nc=%d", c);
	printf("\nd=%d", d);
	printf("\ne=%d", e);
	printf("\nf=%d", f);
	return 0;
}
