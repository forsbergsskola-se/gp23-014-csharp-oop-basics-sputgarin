Item[] items = new Item[3];
int itemValue = 100;
int counter = 1;

for (int i = 0; i < items.Length; i++)
{
    items[i] = new Item();
    items[i].goldValue = itemValue * counter;
    counter++;
    Console.WriteLine(items[i].goldValue);
    
}

for (int i = 0; i < items[i].goldValue; i++)
{
    Console.WriteLine(items[i].goldValue);
}

public class Item
{
    public int goldValue;
}