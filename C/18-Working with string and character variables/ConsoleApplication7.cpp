#include "pch.h"
#include <iostream>
#include <conio.h>
#include <windows.h>
#include <stdio.h>
#include <locale.h>
#include <string.h>
#include <ctype.h>
#define N 256

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	char A[N] = "";
	char *s = A;
	int x = 0;
	printf("Введіть рядок: "); fgets(A, N, stdin);
	while ((s = strpbrk(s, "АОУЕИІаоуеиі")) != NULL)
	{
		x++; s++;
	}
	s = A;
	printf("\nКількість голосних = %d\n", x);
	return 0;
}

int main()
{
	char  str[80], i = 0;
	int sum = 0;
	puts("Enter  a string:");
	fgets(str, 80, stdin);
	while (str[i] && str[i] != '\n')
	{
		if (str[i] >= '0'  &&  str[i] <= '9')
			sum += str[i] - '0';
		i++;
	}
	printf("Sum=%d\n", sum);
	return 0;
}

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	char  str[80] = "1 2 3 4 5 6 7 8 9";
	char i = 0;
	while (str[i] && str[i] != '\n')
	{
		if (str[i] >= '1'  &&  str[i] <= '9')
		{
			if (str[0] % 2 == 0)
			{
				str[i] = str[i + 2];
			}
			else
				if (str[0] % 2 != 0)
				{
					str[i] = str[i + 3];
				}
		}
		i++;
	}
	printf("%s", str);
	return 0;
}

#define N 256
int v_Slove(char *ps)
{
	char d[] = " .,;:!?\n\0";
	char *pa = ps;
	int i;
	for (i = 0; i < 9; i++)
	{
		if (*pa == d[i])return 0;
	}
	return 1;
}

int kol_simv(char *ps)
{
	int c = 0;
	char *pps = ps;
	while (v_Slove(pps))
	{
		c++;
		pps++;
	}
	return c;
}

int chislo(char *ch)
{
	return (*ch >= '0'&&*ch <= '9');
}

int nachalo_chisla(char * ch)
{
	return (chislo(ch) && (!chislo(ch - 1)));
}

int kol_chisel_v_texte(char *ps)
{
	int i, c;
	for (i = 0, c = 0; ps[i] != '\0'; i++)
	{
		if (nachalo_chisla(&ps[i]))
		{
			while (chislo(&ps[i++]));
			c++; i--;
		}
	}
	return c;
}

int latin_bukva(char *lat)
{
	return ((*lat >= '\x61') && (*lat <= '\x7a')) || ((*lat >= '\x41') && (*lat <= '\x5a'));
}

int slovo_is_latin_bukv(char *ps)
{
	char*pps = ps;
	int c = kol_simv(ps);
	while (v_Slove(pps) && latin_bukva(pps))
	{
		--c;
		pps++;
	}
	return   (c == 0) ? 1 : 0;
}

void vivod_slov_is_lat_bukv(char *a)
{
	int i;
	char *n;
	for (i = 0; a[i] != '\0'; i++)
	{
		if (v_Slove(&a[i]) && (i == 0 || !v_Slove(&a[i - 1])))
		{
			if (slovo_is_latin_bukv(&a[i]))
			{
				n = &a[i];
				while (v_Slove(n))
				{
					printf("%c", *n);
					n++; i++;
				}
				printf("\n");
			}
		}
	}
}

char *udal_kazd_2_slovo(char *a)
{
	int c, i;
	char *k;
	for (i = 0, c = 1; a[i] != '\0'; i++)
	{
		if (v_Slove(&a[i]) && (i == 0 || !v_Slove(&a[i - 1])))
		{
			if (c % 2 == 0)
			{
				k = &a[i] + kol_simv(&a[i]);
				a[i] = '\0';
				strcat(&a[i], k);
			}
			c++;
		}
	}
	return a;
}
int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	char A[N] = " арвр swap, папа миля no 345 2пол и 3три fgbvff. ";
	printf("%s\n", A);
	printf("Кількість чисел: %d\n", kol_chisel_v_texte(A));
	vivod_slov_is_lat_bukv(A);
	printf("Рядок з видаленими словами: %s\n", udal_kazd_2_slovo(A));
	return (0);
}

int main()
{
	int i;
	char k[100], a, z;
	printf("Vvedit slovo \n");
	fgets(k, 100, stdin);
	for (i = 0; i < strlen(k); i++) {
		switch (k[i])
		{
		case'A':case'a': {printf(".\a -\a.\a   "); break; }
		case'B':case'b': {printf(".\a-\a .\a -\a   "); break; }
		case'W':case'w': {printf(".-\a .\a.\a  .\a-\a   "); break; }
		case'G':case'g': {printf(".\a-a .\a.\a .\a   "); break; }
		case'D':case'd': {printf(".\a.\a -\a -\a   "); break; }
		case'E':case'e': {printf(".\a   "); break; }
		case'V':case'v': {printf(".\a -\a -\a .\a.\a   "); break; }
		case'Z':case'z': {printf("-\a-\a .\a.\a .\a -\a   "); break; }
		case'I':case'i': {printf(".\a -\a   "); break; }
		case'K':case'k': {printf(".\a-\a .\a -\a.\a   "); break; }
		case'L':case'l': {printf(".\a -\a.\a .\a -\a   "); break; }
		case'M':case'm': {printf(".\a-\a -\a.\a   "); break; }
		case'N':case'n': {printf("-\a.\a .\a   "); break; }
		case'O':case'o': {printf("-\a-\a -\a.\a .\a.\a   "); break; }
		case'P':case'p': {printf(".\a .\a-\a .\a-\a -\a   "); break; }
		case'R':case'r': {printf("-\a -\a-\a .\a   "); break; }
		case'S':case's': {printf(".\a .\a -\a   "); break; }
		case'T':case't': {printf(".\a.\a   "); break; }
		case'U':case'u': {printf(".\a -\a -\a-\a   "); break; }
		case'F':case'f': {printf(".\a .\a -\a.\a -\a   "); break; }
		case'H':case'h': {printf(".\a -\a -\a .\a   "); break; }
		case'C':case'c': {printf(".\a-\a .\a -\a.\a -\a   "); break; }
		case'Q':case'q': {printf(".\a-\a -\a.\a -\a .\a-\a   "); break; }
		case'Y':case'y': {printf(".\a-\a .\a -\a-\a -\a.\a   "); break; }
		case'J':case'j': {printf("-\a .\a-\a .\a.\a .\a.\a   "); break; }
		case'X':case'x': {printf(".\a-\a -\a .\a -\a.\a   "); break; }
		case'1': {printf(".\a -\a-\a .\a-\a .\a-\a -\a.\a   "); break; }
		case'2': {printf(".\a .\a -\a.\a -\a.\a .\a.\a   "); break; }
		case'3': {printf("-\a -\a .\a -\a.\a .\a-\a   "); break; }
		case'4': {printf(".\a .\a .\a -\a -\a.\a   "); break; }
		case'5': {printf("-\a .\a .\a .\a .\a   "); break; }
		case'6': {printf(".\a-\a .\a -\a .\a -\a   "); break; }
		case'7': {printf(".\a.\a -\a.\a .\a .\a -\a   "); break; }
		case'8': {printf("-\a.\a -\a.\a .\a-\a .\a .\a   "); break; }
		case'9': {printf(".\a.\a .\a.\a -\a.\a .\a.\a .\a   "); break; }
		case'0': {printf(".\a-\a -\a.\a .\a.\a .\a.\a .\a.\a   "); break; }
		case',': {printf(".\a -.\a-\a .\a -\a-\a .\a -\a-\a   "); break; }
		}
	}
	return 0;
	getch();
}