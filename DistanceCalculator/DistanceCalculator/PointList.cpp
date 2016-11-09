#include "stdafx.h"
#include <string>
#include <iostream>
#include "Point.h"
#include "PointList.h"
#include "DistanceCalculator.h"


using namespace std;

bool PointList::Add(Point *arg) {
	if (counter > PointList::length - 1) {
		return false;
	}
	else {
		points[counter++] = arg;
		return true;
	}
}

void PointList::Print() {
	for (int i = 0; i < counter; i++) {
		points[i]->Print();
		cout << "\n";
	}
}

double PointList::GetDistance() {
	double distance = 0;
	for (int i = 0; i < counter - 1; i++) {
		distance += DistanceCalculator::getInstance()->Distance(*points[i], *points[i+1]);
	}
	return distance;
}


PointList::~PointList() {
	delete[] points;
}

