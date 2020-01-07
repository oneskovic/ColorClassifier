#include "FunctionHandler.h"
#include <vector>
#include <string>
#include <iostream>
#include <fstream>
#include <sstream>
#include "Grader.h"
#include "Math.h"
#include "Breeder.h"
#include <iterator>
#include <Windows.h>

int main()
{
	srand(time(0));
	FunctionHandler fh = FunctionHandler(10);
	int generation_size = 1000;
	int no_generations = 100;
	int to_select = 30;
	int tests_per_organism = 400;
	std::string inputs_dir = "E:/ColorClassifier/DataSet/inputs/0.in";
	std::string valid_outputs_dir = "E:/ColorClassifier/DataSet/valid_outputs/0.out";
	std::string best_gen_dir = "E:/ColorClassifier/DataSet/results";
	std::ifstream inputs_stream; inputs_stream.open(inputs_dir);
	std::ifstream valid_outputs_stream; valid_outputs_stream.open(valid_outputs_dir);
	std::string inputs_str((std::istreambuf_iterator<char>(inputs_stream)), std::istreambuf_iterator<char>());
	std::string valid_outputs_str((std::istreambuf_iterator<char>(valid_outputs_stream)), std::istreambuf_iterator<char>());
	Grader grader = Grader(inputs_str, valid_outputs_str, tests_per_organism, &fh);

	std::ofstream best_gen_writer; 
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	std::vector<std::vector<double>> prev_generation;
	int prev_best = -1;
	for (int i = 0; i < no_generations; i++)
	{
		if (i == 0)
		{
			prev_generation = Breeder::CreateRandomGeneration(generation_size, fh);
		}
		auto grades = grader.GradeGeneration(prev_generation);
		auto best_worst = std::minmax_element(grades.begin(), grades.end());
		int best_from_gen = *best_worst.second;
		int worst_from_gen = *best_worst.first;
		auto new_generation_seed = Breeder::SelectBest(prev_generation, grades, to_select);
		if (best_from_gen > prev_best)
		{
			SetConsoleTextAttribute(hConsole, 10); //Green
			prev_best = best_from_gen;
		}
		
		else if (best_from_gen == prev_best)
			SetConsoleTextAttribute(hConsole, 6); //Yellow
		
		else
			SetConsoleTextAttribute(hConsole, 4); //Red
		
		std::cout << "Best from generation " << i << ": " << best_from_gen << " correct out of " << tests_per_organism << "\n";
		std::cout << "Worst from generation " << i << ": " << worst_from_gen << " correct out of " << tests_per_organism << "\n";
		best_gen_writer.open(best_gen_dir + "/" + std::to_string(i) + ".txt");
		for (size_t j = 0; j < new_generation_seed[0].size(); j++)
		{
			best_gen_writer << new_generation_seed[0][j] << ",";
		}
		best_gen_writer.close();
		prev_generation = Breeder::CreateGenerationFrom(new_generation_seed, generation_size, fh);
	}
	system("PAUSE");
	return 0;
}