#include "stdafx.h"
#include <string>
#include <iostream>
#include "Point.h"

// author: Maximilian Roeck - Matrikelnummer: 185594

using namespace std;

Point::Point(double lat, double lon, string name = "") : m_lat(lat), m_lon(lon), m_name(name) {}

double Point::lat() const {
	return m_lat;
}

double Point::lon() const {
	return m_lon;
}

string Point::name() const {
	return m_name;
}

void Point::Print() {
	cout << "LAT: " << m_lat << " LON: " << m_lon << " " << m_name;
}
