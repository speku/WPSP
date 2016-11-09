#pragma once
#include <string>

using namespace std;

class Point {

private:

	const double m_lat;
	const double m_lon;
	const string m_name;

public:

	Point(double lat, double lon, string name);

	double lat() const;
	double lon() const;
	string name() const;

	void Print();

};
