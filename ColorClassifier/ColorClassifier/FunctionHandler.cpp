#include "FunctionHandler.h"
#include "Math.h"

FunctionHandler::FunctionHandler(int max_degree)
{
	this->max_degree = max_degree;
}

std::vector<double> FunctionHandler::CreateRandomCoefs()
{
	size_t no_coefs = ((max_degree + 1) * (max_degree + 2) * (max_degree + 3)) / 6;
	auto coefs = std::vector<double>(no_coefs);
	for (int i = 0; i < no_coefs; i++)
		coefs[i] = Math::GetRandomDouble(-1, 1);
	return coefs;
}

std::vector<double> coefs;
vi rgb_values;
int coef_index;
double FunctionHandler::SumAllOfDegree(int degree)
{
	double sum = 0;
	for (int r = 0; r <= degree; r++)
	{
		for (int g = 0; g <= (degree-r); g++)
		{
			int b = degree - (r + g);
			double rr = (double)pow(rgb_values[0], r);
			sum += (double)pow(rgb_values[0], r) * (double)pow(rgb_values[1], g) * (double)pow(rgb_values[2], b) * coefs[coef_index++];
		}
	}
	return sum;
}

double FunctionHandler::EvalFunction(std::vector<double> coefficients, vi RGB_values)
{
	coef_index = 0;
	coefs = coefficients;
	double result_sum = 0;
	rgb_values = RGB_values;
	for (int degree = 0; degree <= max_degree; degree++)
		result_sum += SumAllOfDegree(degree);
	return result_sum;
}


