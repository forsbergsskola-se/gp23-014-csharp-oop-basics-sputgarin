using P4_1Replacing;

NotAnotherLemonTree();

void NotAnotherLemonTree()
{
    Plant plant = new Plant();
    plant.PrintStatus();
    plant.Grow();
    plant.PrintStatus();
    plant.Grow();
    plant = new Plant();
    plant.PrintStatus();
}

