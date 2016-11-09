#pragma once
#include <string>
#include "Point.h"

// author: Maximilian Roeck - Matrikelnummer: 185594

using namespace std;

class DistanceCalculator {

private:

	static DistanceCalculator * m_pTheInstance;
	DistanceCalculator();

public:

	static DistanceCalculator * getInstance();
	double Distance(const Point & from, const Point & to);

};