#include "pch.h"
#include <iostream>
#include <Windows.h>
#include<stdlib.h>
#include<time.h>
#include<conio.h>

int summa(int N, int arr[7]) // функція суми
{
	int i, s = 0;
	for (i = 0; i < N; i++)
		s += arr[i];
	return s;
}

int maximum(int a, int b) // функція максимуму масиву 
{
	if (a >= b)
		return a;
	else return b;
}

int minimum(int a, int b) // функція мінімуму масиву
{
	if (a <= b)
		return a;
	return b;
}

int dob(int N, int arr[7]) // функція добутку масиву
{
	int i, d = 1;
	for (i = 0; i < N; i++)
		d *= arr[i];
	return d;
}

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int arr[7] = { };
	srand((unsigned)time(NULL));
	for (int i = 0; i < 7; i++) { // задаю довільний масив
		arr[i] = rand() % 10;
		printf("%d ", arr[i]);
	}
	int s = summa(7, arr); // обчислення суми елементів масиву
	printf("\nsumma = %d", s);
	int b = arr[0]; // знаходження максимального  значення масиву
	for (int i = 0; i < 7; i++)
		b = maximum(arr[i], b);
	printf("\nmax = %d", b);
	int c = arr[0]; // знаходження мінімального значення масиву
	for (int i = 0; i < 7; i++)
		c = minimum(arr[i], c);
	printf("\nmin = %d", c);
	int d = dob(7, arr); // обчислення добутку елементів масиву
	printf("\ndob = %d", d);
	return 0;

}