#include "stdafx.h"
#include <string>
#include "Point.h"
#include "DistanceCalculator.h"
#include <iostream>

// author: Maximilian Roeck - Matrikelnummer: 185594

#define DEG_TO_RAD 0.0174532925199432958

using namespace std;


DistanceCalculator *DistanceCalculator::m_pTheInstance = nullptr;


DistanceCalculator::DistanceCalculator() {}


 DistanceCalculator *DistanceCalculator::getInstance() {
	 if (!m_pTheInstance) {
		 m_pTheInstance = new DistanceCalculator();
	 }
	 return m_pTheInstance;
}


 double DistanceCalculator::Distance(const Point & from, const Point & to) {
	 double lat1 = (from.lat() + to.lat()) / 2 * DEG_TO_RAD;
	 double dx = 111.3 * cos(lat1) * (from.lon() - to.lon());
	 double dy = 111.3 * (from.lat() - to.lat());
	 return sqrt(dx * dx + dy * dy);
}
