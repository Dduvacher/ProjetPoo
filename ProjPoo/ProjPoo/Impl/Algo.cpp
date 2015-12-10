#include "Stdafx.h"
#include "Algo.h"
#include <iostream>
#include <algorithm>
#include <time.h>
#include <math.h> 



using namespace std;


//Algorithme qui pose des tuiles aléatoires tout en gardant l'équité entre les tuiles.
void Algo::fillMap(TileType map[], int size)
{
	srand(time(NULL));
	int counter[] = { 0, 0, 0, 0 };
	int max = size / 4;
	int random =rand() % 4;
	for (int i = 0; i < size; i++) 
	{
		while (counter[random] > max)
		{
			random = rand() % 4;
		}
		map[i] = (TileType)random;
		counter[random]++;
		random = rand() % 4;
	}
}