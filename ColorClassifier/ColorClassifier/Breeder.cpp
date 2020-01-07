#include "Breeder.h"
#include "FunctionHandler.h"
#include "Math.h"
std::vector<std::vector<double>> Breeder::CreateRandomGeneration(int generation_size, FunctionHandler function_handler)
{
	auto generation = std::vector<std::vector<double>>(generation_size);
	for (int i = 0; i < generation_size; i++)
		generation[i] = function_handler.CreateRandomCoefs();
	return generation;
}
std::vector<double> Breeder::CreateChild(std::vector<double> parent, std::vector<double> parent2)
{
	auto child = std::vector<double>(parent.size());
	for (int i = 0; i < parent.size(); i++)
		child[i] = (parent[i] + parent2[i]) / 2.0;
	return child;
}
std::vector<std::vector<double>> Breeder::CreateGenerationFrom(std::vector<std::vector<double>> seed_organisms, int new_generation_size, FunctionHandler function_handler)
{
	if (seed_organisms.size() < 2)
		throw "seed_organisms must contain at least 2 parents";
	
	auto generation = std::vector<std::vector<double>>(new_generation_size);
	for (int i = 0; i < new_generation_size; i++)
	{
		int parent_index = Math::GetRandomInt(0, seed_organisms.size()-1), parent2_index;
		do
		{
			parent2_index = Math::GetRandomInt(0, seed_organisms.size()-1);
		} while (parent_index == parent2_index);
		generation[i] = CreateChild(seed_organisms[parent_index], seed_organisms[parent2_index]);
	}
	return generation;
}
struct scored_organism {
	std::vector<double> genome;
	int score;
};
bool cmp_scored(scored_organism lhs, scored_organism rhs) {
	return lhs.score > rhs.score;
}
std::vector<std::vector<double>> Breeder::SelectBest(std::vector<std::vector<double>> organisms, std::vector<int> scores, int no_to_select)
{
	auto scored_organisms = std::vector<scored_organism>(organisms.size());
	for (size_t i = 0; i < organisms.size(); i++)
	{
		scored_organisms[i].genome = organisms[i];
		scored_organisms[i].score = scores[i];
	}
	std::vector<std::vector<double>> best = std::vector<std::vector<double>>(no_to_select);
	std::sort(scored_organisms.begin(), scored_organisms.end(), cmp_scored);
	for (size_t i = 0; i < no_to_select; i++)
	{
		best[i] = scored_organisms[i].genome;
	}
	return best;
}
