Pack pack = new Pack(5, 15f, 20f);

while (true)
{
    Console.WriteLine("\nChoose Item To Add:");
    Console.WriteLine("1 - Arrow");
    Console.WriteLine("2 - Bow");
    Console.WriteLine("3 - Rope");
    Console.WriteLine("4 - Water");
    Console.WriteLine("5 - Food Rations");
    Console.WriteLine("6 - Sword");
    Console.WriteLine("7 - Exit");

    int choice = Convert.ToInt32(Console.ReadLine());

    InventoryItem item = null;

    switch (choice)
    {
        case 1:
            item = new Arrow();
            break;

        case 2:
            item = new Bow();
            break;

        case 3:
            item = new Rope();
            break;

        case 4:
            item = new Water();
            break;

        case 5:
            item = new FoodRations();
            break;

        case 6:
            item = new Sword();
            break;

        case 7:
            return;

        default:
            Console.WriteLine("Invalid Choice");
            continue;
    }

    bool added = pack.Add(item);

    if (added)
    {
        Console.WriteLine("Item added successfully.");
    }
    else
    {
        Console.WriteLine("Cannot add item. Pack limits exceeded.");
    }

    Console.WriteLine("\n--- Pack Status ---");
    Console.WriteLine($"Items: {pack.CurrentItemCount}/{pack.MaxItems}");
    Console.WriteLine($"Weight: {pack.CurrentWeight}/{pack.MaxWeight}");
    Console.WriteLine($"Volume: {pack.CurrentVolume}/{pack.MaxVolume}");
}
