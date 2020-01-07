#pragma once
#include <algorithm>
class Math
{
public:
	static double ApproxSigmoid(double value);
	static double GetRandomDouble(double min, double max);
	static int GetRandomInt(int min, int max);
private:
	Math();
};

