#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>

double DegtoRad(double D)
{
	double Rad = D * 3.14 / 180;
	return Rad;
}

double RadtoDeg(double R)
{
	double Deg = R * 180 / 3.14;
	return Deg;
}

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int num, n = 0;
	printf("1.Перевести градуси в радіани");
	printf("\n2.Перевести радіани в градуси");
	scanf_s("%d", &num);
	switch (num)
	{
	case 1:
		double D, Radresult;
		while (n < 5)
		{
			printf("\nВведіть D: "); scanf_s("%lf", &D);
			Radresult = DegtoRad(D);
			printf("\nRad result = %.4lf", Radresult);
			n++;
		}
	case 2:
		double R, Degresult;
		while (n < 5)
		{
			printf("\nВведіть R: "); scanf_s("%lf", &R);
			Degresult = RadtoDeg(R);
			printf("\nDeg result = %.4lf", Degresult);
			n++;
		}
	}
	_getch();
	return 0;
}