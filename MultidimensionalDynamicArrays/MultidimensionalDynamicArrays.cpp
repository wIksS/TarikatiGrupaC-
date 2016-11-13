// MultidimensionalDynamicArrays.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

int main()
{
	int n = 5;
	int ***cube = new int**[n];

	for (int i = 0; i < n; i++)
	{
		cube[i] = new int*[n];

		for (int j = 0; j < n; j++)
		{
			cube[i][j] = new int[n];
		}
	}

	cube[1][2][3] = 50;

	std::cout << cube[1][2][3];

    return 0;
}

