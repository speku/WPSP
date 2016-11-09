#pragma once
#include <string>
#include "Point.h"

using namespace std;

class DistanceCalculator {

private:

	static DistanceCalculator * m_pTheInstance;
	DistanceCalculator();

public:

	static DistanceCalculator * getInstance();
	double Distance(const Point & from, const Point & to);

};