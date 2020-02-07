#pragma once
#include <vector>
#include <algorithm>
#include "FunctionHandler.h"
class Breeder
{
public:
	static std::vector<std::vector<double>> CreateRandomGeneration(int generation_size, FunctionHandler function_handler);
	static std::vector<double> CreateChild(std::vector<double> parent, std::vector<double> parent2);
	static std::vector<std::vector<double>> CreateGenerationFrom(std::vector<std::vector<double>> seed_organisms, int new_generation_size, FunctionHandler function_handler);
	static std::vector<std::vector<double>> SelectBest(std::vector<std::vector<double>> organisms, std::vector<int> scores, int no_to_select);
};

