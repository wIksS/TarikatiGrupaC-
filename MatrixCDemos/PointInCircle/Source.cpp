#include "iostream"

using namespace std;

struct Point {
	double x;
	double y;
};

int main()
{
	int n;
	cin >> n;
	Point *points = new Point[n];
	int radius;
	cout << "Enter circle radius: ";
	cin >> radius;

	for (int i = 0; i < n; i++)
	{
		cout << "Enter point x: ";
		cin >> points[i].x;

		cout << "Enter point y: ";
		cin >> points[i].y;

		double distance = sqrt(points[i].x * points[i].x + points[i].y * points[i].y);

		if (distance <= radius)
		{
			cout << "Point is inside circle";
		}
		else
		{
			cout << "Outside of circle!";
		}

		cout << endl;
	}

	return 0;
}