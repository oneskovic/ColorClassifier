#pragma once
#include <vector>
#include <string>
#include <sstream> //string stream
#include "FunctionHandler.h"
#include "Math.h"
#define vi std::vector<int>
#define vb std::vector<bool>
#define vd std::vector<double>
#define vvi std::vector<vi>
#define vvd std::vector<vd>
class Grader
{
private:
	int dataset_index;
	int tests_per_organism;
	std::istringstream input_data_stream, valid_outputs_stream;
	FunctionHandler* handler;
	int grade_organism(vd organism, vvi inputs, vb  valid_outputs);
public:
	Grader(std::string input_data_str, std::string valid_outputs_str, int tests_per_organism, FunctionHandler* function_handler);
	vi GradeGeneration(vvd generation);
};

