#include "Math.h"

double Math::ApproxSigmoid(double value)
{
	return value / (1 + abs(value));
}
double Math::GetRandomDouble(double min, double max)
{
	double f = (double)rand() / RAND_MAX;
	return min + f * (max - min);
}
//Returns a random value from interval [min,max]
int Math::GetRandomInt(int min, int max)
{
	return min + (rand() % static_cast<int>(max - min + 1));
}