// ConsoleApplication5.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include <iostream>

int main()
{
	int a, b, c, d, e;
	printf("A=");
	scanf_s("%d", &a);
	printf("B=");
	scanf_s("%d", &b);
	printf("C=");
	scanf_s("%d", &c);
	printf("D=");
	scanf_s("%d", &d);
	printf("E=");
	scanf_s("%d", &e);
	printf("(A)/(C*D*D)+(D)/(B-A)+(1)/(E)=%d" ,a/(c*d*d)+d/(b-a)+1/e);
}
