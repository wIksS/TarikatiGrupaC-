// PointersToFunctions.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int Sum(int a, int b);
int Substract(int a, int b);
int Calc(int(*func)(int, int));

int main()
{
	int(*pointerToFunc)(int, int);
	pointerToFunc = &Sum;

	//cout<< pointerToFunc(5,6);
	Calc(pointerToFunc);

	cout << endl;
    return 0;
}

int Calc(int(*func)(int, int))
{
	int result = func(7, 8);
	cout<< result;
	return result;
}

int Sum(int a, int b)
{
	return a + b;
}

int Substract(int a, int b)
{
	return a - b;
}

