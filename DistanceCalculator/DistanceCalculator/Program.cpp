#include "stdafx.h"
#include <string>
#include "DistanceCalculator.h"
#include "Point.h"
#include "PointList.h"
#include <iostream>

int main()
{
	PointList * pTheList = new PointList();
	pTheList->Add(new Point(48.803242, 9.221968, "70372 Stuttgart, Kreuznacher Strasse 47"));
	pTheList->Add(new Point(48.811465, 9.229727, "70374 Stuttgart, Gnesener Strasse 69"));
	pTheList->Add(new Point(48.801934, 9.235032, "70374 Stuttgart, Ruhrstrasse 50"));
	pTheList->Add(new Point(48.803242, 9.221968, "70372 Stuttgart, Kreuznacher Strasse 47"));

	pTheList->Print();
	cout << endl;

	cout << "Gesamtdistanz: " << pTheList->GetDistance() << " km" << std::endl;

	system("pause");

	delete pTheList;
}