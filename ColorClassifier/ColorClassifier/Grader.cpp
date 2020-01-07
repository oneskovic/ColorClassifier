#include "Grader.h"
#define TEST_SEP '\n'
#define VALUE_SEP ','

int Grader::grade_organism(vd organism, vvi inputs, vb valid_outputs)
{
	int no_correct = 0;
	for (int i = 0; i < tests_per_organism; i++)
	{
		double value = Math::ApproxSigmoid((*handler).EvalFunction(organism, inputs[i]));
		bool decision;
		if (value >= 0.5) //Positive decision
			decision = 1;
		else //Negative decision
			decision = 0;
		if (decision == valid_outputs[i])
			no_correct++;

	}
	return no_correct;
}

Grader::Grader(std::string input_data_str, std::string valid_outputs_str, int tests_per_organism, FunctionHandler* function_handler)
{
	this->tests_per_organism = tests_per_organism;
	handler = function_handler;
	input_data_stream = std::istringstream(input_data_str);
	valid_outputs_stream = std::istringstream(valid_outputs_str);
	dataset_index = 0;
}

vi Grader::GradeGeneration(vvd generation)
{
	vi results = vi(generation.size());
	for (int i = 0; i < generation.size(); i++)
	{
		vvi inputs; inputs.reserve(generation.size());
		for (int i = 0; i < tests_per_organism; i++)
		{
			std::string input;
			std::getline(input_data_stream, input, TEST_SEP);
			auto rgb_reader = std::istringstream(input);
			vi rgb_values; std::string result_string;
			while (std::getline(rgb_reader,result_string, VALUE_SEP))
			{
				rgb_values.push_back(std::stoi(result_string));
			}
			inputs.push_back(rgb_values);
		}
		vb valid_outputs; valid_outputs.reserve(generation.size());
		for (int i = 0; i < tests_per_organism; i++)
		{
			std::string valid_output;
			std::getline(valid_outputs_stream, valid_output, TEST_SEP);
			bool valid_bool = std::stoi(valid_output);
			valid_outputs.push_back(valid_bool);
		}
		results[i] = grade_organism(generation[i],inputs,valid_outputs);
	}
	return results;
}
