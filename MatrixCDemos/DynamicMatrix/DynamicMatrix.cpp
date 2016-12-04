// DynamicMatrix.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	int n = 5;
	char **parray = new char*[n];
	for (int i = 0; i < n; i++)
	{
		parray[i] = new char[n];
	}

	for (int row = 0; row < n; row++)
	{
		for (int col = 0; col <= row; col++)
		{
			parray[row][col + (n -1 -row)] = '@';
		}
	}

	
	for (int row = 0; row < n; row++)
	{
		for (int col = 0; col < n; col++)
		{
			if ((int)parray[row][col] < 0)
			{
				cout << " ";
			}
			else 
			{
				cout << parray[row][col];
			}
		}

		cout << endl;
	}

	for (int i = 0; i < n; i++)
	{
		delete[] parray[i];
	}

	delete[] parray;
    return 0;
}

