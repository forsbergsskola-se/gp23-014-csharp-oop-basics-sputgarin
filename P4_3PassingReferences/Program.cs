

using P4_3PassingReferences;

House house = new House();

house.PrintOwner();
Sell(house);
house.PrintOwner();

void Sell(House house)
{
    house.owner = "Alex";
}