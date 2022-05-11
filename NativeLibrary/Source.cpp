#include <iostream>
#include <string>

extern	"C" __declspec(dllexport) double NativeAdd(double a, double b);

double NativeAdd(double a, double b)
{
	return a + b ;
}