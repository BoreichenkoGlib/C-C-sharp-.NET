#include "pch.h"
#include<iostream>
#include <cstring>
#include <iostream>
#include <string>
#include <iomanip>
#include <cstdlib>
#include<Windows.h>

int isDelimiter(const char s)
{
	const char Delimiters[10] = " ,.;:?!\n\0";
	for (int i = 0; i < 10; i++)
	{
		if (s == Delimiters[i])
			return true;
	}
	return false;
}

int isVowel(const char s)
{
	const char Vowels[13] = "aeiouyAEIOUY";
	for (int i = 0; i < 13; i++)
	{ 
		if (s == Vowels[i])
			return true;
	}
	return false;
}

void Stroka(char *str)
{
	printf("Vedite: ");
	fgets(str, 255, stdin);
	const int len = strlen(str);
	for (int i = 0, d = 0; i < len - d; i++)
	{
		if (isDelimiter(str[i + 1]) && isVowel(str[i]))
		{
			int j = i;
			while (!isDelimiter(str[j]) && j != -1)
				j--;
			d = i - j;
			for (int k = j; k < len - d; k++)
				str[k + 1] = str[k + d + 1];
			i -= d;
		}
	}
	printf("\nResult: %s \n", str);
}

int main()
{
	char str[256];
	Stroka(str);
	return 0;
}
----------------------------------------------------------------------------------------------------------------------//
void func1(char *str) //знахожу поліндроми
{
	int i, f;
	i = 0;
	while ((str[i] = getchar()) != '\n')
		if (str[i] != ' ') i += 1;
	str[i] = '\0';
	printf("%s\n", str);

	f = 1;
	for (i = 0; i < strlen(str); i++)
		if (str[i] != str[strlen(str) - 1 - i]) {
			printf("No\n");
			f = 0;
			break;
		}
	if (f == 1) printf("Yes it is a polindrome\n");
}

void func2(char *str) //кількість повторень знаків
{
	int i, count, flag;
	count = 0;
	flag = 0;
	for (i = 0; str[i] != '\0'; i++)
		if (str[i] != ' ' && flag == 0) {
			count += 1;
			flag = 1;
		}
		else
			if (str[i] == ' ') flag = 0;
	printf("repeat = %d\n", count);
}

void func3(char *s) //знахожу повтори і видаляю їх
{
	char s_new[100];
	char c, i, j;
	j = 0;
	for (i = 0; i < strlen(s); i++) {
		c = s[i];
		if (strchr(s_new, c) == NULL && c != ' ') {
			s_new[j] = c;
			j += 1;
		}
	}
	s_new[j] = '\0';
	puts(s_new);
}

void func4(char*str) //підрахувати у рядку кількість слів, що починаються з однаковій літери
{
	char *p = NULL;
	char map[127] = { 0 }, i;
	char mapSize = sizeof(map) / sizeof(*map);
	for (p = strtok(str, " "); p; p = strtok(NULL, " "))
	{
		++map[tolower(*p)];
	}
	for (i = 0; i < mapSize; ++i)
	{
		if (isalpha(i) && map[i])
		{
			printf("%c - %u\n", i, map[i]);
		}
	}
}

int cmp(const void * a, const void * b) //порівнюю слова
{
	return strcmp(*(char**)b, *(char**)a);
}

#define get_string(s) ( scanf("%255[^\n]%*c", (s)) == 1 )
#define MAX_WORDS 100
#define DELIM " ,\t\n"

void func5(char *str) //ставлю слова в алфавітному порядку
{
	while (printf("String: ") && get_string(str))
	{
		char * words[MAX_WORDS], *p = strchr(str, '.');
		int count = 0;

		if (p)
			*p = '\0';

		for (p = strtok(str, DELIM); p && count < MAX_WORDS; p = strtok(NULL, DELIM))
			words[count++] = p;

		qsort(words, count, sizeof(char*), cmp);

		while (count)
			printf("%s\n", words[--count]);
	}
}

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	char str[100];
	printf("\nперевірити, чи є у рядку слова паліндроми: ");
	func1(str);// поліндроми
	printf("\nвизначити кількість повторень кожного слова: ");
	fgets(str, 100, stdin);
	func2(str);// повтори знаків
	printf("\nзнайти повторення і видалити їх: ");
	fgets(str, 100, stdin);
	func3(str);// знахожу повтори і видаляю їх
	printf("\nпідрахувати у рядку кількість слів, що починаються з однаковій літери: ");
	fgets(str, 100, stdin);
	func4(str); // слова що починаються з однакової літери
	printf("\nпереставити слова в алфавітному порядку");
	func5(str); // поставити слова в алфавітному порядку
	return 0;
}
