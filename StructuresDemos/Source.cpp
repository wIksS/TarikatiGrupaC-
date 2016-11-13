#include "iostream"

using namespace std;

struct Dog {
	int age;
	char name[50];
	int legs;
} dog;

int main()
{
	Dog thirdDog = {6,"pesho",4};
	cout << thirdDog.age;
	//cout << "Enter name:";
	//cin >> dog[0].name;
	//cout << "Enter age:";
	//cin >> dog[0].age;

	//cout << dog[0].name << " is " << dog[0].age << " years old";

	//cout << endl;
	return 0;
}

