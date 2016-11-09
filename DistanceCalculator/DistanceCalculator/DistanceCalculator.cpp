#include <string>
#include "Point.h"
#include "PointList.h"
#include "DistanceCalculator.h"

#define DEG_TO_RAD 0.0174532925199432958


using namespace std;

DistanceCalculator * DistanceCalculator::m_pTheInstance = nullptr;


 DistanceCalculator * DistanceCalculator::getInstance() {
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


 int main()
 {
	 PointList * pTheList = new PointList();
	 pTheList->Add(new Point(48.803242, 9.221968, "70372 Stuttgart, Kreuznacher Strasse 47"));
	 pTheList->Add(new Point(48.811465, 9.229727, "70374 Stuttgart, Gnesener Strasse 69"));
	 pTheList->Add(new Point(48.801934, 9.235032, "70374 Stuttgart, Ruhrstrasse 50"));
	 pTheList->Add(new Point(48.803242, 9.221968, "70372 Stuttgart, Kreuznacher Strasse 47"));

	 pTheList->Print();
	 std::cout << std::endl;

	 std::cout << "Gesamtdistanz: " << pTheList->GetDistance() << " km" << std::endl;

	 std::system("pause");

	 delete pTheList;
 }
