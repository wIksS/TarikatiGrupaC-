// DiagonalMatrix.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

void PrintMatrix(int **pmatrix, int rows, int cols);

int main()
{
	int n;
	cin >> n;

	int **pmatrix = new int*[n];
	for (int i = 0; i < n; i++)
	{
		pmatrix[i] = new int[n];
	}

	for (int i = 0; i < n; i++)
	{
		pmatrix[i][i] = 1;
	}

	PrintMatrix(pmatrix, n, n);

	return 0;
}

void PrintMatrix(int **pmatrix, int rows, int cols)
{
	for (int row = 0; row < rows; row++)
	{
		for (int col = 0; col < cols; col++)
		{
			if (pmatrix[row][col] < 0)
			{
				cout << 0;
			}
			else
			{
				cout << pmatrix[row][col];
			}
		}

		cout << endl;
	}
}

