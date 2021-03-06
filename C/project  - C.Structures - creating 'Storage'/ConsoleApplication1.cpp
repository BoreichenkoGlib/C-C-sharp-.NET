#include "pch.h"
#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include <windows.h>

struct date
{
	int day;
	int month;
	int year;
};

struct arsenal
{
	char category[20];
	char name[20];
	int price;
	int number;
	date dateofcome;
	date dateofleave;
};

arsenal ReadArticle()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	arsenal newArticle;
	printf("\nКатегорія: "); gets_s(newArticle.category); gets_s(newArticle.category);
	printf("\nнайменування: "); gets_s(newArticle.name);
	printf("\nвартість: "); scanf_s("%d", &newArticle.price);
	printf("\nкількість: "); scanf_s("%d", &newArticle.number);
	printf("\nдата надходження:");
	printf("\nдень:"); scanf_s("%d", &newArticle.dateofcome.day);
	printf("\nмісяць:"); scanf_s("%d", &newArticle.dateofcome.month);
	printf("\nрік:"); scanf_s("%d", &newArticle.dateofcome.year);
	printf("\nдата вибуття: ");
	printf("\nдень:"); scanf_s("%d", &newArticle.dateofleave.day);
	printf("\nмісяць:"); scanf_s("%d", &newArticle.dateofleave.month);
	printf("\nрік:"); scanf_s("%d", &newArticle.dateofleave.year);
	getchar();
	return newArticle;
}

void PrintArticle(arsenal art)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	printf("категорія: %s; назва: %s; вартість: %d; кількість: %d; дата надходження: %d/%d/%d; дата вибуття: %d/%d/%d\n", art.category, art.name, art.price, art.number, art.dateofcome.day, art.dateofcome.month, art.dateofcome.year, art.dateofleave.day, art.dateofleave.month, art.dateofleave.year);
}

void PrintArticles(arsenal *box, int count)
{
	for (int i = 0; i < count; i++)
	{
		printf("%d. ", i + 1);
		PrintArticle(box[i]);
	}
}

int Menu()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int num;
	printf("================Меню==============\n");
	printf("1. Введення даних про товари на складі\n");
	printf("2. Виведення даних про товари\n");
	printf("3. Пошук товару\n");
	printf("4. Видалення даних про товар\n");
	printf("5. Впорядкування даних за спаданням вартості товару\n");
	printf("6. Редагування даних про товари\n");
	printf("0. Вихід\n");
	printf("-> ");
	scanf_s("%d", &num);
	return num;
}

arsenal*buff(const char*path, int *count)
{
	arsenal*arr = NULL;
	FILE*f = fopen(path, "rb");
	fseek(f, 0, SEEK_END);
	*count = ftell(f) / sizeof(arsenal);
	rewind(f);
	arr = (arsenal*)malloc((*count) + 25 * sizeof(arsenal));
	fread(arr, sizeof(arsenal), *count, f);
	fclose(f);
	return arr;
}

void writeStruct(arsenal*arr, const char*path, int count)
{
	FILE*f = fopen("practice.bin", "wb");
	for (int i = 0; i < count; i++)
		fwrite(&arr[i], sizeof(arsenal), 1, f);
	fclose(f);
}

void InputData(arsenal*box, int count)
{
	for (int i = 0; i < count; i++)
	{
		printf("%d.=============================================", i + 1);
		box[i] = ReadArticle();
	}
}

void SearchData(arsenal*box, int count)
{
	int year, j;
	int resCount = 0;
	char array[35];
	int x = 0, y;
	printf("Пошук за: \n1 -за категорією\n2 - за найменуванням\n3 - за вартістю\n4 - за роком надходження");
	printf("\n>>"); scanf_s("%d", &j);
	switch (j)
	{
	case 1:
		printf("\n>>Введіть категорію: ");
		gets_s(array); gets_s(array);
		for (int i = 0; i < count; i++)
		{
			if (strcmp(box[i].category, array) == 0) x = i;
			if (x == i)
			{
				PrintArticle(box[i]);
				resCount++;
				if (resCount == 0)
					printf("По даному запросу нічого не знайдено\n");
			}
		}break;
	case 2:
		printf("\n>>Введіть назву: ");
		gets_s(array); gets_s(array);
		for (int i = 0; i < count; i++)
		{
			if (strcmp(box[i].name, array) == 0)
				x = i;
			if (x == i)
			{
				PrintArticle(box[i]);
				resCount++;
				if (resCount == 0)
					printf("По даному запросу нічого не знайдено\n");
			}
		}break;
	case 3:
		printf("\n>>Введіть вартість: ");
		scanf_s("%d", &y);
		for (int i = 0; i < count; i++)
		{
			if (y == box[i].price)
				x = 1;
			if (x == 1)
			{
				PrintArticle(box[i]);
				resCount++;
				if (resCount == 0)
					printf("По даному запросу нічого не знайдено\n");
			}
			x = 0;
		}break;
	case 4:
		printf("\n>>Введіть рік: "); scanf_s("%d", &year);
		for (int i = 0; i < count; i++)
			if (box[i].dateofcome.year == year)
			{
				PrintArticle(box[i]);
				resCount++;
			}
		if (resCount == 0)
			printf("По даному запросу нічого не знайдено\n");
	}
}

void EditData(arsenal*box, int count)
{
	int t;
	PrintArticles(box, count);
	printf("Введіть номер запису для редагування: "); scanf_s("%d", &t);
	t--;
	printf("\nКатегорія: "); gets_s(box[t].category); gets_s(box[t].category);
	printf("\nнайменування: "); gets_s(box[t].name);
	printf("\nвартість: "); scanf_s("%d", &box[t].price);
	printf("\nкількість: "); scanf_s("%d", &box[t].number);
	printf("\nдата надходження:");
	printf("\nдень:"); scanf_s("%d", &box[t].dateofcome.day);
	printf("\nмісяць:"); scanf_s("%d", &box[t].dateofcome.month);
	printf("\nрік:"); scanf_s("%d", &box[t].dateofcome.year);
	printf("\nдата вибуття: ");
	printf("\nдень:"); scanf_s("%d", &box[t].dateofleave.day);
	printf("\nмісяць:"); scanf_s("%d", &box[t].dateofleave.month);
	printf("\nрік:"); scanf_s("%d", &box[t].dateofleave.year);
	PrintArticles(box, count);
}

void DeleteData(arsenal*box, int count)
{
	int l;
	printf("Введіть номер запису який хочете видалити: \n"); scanf_s("%d", &l);
	for (int i = l; i < count; i++)
	{
		box[l - 1] = box[l];
		PrintArticle(box[i]);
	}
	count--;
}

void SortData(arsenal*box, int count)
{
	arsenal b;
	for (int i = 0; i < count; i++)
		if (box[i].price < box[i + 1].price)
		{
			b = box[i];
			box[i] = box[i + 1];
			box[i + 1] = b;
		}
	PrintArticles(box, count);
}

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int count;
	int num = 0, n = 0;
	/*arsenal*box = (arsenal*)calloc(RAND_MAX, sizeof(arsenal));*/
	arsenal* box = buff("practice.bin", &count);
	do
	{
		num = Menu();
		switch (num)
		{
		case 1: //введення записів
			printf("Введіть кількість записів: ");
			scanf_s("%d", &count);
			InputData(box, count);
			break;
		case 2://виведення записів
			PrintArticles(box, count);
			break;
		case 3://пошук 
			SearchData(box, count);
			break;
		case 4://видалення даних
			DeleteData(box, count);
			break;
		case 5://сортування за спаданням вартості товарів
			SortData(box, count);
			break;
		case 6://редагування даних про товари
			EditData(box, count); 
		}
	} while (num != 0);
	writeStruct(box, "practice.bin", count);
	return 0;
}