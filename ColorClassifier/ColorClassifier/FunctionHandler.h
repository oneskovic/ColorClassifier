#pragma once
#include <stdlib.h>
#include <ctime>
#include <vector>
#define vi std::vector<int>
class FunctionHandler
{
private:
	int max_degree;
	double SumAllOfDegree(int degree);
public:
	FunctionHandler(int max_degree);
	std::vector<double> CreateRandomCoefs();
	double EvalFunction(std::vector<double> coefficients, vi RGB_values);
};

