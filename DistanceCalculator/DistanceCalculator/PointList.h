#pragma once
#include <string>
#include "Point.h"


using namespace std;

class PointList {

private:

	static const int length = 100;
	int counter = 0;

	Point** points = new Point*[length];

public:

	~PointList();

	bool Add(Point *arg);
	void Print();
	double GetDistance();

};
