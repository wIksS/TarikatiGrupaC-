#include "iostream"
#include "fstream"

using namespace std;

int main()
{
	ifstream inputStream;
	inputStream.open("input.txt");
	char input[100];
	
	int age;
	inputStream >> age;
	cout << age;
	inputStream.close();
	return 0;
}