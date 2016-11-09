#pragma once
#include <string>
#include "Point.h"

using namespace std;

class PointList {

private:

	Point *points[100];

public:

	PointList();

	bool AddPoint(Point *arg);
	void Print();
	double GetDistance();

};
